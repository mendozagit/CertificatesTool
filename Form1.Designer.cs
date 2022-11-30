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
            this.FilesGrid = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.InitialPathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SetInitialPathButton = new System.Windows.Forms.Button();
            this.AddFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FilesGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilesGrid
            // 
            this.FilesGrid.AllowUserToAddRows = false;
            this.FilesGrid.AllowUserToDeleteRows = false;
            this.FilesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.RFC,
            this.Column6,
            this.Column1});
            this.FilesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesGrid.Location = new System.Drawing.Point(0, 0);
            this.FilesGrid.Name = "FilesGrid";
            this.FilesGrid.RowTemplate.Height = 25;
            this.FilesGrid.Size = new System.Drawing.Size(1210, 365);
            this.FilesGrid.TabIndex = 3;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FileType";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Password";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ValidFrom";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ValidTo";
            this.Column5.Name = "Column5";
            // 
            // RFC
            // 
            this.RFC.HeaderText = "RFC";
            this.RFC.Name = "RFC";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "RAZON SOCIAL";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Base64File";
            this.Column1.Name = "Column1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoadButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.InitialPathTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PassTextBox);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.RemoveButton);
            this.panel1.Controls.Add(this.SetInitialPathButton);
            this.panel1.Controls.Add(this.AddFileButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 155);
            this.panel1.TabIndex = 4;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(866, 85);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(163, 43);
            this.LoadButton.TabIndex = 13;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(697, 85);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(163, 43);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "InitialDirectory";
            // 
            // InitialPathTextBox
            // 
            this.InitialPathTextBox.Location = new System.Drawing.Point(12, 102);
            this.InitialPathTextBox.Name = "InitialPathTextBox";
            this.InitialPathTextBox.Size = new System.Drawing.Size(519, 23);
            this.InitialPathTextBox.TabIndex = 10;
            this.InitialPathTextBox.Text = "G:\\Mi unidad\\Facturacion\\RFC-PAC-SC(SellosPrueba)\\Personas Fisicas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Base64File";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(519, 23);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "PrivateKey Pass";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(537, 38);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(154, 23);
            this.PassTextBox.TabIndex = 6;
            this.PassTextBox.Text = "12345678a";
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Location = new System.Drawing.Point(1035, 13);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(163, 48);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear All";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(866, 13);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(163, 48);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // SetInitialPathButton
            // 
            this.SetInitialPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetInitialPathButton.Location = new System.Drawing.Point(537, 100);
            this.SetInitialPathButton.Name = "SetInitialPathButton";
            this.SetInitialPathButton.Size = new System.Drawing.Size(154, 28);
            this.SetInitialPathButton.TabIndex = 3;
            this.SetInitialPathButton.Text = "Set Initial Path";
            this.SetInitialPathButton.UseVisualStyleBackColor = true;
            this.SetInitialPathButton.Click += new System.EventHandler(this.SetInitialPathButton_Click);
            // 
            // AddFileButton
            // 
            this.AddFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFileButton.Location = new System.Drawing.Point(697, 13);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(163, 48);
            this.AddFileButton.TabIndex = 3;
            this.AddFileButton.Text = "AddFile";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 520);
            this.Controls.Add(this.FilesGrid);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.FilesGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private TextBox textBox1;
        private Label label3;
        private TextBox InitialPathTextBox;
        private Button SetInitialPathButton;
        private Button LoadButton;
        private Button SaveButton;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn RFC;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
    }
}