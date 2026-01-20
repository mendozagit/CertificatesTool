
using System.Text;
using System.Text.Json;

using CertificatesTool.Models;

using Fiscalapi.Credentials.Core;

namespace CertificatesTool
{
    /// <summary>
    /// sample form
    /// </summary>
    public partial class Form1 : Form
    {
        
        private List<SatFile> _satFiles = new List<SatFile>();
        private const string FileName = "files.json";
        private string _password;


        public Form1()
        {
            InitializeComponent();

            ReadFiles();
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            _password = PassTextBox.Text.Trim();
            var path = GetFilePath();
            var base64 = GetBase64(path);
            var file = GetFileFromBase64(base64);
            _satFiles?.Add(file);

            RefreshGrid();
        }
        /// <summary>
        /// 0=CertificateCsd,
        /// 1=PrivateKeyCsd,
        /// 2=CertificateFiel,
        /// 3=PrivateKeyFiel,
        /// 4=Pfx,
        /// </summary>
        /// <param name="base64"></param>
        /// <returns></returns>
        private SatFile GetFileFromBase64(string base64)
        {
            
            SatFile satFile = null;
            var id = _satFiles.Count == 0 ? 1 : _satFiles.Count;
            try
            {
                var certificate = new Certificate(base64);
                satFile = new SatFile
                {
                    Base64File = certificate.PlainBase64,
                    FileType = FileType.CertificateCsd,
                    Password = null,
                    ValidFrom = certificate.ValidFrom,
                    ValidTo = certificate.ValidTo,
                    Rfc = certificate.Rfc,
                    RazonSocial = certificate.Organization
                };
                return satFile;
            }
            catch (Exception e)
            {
                try
                {
                    var privateKey = new PrivateKey(base64, _password);

                    satFile = new SatFile
                    {
                        Base64File = privateKey.Base64,
                        FileType = FileType.PrivateKeyCsd,
                        Password = _password
                    };
                    return satFile;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            return satFile ?? new SatFile();
        }

        private void ReadFiles()
        {
            if (File.Exists(FileName))
            {
                var json = File.ReadAllText(FileName);
                _satFiles = JsonSerializer.Deserialize<List<SatFile>>(json) ?? new List<SatFile>();
                RefreshGrid();
            }
        }

        private void WriteFiles()
        {
            if (_satFiles is null) return;

            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(FileName, JsonSerializer.Serialize(_satFiles, options));
        }


        private void RefreshGrid()
        {
            FilesGrid.Rows.Clear();

            foreach (var satFile in _satFiles)
            {
                FilesGrid.Rows.Add();
                FilesGrid.Rows[^1].Cells[0].Value = false;
                FilesGrid.Rows[^1].Cells[1].Value = satFile.FileType;
                FilesGrid.Rows[^1].Cells[2].Value = satFile.Password;
                FilesGrid.Rows[^1].Cells[3].Value = satFile.ValidFrom;
                FilesGrid.Rows[^1].Cells[4].Value = satFile.ValidTo;
                FilesGrid.Rows[^1].Cells[5].Value = satFile.Rfc;
                FilesGrid.Rows[^1].Cells[6].Value = satFile.RazonSocial;
                FilesGrid.Rows[^1].Cells[7].Value = satFile.Base64File;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteFiles();
        }


        private string GetBase64(string filePath)
        {
            var fileBytes = File.ReadAllBytes(filePath);
            var fileBase64 = Convert.ToBase64String(fileBytes);
            return fileBase64;
        }

        private string GetFilePath()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = InitialPathTextBox.Text.Trim();
            openFileDialog.Filter = @"txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
            }

            return filePath;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _satFiles.Clear();
            RefreshGrid();
        }

        private void SetInitialPathButton_Click(object sender, EventArgs e)
        {
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //demos
            try
            {
                _password = PassTextBox.Text.Trim();
                int cerIndex = GetSelectedCertificateIndex();
                int keyIndex = GetSelectedPrivateKeyIndex();


                var cerBase64 = FilesGrid.Rows[cerIndex].Cells[7].Value.ToString();
                var keyBase64 = FilesGrid.Rows[keyIndex].Cells[7].Value.ToString();
                var keyPass = FilesGrid.Rows[keyIndex].Cells[2].Value.ToString();

                var certificate = new Certificate(cerBase64);
                var privateKey = new PrivateKey(keyBase64, keyPass);


                //Create a credential instance, certificate and privatekey previously created.
                var fiel = new Credential(certificate, privateKey);

                var dataToSign = "Hello world"; //replace with cadena original

                //SignData
                var signedBytes = fiel.SignData(dataToSign);

                //Verify signature
                var originalDataBytes = Encoding.UTF8.GetBytes(dataToSign);
                var isValid = fiel.VerifyData(originalDataBytes, signedBytes);

                MessageBox.Show(@"isValid " + isValid);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private int GetSelectedCertificateIndex()
        {
            var index = 0;
            foreach (DataGridViewRow row in FilesGrid.Rows)
            {
                var selectedValue = (bool)row.Cells[0].Value;
                var fileTypeValue = (FileType)row.Cells[1].Value;

                if (selectedValue == true && fileTypeValue == FileType.CertificateCsd)
                {
                    return index;
                }

                index++;
            }

            return index;
        }

        private int GetSelectedPrivateKeyIndex()
        {
            var index = 0;
            foreach (DataGridViewRow row in FilesGrid.Rows)
            {
                var selectedValue = (bool)row.Cells[0].Value;
                var fileTypeValue = (FileType)row.Cells[1].Value;

                if (selectedValue == true && fileTypeValue == FileType.PrivateKeyCsd)
                {
                    return index;
                }

                index++;
            }

            return index;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedRow();
        }

        private void RemoveSelectedRow()
        {
            
            if (FilesGrid.Rows.Count == 0)
                return;

            var index = FilesGrid.CurrentCell.RowIndex;

            _satFiles.RemoveAt(index);

            RefreshGrid();
        }

        private void EncodePkPassButton_Click(object sender, EventArgs e)
        {
            EncodeSelectedPkPass();
        }

        private void EncodeSelectedPkPass()
        {
            _password = PassTextBox.Text.Trim();
            if (FilesGrid.Rows.Count == 0)
                return;

            var index = FilesGrid.CurrentCell.RowIndex;
            var plainPass = FilesGrid.Rows[index].Cells[2]?.Value?.ToString() ?? "";
            EncodedPkPassTextBox.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(plainPass));
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                var base64Content = Base64FileTextBox.Text.Trim();
                var extension = FileExtensionTextBox.Text.Trim();

                if (string.IsNullOrEmpty(base64Content))
                {
                    MessageBox.Show("Please enter a Base64 string.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(extension))
                {
                    MessageBox.Show("Please enter a file extension.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure extension starts with a dot
                if (!extension.StartsWith("."))
                {
                    extension = "." + extension;
                }

                // Generate filename from extension (e.g., .cer -> CER.cer, .key -> KEY.key)
                var extensionName = extension.TrimStart('.').ToUpperInvariant();
                var fileName = $"{extensionName}{extension.ToLowerInvariant()}";

                // Save directly to Desktop
                var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var fullPath = Path.Combine(desktopPath, fileName);

                // Decode base64 and save as binary file
                var fileBytes = Convert.FromBase64String(base64Content);
                File.WriteAllBytes(fullPath, fileBytes);

                MessageBox.Show($"File saved successfully:\n{fullPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Base64 string. Please check the content.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}