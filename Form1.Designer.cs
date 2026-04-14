namespace CertificatesTool
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            FilesGrid = new DataGridView();
            AddCredentialButton = new Button();
            RemoveButton = new Button();
            ClearButton = new Button();
            ExportCerButton = new Button();
            ExportKeyButton = new Button();
            SavePairButton = new Button();
            EncodePkPassButton = new Button();
            SignAndVerifyButton = new Button();
            EncodedPkPassLabel = new Label();
            EncodedPkPassTextBox = new TextBox();
            Base64FileLabel = new Label();
            Base64FileTextBox = new TextBox();
            FileExtensionLabel = new Label();
            FileExtensionTextBox = new TextBox();
            SaveFileButton = new Button();
            Credentials = new GroupBox();
            CopyPlainPassPhraseButton = new Button();
            CopyBase64KeyButton = new Button();
            CopyBase64CerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)FilesGrid).BeginInit();
            Credentials.SuspendLayout();
            SuspendLayout();
            // 
            // FilesGrid
            // 
            FilesGrid.AllowUserToAddRows = false;
            FilesGrid.AllowUserToDeleteRows = false;
            FilesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FilesGrid.Dock = DockStyle.Fill;
            FilesGrid.Location = new Point(0, 0);
            FilesGrid.Margin = new Padding(6);
            FilesGrid.MultiSelect = false;
            FilesGrid.Name = "FilesGrid";
            FilesGrid.ReadOnly = true;
            FilesGrid.RowHeadersWidth = 82;
            FilesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FilesGrid.Size = new Size(1756, 912);
            FilesGrid.TabIndex = 0;
            // 
            // AddCredentialButton
            // 
            AddCredentialButton.Location = new Point(9, 41);
            AddCredentialButton.Margin = new Padding(6);
            AddCredentialButton.Name = "AddCredentialButton";
            AddCredentialButton.Size = new Size(258, 70);
            AddCredentialButton.TabIndex = 0;
            AddCredentialButton.Text = "Agregar Credencial";
            AddCredentialButton.UseVisualStyleBackColor = true;
            AddCredentialButton.Click += AddCredentialButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(279, 41);
            RemoveButton.Margin = new Padding(6);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(258, 70);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Eliminar Credencial";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(549, 41);
            ClearButton.Margin = new Padding(6);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(258, 70);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Eliminar Todo";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExportCerButton
            // 
            ExportCerButton.Location = new Point(9, 123);
            ExportCerButton.Margin = new Padding(6);
            ExportCerButton.Name = "ExportCerButton";
            ExportCerButton.Size = new Size(258, 70);
            ExportCerButton.TabIndex = 3;
            ExportCerButton.Text = "Exportar .cer";
            ExportCerButton.UseVisualStyleBackColor = true;
            ExportCerButton.Click += ExportCerButton_Click;
            // 
            // ExportKeyButton
            // 
            ExportKeyButton.Location = new Point(279, 123);
            ExportKeyButton.Margin = new Padding(6);
            ExportKeyButton.Name = "ExportKeyButton";
            ExportKeyButton.Size = new Size(258, 70);
            ExportKeyButton.TabIndex = 4;
            ExportKeyButton.Text = "Exportar .key";
            ExportKeyButton.UseVisualStyleBackColor = true;
            ExportKeyButton.Click += ExportKeyButton_Click;
            // 
            // SavePairButton
            // 
            SavePairButton.Location = new Point(549, 123);
            SavePairButton.Margin = new Padding(6);
            SavePairButton.Name = "SavePairButton";
            SavePairButton.Size = new Size(258, 70);
            SavePairButton.TabIndex = 5;
            SavePairButton.Text = "Exportar Credencial";
            SavePairButton.UseVisualStyleBackColor = true;
            SavePairButton.Click += SavePairButton_Click;
            // 
            // EncodePkPassButton
            // 
            EncodePkPassButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EncodePkPassButton.Location = new Point(998, 34);
            EncodePkPassButton.Margin = new Padding(6);
            EncodePkPassButton.Name = "EncodePkPassButton";
            EncodePkPassButton.Size = new Size(310, 79);
            EncodePkPassButton.TabIndex = 6;
            EncodePkPassButton.Text = "Codificar pass (base64)";
            EncodePkPassButton.UseVisualStyleBackColor = true;
            EncodePkPassButton.Click += EncodePkPassButton_Click;
            // 
            // SignAndVerifyButton
            // 
            SignAndVerifyButton.Location = new Point(998, 229);
            SignAndVerifyButton.Margin = new Padding(6);
            SignAndVerifyButton.Name = "SignAndVerifyButton";
            SignAndVerifyButton.Size = new Size(749, 52);
            SignAndVerifyButton.TabIndex = 7;
            SignAndVerifyButton.Text = "Firmar y verificar";
            SignAndVerifyButton.UseVisualStyleBackColor = true;
            SignAndVerifyButton.Click += SignAndVerifyButton_Click;
            // 
            // EncodedPkPassLabel
            // 
            EncodedPkPassLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EncodedPkPassLabel.AutoSize = true;
            EncodedPkPassLabel.Location = new Point(1318, 28);
            EncodedPkPassLabel.Margin = new Padding(6, 0, 6, 0);
            EncodedPkPassLabel.Name = "EncodedPkPassLabel";
            EncodedPkPassLabel.Size = new Size(345, 32);
            EncodedPkPassLabel.TabIndex = 8;
            EncodedPkPassLabel.Text = "Contraseña codificada (base64)";
            // 
            // EncodedPkPassTextBox
            // 
            EncodedPkPassTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EncodedPkPassTextBox.Location = new Point(1318, 72);
            EncodedPkPassTextBox.Margin = new Padding(6);
            EncodedPkPassTextBox.Name = "EncodedPkPassTextBox";
            EncodedPkPassTextBox.ReadOnly = true;
            EncodedPkPassTextBox.Size = new Size(429, 39);
            EncodedPkPassTextBox.TabIndex = 9;
            // 
            // Base64FileLabel
            // 
            Base64FileLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Base64FileLabel.AutoSize = true;
            Base64FileLabel.Location = new Point(998, 138);
            Base64FileLabel.Margin = new Padding(6, 0, 6, 0);
            Base64FileLabel.Name = "Base64FileLabel";
            Base64FileLabel.Size = new Size(176, 32);
            Base64FileLabel.TabIndex = 10;
            Base64FileLabel.Text = "Archivo base64";
            // 
            // Base64FileTextBox
            // 
            Base64FileTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Base64FileTextBox.Location = new Point(998, 178);
            Base64FileTextBox.Margin = new Padding(6);
            Base64FileTextBox.Name = "Base64FileTextBox";
            Base64FileTextBox.Size = new Size(310, 39);
            Base64FileTextBox.TabIndex = 11;
            // 
            // FileExtensionLabel
            // 
            FileExtensionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FileExtensionLabel.AutoSize = true;
            FileExtensionLabel.Location = new Point(1318, 140);
            FileExtensionLabel.Margin = new Padding(6, 0, 6, 0);
            FileExtensionLabel.Name = "FileExtensionLabel";
            FileExtensionLabel.Size = new Size(116, 32);
            FileExtensionLabel.TabIndex = 12;
            FileExtensionLabel.Text = "Extensión";
            // 
            // FileExtensionTextBox
            // 
            FileExtensionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FileExtensionTextBox.Location = new Point(1320, 178);
            FileExtensionTextBox.Margin = new Padding(6);
            FileExtensionTextBox.Name = "FileExtensionTextBox";
            FileExtensionTextBox.Size = new Size(298, 39);
            FileExtensionTextBox.TabIndex = 13;
            // 
            // SaveFileButton
            // 
            SaveFileButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SaveFileButton.Location = new Point(1630, 161);
            SaveFileButton.Margin = new Padding(6);
            SaveFileButton.Name = "SaveFileButton";
            SaveFileButton.Size = new Size(117, 56);
            SaveFileButton.TabIndex = 14;
            SaveFileButton.Text = "Guardar";
            SaveFileButton.UseVisualStyleBackColor = true;
            SaveFileButton.Click += SaveFileButton_Click;
            // 
            // Credentials
            // 
            Credentials.Controls.Add(CopyPlainPassPhraseButton);
            Credentials.Controls.Add(CopyBase64KeyButton);
            Credentials.Controls.Add(CopyBase64CerButton);
            Credentials.Controls.Add(Base64FileLabel);
            Credentials.Controls.Add(EncodedPkPassLabel);
            Credentials.Controls.Add(Base64FileTextBox);
            Credentials.Controls.Add(FileExtensionLabel);
            Credentials.Controls.Add(EncodePkPassButton);
            Credentials.Controls.Add(FileExtensionTextBox);
            Credentials.Controls.Add(EncodedPkPassTextBox);
            Credentials.Controls.Add(SaveFileButton);
            Credentials.Controls.Add(AddCredentialButton);
            Credentials.Controls.Add(SignAndVerifyButton);
            Credentials.Controls.Add(SavePairButton);
            Credentials.Controls.Add(RemoveButton);
            Credentials.Controls.Add(ExportKeyButton);
            Credentials.Controls.Add(ClearButton);
            Credentials.Controls.Add(ExportCerButton);
            Credentials.Dock = DockStyle.Bottom;
            Credentials.Location = new Point(0, 609);
            Credentials.Name = "Credentials";
            Credentials.Size = new Size(1756, 303);
            Credentials.TabIndex = 15;
            Credentials.TabStop = false;
            Credentials.Text = "Credentials";
      
            // 
            // CopyPlainPassPhraseButton
            // 
            CopyPlainPassPhraseButton.Location = new Point(549, 211);
            CopyPlainPassPhraseButton.Margin = new Padding(6);
            CopyPlainPassPhraseButton.Name = "CopyPlainPassPhraseButton";
            CopyPlainPassPhraseButton.Size = new Size(258, 70);
            CopyPlainPassPhraseButton.TabIndex = 17;
            CopyPlainPassPhraseButton.Text = "Copiar contraseña";
            CopyPlainPassPhraseButton.UseVisualStyleBackColor = true;
            CopyPlainPassPhraseButton.Click += CopyPlainPassPhraseButton_Click;
            // 
            // CopyBase64KeyButton
            // 
            CopyBase64KeyButton.Location = new Point(279, 211);
            CopyBase64KeyButton.Margin = new Padding(6);
            CopyBase64KeyButton.Name = "CopyBase64KeyButton";
            CopyBase64KeyButton.Size = new Size(258, 70);
            CopyBase64KeyButton.TabIndex = 16;
            CopyBase64KeyButton.Text = "Copiar .key (base64)";
            CopyBase64KeyButton.UseVisualStyleBackColor = true;
            CopyBase64KeyButton.Click += CopyBase64KeyButton_Click;
            // 
            // CopyBase64CerButton
            // 
            CopyBase64CerButton.Location = new Point(9, 211);
            CopyBase64CerButton.Margin = new Padding(6);
            CopyBase64CerButton.Name = "CopyBase64CerButton";
            CopyBase64CerButton.Size = new Size(258, 70);
            CopyBase64CerButton.TabIndex = 15;
            CopyBase64CerButton.Text = "Copiar .cer (base64)";
            CopyBase64CerButton.UseVisualStyleBackColor = true;
            CopyBase64CerButton.Click += CopyBase64CerButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1756, 912);
            Controls.Add(Credentials);
            Controls.Add(FilesGrid);
            Margin = new Padding(6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Certificates Tool";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)FilesGrid).EndInit();
            Credentials.ResumeLayout(false);
            Credentials.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView FilesGrid;

        private Button AddCredentialButton;
        private Button RemoveButton;
        private Button ClearButton;

        private Button ExportCerButton;
        private Button ExportKeyButton;
        private Button SavePairButton;

        private Button EncodePkPassButton;
        private Button SignAndVerifyButton;

        private Label EncodedPkPassLabel;
        private TextBox EncodedPkPassTextBox;

        private Label Base64FileLabel;
        private TextBox Base64FileTextBox;
        private Label FileExtensionLabel;
        private TextBox FileExtensionTextBox;
        private Button SaveFileButton;
        private GroupBox Credentials;
        private Button CopyBase64KeyButton;
        private Button CopyBase64CerButton;
        private Button CopyPlainPassPhraseButton;
    }
}
