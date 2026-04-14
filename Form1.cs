using System.ComponentModel;
using System.Text;

using CertificatesTool.Forms;
using CertificatesTool.Models;
using CertificatesTool.Services;

namespace CertificatesTool
{
    public partial class Form1 : Form
    {
        private readonly CredentialRepository _repository = new();
        private readonly CredentialFactory _factory = new();
        private readonly CredentialExporter _exporter = new();
        private readonly CryptoService _crypto = new();

        private readonly BindingList<Credential> _credentials;

        public Form1()
        {
            InitializeComponent();

            _credentials = new BindingList<Credential>(_repository.LoadAll());
            FilesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            FilesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FilesGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            FilesGrid.DataBindingComplete += FilesGrid_DataBindingComplete;
            FilesGrid.DataSource = _credentials;
        }

        private void FilesGrid_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in FilesGrid.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            if (FilesGrid.Columns[nameof(Credential.ValidTo)] is { } lastColumn)
                lastColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private Credential? GetSelectedCredential()
        {
            return FilesGrid.CurrentRow?.DataBoundItem as Credential;
        }

        private static string DesktopPath =>
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _repository.SaveAll(_credentials);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Error al guardar credenciales: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCredentialButton_Click(object sender, EventArgs e)
        {
            using var dialog = new AddCredentialForm(_factory);
            if (dialog.ShowDialog(this) != DialogResult.OK || dialog.Result is null)
                return;

            var incoming = dialog.Result;
            if (_credentials.Any(c => string.Equals(
                    c.RazonSocial, incoming.RazonSocial, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show(this,
                    $"Ya existe una credencial con la razón social \"{incoming.RazonSocial}\".",
                    "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _credentials.Add(incoming);
            _repository.SaveAll(_credentials);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedCredential();
            if (selected is null) return;

            _credentials.Remove(selected);
            _repository.SaveAll(_credentials);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (_credentials.Count == 0) return;

            var confirm = MessageBox.Show(this,
                "¿Eliminar todas las credenciales?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            _credentials.Clear();
            _repository.SaveAll(_credentials);
        }

        private void ExportCerButton_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedCredential();
            if (selected is null)
            {
                MessageBox.Show(this, "Selecciona una credencial.", "Exportar .cer",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var path = _exporter.ExportCertificate(selected, DesktopPath);
                MessageBox.Show(this, $"Certificado exportado:\n{path}", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportKeyButton_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedCredential();
            if (selected is null)
            {
                MessageBox.Show(this, "Selecciona una credencial.", "Exportar .key",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var path = _exporter.ExportPrivateKey(selected, DesktopPath);
                MessageBox.Show(this, $"Llave privada exportada:\n{path}", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SavePairButton_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedCredential();
            if (selected is null)
            {
                MessageBox.Show(this, "Selecciona una credencial.", "Exportar par",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var path = _exporter.ExportPairText(selected, DesktopPath);
                MessageBox.Show(this, $"Par exportado:\n{path}", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EncodePkPassButton_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedCredential();
            if (selected is null)
            {
                EncodedPkPassTextBox.Text = string.Empty;
                return;
            }

            EncodedPkPassTextBox.Text =
                Convert.ToBase64String(Encoding.UTF8.GetBytes(selected.Password));
        }

        private void SignAndVerifyButton_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedCredential();
            if (selected is null)
            {
                MessageBox.Show(this, "Selecciona una credencial.", "Firma",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var (_, isValid) = _crypto.SignAndVerify(selected, "Hello world");
                MessageBox.Show(this, $"isValid {isValid}", "Firma y verificación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyBase64CerButton_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedCredential();
            if (selected is null) return;
            CopyToClipboard(selected.CertificateBase64, ".cer (base64)");
        }

        private void CopyBase64KeyButton_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedCredential();
            if (selected is null) return;
            CopyToClipboard(selected.PrivateKeyBase64, ".key (base64)");
        }

        private void CopyPlainPassPhraseButton_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedCredential();
            if (selected is null) return;
            CopyToClipboard(selected.Password, "contraseña");
        }

        private void CopyToClipboard(string value, string label)
        {
            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show(this, $"No hay {label} para copiar.", "Copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Clipboard.SetText(value);
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                var base64 = Base64FileTextBox.Text.Trim();
                var extension = FileExtensionTextBox.Text.Trim();
                var path = _exporter.SaveBase64ToFile(base64, extension, DesktopPath);
                MessageBox.Show(this, $"Archivo guardado:\n{path}", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Base64 inválido. Verifica el contenido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
