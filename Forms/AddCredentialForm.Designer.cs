namespace CertificatesTool.Forms
{
    partial class AddCredentialForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            CerLabel = new Label();
            CerPathTextBox = new TextBox();
            BrowseCerButton = new Button();
            KeyLabel = new Label();
            KeyPathTextBox = new TextBox();
            BrowseKeyButton = new Button();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            OkButton = new Button();
            CancelActionButton = new Button();
            SuspendLayout();
            //
            // CerLabel
            //
            CerLabel.AutoSize = true;
            CerLabel.Location = new Point(24, 28);
            CerLabel.Name = "CerLabel";
            CerLabel.Size = new Size(200, 32);
            CerLabel.TabIndex = 0;
            CerLabel.Text = "Archivo .cer";
            //
            // CerPathTextBox
            //
            CerPathTextBox.Location = new Point(24, 64);
            CerPathTextBox.Name = "CerPathTextBox";
            CerPathTextBox.ReadOnly = true;
            CerPathTextBox.Size = new Size(740, 39);
            CerPathTextBox.TabIndex = 1;
            //
            // BrowseCerButton
            //
            BrowseCerButton.Location = new Point(780, 60);
            BrowseCerButton.Name = "BrowseCerButton";
            BrowseCerButton.Size = new Size(144, 48);
            BrowseCerButton.TabIndex = 2;
            BrowseCerButton.Text = "Examinar…";
            BrowseCerButton.UseVisualStyleBackColor = true;
            BrowseCerButton.Click += BrowseCerButton_Click;
            //
            // KeyLabel
            //
            KeyLabel.AutoSize = true;
            KeyLabel.Location = new Point(24, 124);
            KeyLabel.Name = "KeyLabel";
            KeyLabel.Size = new Size(200, 32);
            KeyLabel.TabIndex = 3;
            KeyLabel.Text = "Archivo .key";
            //
            // KeyPathTextBox
            //
            KeyPathTextBox.Location = new Point(24, 160);
            KeyPathTextBox.Name = "KeyPathTextBox";
            KeyPathTextBox.ReadOnly = true;
            KeyPathTextBox.Size = new Size(740, 39);
            KeyPathTextBox.TabIndex = 4;
            //
            // BrowseKeyButton
            //
            BrowseKeyButton.Location = new Point(780, 156);
            BrowseKeyButton.Name = "BrowseKeyButton";
            BrowseKeyButton.Size = new Size(144, 48);
            BrowseKeyButton.TabIndex = 5;
            BrowseKeyButton.Text = "Examinar…";
            BrowseKeyButton.UseVisualStyleBackColor = true;
            BrowseKeyButton.Click += BrowseKeyButton_Click;
            //
            // PasswordLabel
            //
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(24, 220);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(260, 32);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Contraseña .key";
            //
            // PasswordTextBox
            //
            PasswordTextBox.Location = new Point(24, 256);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(900, 39);
            PasswordTextBox.TabIndex = 7;
            //
            // OkButton
            //
            OkButton.Location = new Point(548, 332);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(176, 56);
            OkButton.TabIndex = 8;
            OkButton.Text = "Agregar";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            //
            // CancelActionButton
            //
            CancelActionButton.Location = new Point(748, 332);
            CancelActionButton.Name = "CancelActionButton";
            CancelActionButton.Size = new Size(176, 56);
            CancelActionButton.TabIndex = 9;
            CancelActionButton.Text = "Cancelar";
            CancelActionButton.UseVisualStyleBackColor = true;
            CancelActionButton.Click += CancelActionButton_Click;
            //
            // AddCredentialForm
            //
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 420);
            Controls.Add(CancelActionButton);
            Controls.Add(OkButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(BrowseKeyButton);
            Controls.Add(KeyPathTextBox);
            Controls.Add(KeyLabel);
            Controls.Add(BrowseCerButton);
            Controls.Add(CerPathTextBox);
            Controls.Add(CerLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCredentialForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar credencial";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label CerLabel;
        private TextBox CerPathTextBox;
        private Button BrowseCerButton;
        private Label KeyLabel;
        private TextBox KeyPathTextBox;
        private Button BrowseKeyButton;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Button OkButton;
        private Button CancelActionButton;
    }
}
