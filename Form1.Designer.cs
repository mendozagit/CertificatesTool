namespace CertificatesTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FilesGrid = new DataGridView();
            Column7 = new DataGridViewCheckBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            RFC = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            SaveFileButton = new Button();
            FileExtensionTextBox = new TextBox();
            Base64FileTextBox = new TextBox();
            EncodePkPassButton = new Button();
            SaveButton = new Button();
            label3 = new Label();
            InitialPathTextBox = new TextBox();
            label2 = new Label();
            EncodedPkPassTextBox = new TextBox();
            label1 = new Label();
            PassTextBox = new TextBox();
            ClearButton = new Button();
            RemoveButton = new Button();
            AddFileButton = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)FilesGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // FilesGrid
            // 
            FilesGrid.AllowUserToAddRows = false;
            FilesGrid.AllowUserToDeleteRows = false;
            FilesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FilesGrid.Columns.AddRange(new DataGridViewColumn[] { Column7, Column2, Column3, Column4, Column5, RFC, Column6, Column1 });
            FilesGrid.Dock = DockStyle.Fill;
            FilesGrid.Location = new Point(0, 0);
            FilesGrid.Name = "FilesGrid";
            FilesGrid.Size = new Size(1204, 330);
            FilesGrid.TabIndex = 3;
            // 
            // Column7
            // 
            Column7.HeaderText = "Select";
            Column7.Name = "Column7";
            Column7.Resizable = DataGridViewTriState.True;
            Column7.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            Column2.HeaderText = "FileType";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Password";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "ValidFrom";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "ValidTo";
            Column5.Name = "Column5";
            // 
            // RFC
            // 
            RFC.HeaderText = "RFC";
            RFC.Name = "RFC";
            // 
            // Column6
            // 
            Column6.HeaderText = "RAZON SOCIAL";
            Column6.Name = "Column6";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Base64File";
            Column1.Name = "Column1";
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(SaveFileButton);
            panel1.Controls.Add(FileExtensionTextBox);
            panel1.Controls.Add(Base64FileTextBox);
            panel1.Controls.Add(EncodePkPassButton);
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(InitialPathTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(EncodedPkPassTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PassTextBox);
            panel1.Controls.Add(ClearButton);
            panel1.Controls.Add(RemoveButton);
            panel1.Controls.Add(AddFileButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 330);
            panel1.Name = "panel1";
            panel1.Size = new Size(1204, 155);
            panel1.TabIndex = 4;
            // 
            // SaveFileButton
            // 
            SaveFileButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveFileButton.Location = new Point(860, 95);
            SaveFileButton.Name = "SaveFileButton";
            SaveFileButton.Size = new Size(89, 52);
            SaveFileButton.TabIndex = 16;
            SaveFileButton.Text = "Save File";
            SaveFileButton.UseVisualStyleBackColor = true;
            SaveFileButton.Click += SaveFileButton_Click;
            // 
            // FileExtensionTextBox
            // 
            FileExtensionTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FileExtensionTextBox.Location = new Point(691, 124);
            FileExtensionTextBox.Name = "FileExtensionTextBox";
            FileExtensionTextBox.Size = new Size(163, 23);
            FileExtensionTextBox.TabIndex = 15;
            // 
            // Base64FileTextBox
            // 
            Base64FileTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Base64FileTextBox.Location = new Point(691, 95);
            Base64FileTextBox.Name = "Base64FileTextBox";
            Base64FileTextBox.Size = new Size(163, 23);
            Base64FileTextBox.TabIndex = 14;
            // 
            // EncodePkPassButton
            // 
            EncodePkPassButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EncodePkPassButton.Location = new Point(546, 13);
            EncodePkPassButton.Name = "EncodePkPassButton";
            EncodePkPassButton.Size = new Size(139, 48);
            EncodePkPassButton.TabIndex = 13;
            EncodePkPassButton.Text = "Encode PK Pass";
            EncodePkPassButton.UseVisualStyleBackColor = true;
            EncodePkPassButton.Click += EncodePkPassButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.Location = new Point(1029, 92);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(163, 51);
            SaveButton.TabIndex = 12;
            SaveButton.Text = "Sign and verify demo data";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 95);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 11;
            label3.Text = "InitialDirectory";
            // 
            // InitialPathTextBox
            // 
            InitialPathTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            InitialPathTextBox.Location = new Point(3, 120);
            InitialPathTextBox.Name = "InitialPathTextBox";
            InitialPathTextBox.Size = new Size(512, 23);
            InitialPathTextBox.TabIndex = 10;
            InitialPathTextBox.Text = "G:\\Mi unidad\\Facturacion\\RFC-PAC-SC(SellosPrueba)\\Personas Fisicas";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(6, 13);
            label2.Name = "label2";
            label2.Size = new Size(166, 15);
            label2.TabIndex = 9;
            label2.Text = "Encoded Private key Password";
            // 
            // EncodedPkPassTextBox
            // 
            EncodedPkPassTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EncodedPkPassTextBox.Location = new Point(6, 38);
            EncodedPkPassTextBox.Name = "EncodedPkPassTextBox";
            EncodedPkPassTextBox.Size = new Size(360, 23);
            EncodedPkPassTextBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(372, 13);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 7;
            label1.Text = "Plain Private Key Pass";
            // 
            // PassTextBox
            // 
            PassTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PassTextBox.Location = new Point(372, 38);
            PassTextBox.Name = "PassTextBox";
            PassTextBox.Size = new Size(154, 23);
            PassTextBox.TabIndex = 6;
            PassTextBox.Text = "12345678a";
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearButton.Location = new Point(1029, 13);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(163, 48);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "Clear All";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveButton.Location = new Point(860, 13);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(163, 48);
            RemoveButton.TabIndex = 4;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddFileButton
            // 
            AddFileButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddFileButton.Location = new Point(691, 13);
            AddFileButton.Name = "AddFileButton";
            AddFileButton.Size = new Size(163, 48);
            AddFileButton.TabIndex = 3;
            AddFileButton.Text = "AddFile";
            AddFileButton.UseVisualStyleBackColor = true;
            AddFileButton.Click += AddFileButton_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(612, 103);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 17;
            label4.Text = "BASE64 FILE:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(586, 127);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 18;
            label5.Text = "FILE EXTENSION :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 485);
            Controls.Add(FilesGrid);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)FilesGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private DataGridView FilesGrid;
        private Panel panel1;
        private Button ClearButton;
        private Button RemoveButton;
        private Button AddFileButton;
        private Label label1;
        private TextBox PassTextBox;
        private Label label2;
        private TextBox EncodedPkPassTextBox;
        private Label label3;
        private TextBox InitialPathTextBox;
        private Button SaveButton;
        private DataGridViewCheckBoxColumn Column7;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn RFC;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private Button EncodePkPassButton;
        private Button SaveFileButton;
        private TextBox FileExtensionTextBox;
        private TextBox Base64FileTextBox;
        private Label label5;
        private Label label4;
    }
}