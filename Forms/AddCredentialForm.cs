using CertificatesTool.Models;
using CertificatesTool.Services;

namespace CertificatesTool.Forms
{
    internal partial class AddCredentialForm : Form
    {
        private readonly CredentialFactory _factory;

        public Credential? Result { get; private set; }

        public AddCredentialForm(CredentialFactory factory)
        {
            _factory = factory;
            InitializeComponent();
        }

        private void BrowseCerButton_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "Certificado (*.cer)|*.cer|Todos los archivos (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (dialog.ShowDialog(this) == DialogResult.OK)
                CerPathTextBox.Text = dialog.FileName;
        }

        private void BrowseKeyButton_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "Llave privada (*.key)|*.key|Todos los archivos (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (dialog.ShowDialog(this) == DialogResult.OK)
                KeyPathTextBox.Text = dialog.FileName;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            var cerPath = CerPathTextBox.Text.Trim();
            var keyPath = KeyPathTextBox.Text.Trim();
            var password = PasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(cerPath) || string.IsNullOrWhiteSpace(keyPath))
            {
                MessageBox.Show(this, "Debes seleccionar el archivo .cer y el archivo .key.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show(this, "La contraseña de la llave privada es obligatoria.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Result = _factory.CreateFromFiles(cerPath, keyPath, password);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "No se pudo crear la credencial",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelActionButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
