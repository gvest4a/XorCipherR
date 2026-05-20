namespace XorCipherR
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
            components = new System.ComponentModel.Container();
            
            // Main TabControl
            tabControl = new TabControl();
            tabEncrypt = new TabPage();
            tabDecrypt = new TabPage();
            
            // Encrypt Tab Controls
            lblEncryptInput = new Label();
            txtEncryptInput = new TextBox();
            btnEncryptLoadFile = new Button();
            lblEncryptKey = new Label();
            txtEncryptKey = new TextBox();
            btnEncrypt = new Button();
            lblEncryptOutput = new Label();
            txtEncryptOutput = new TextBox();
            btnEncryptSave = new Button();
            btnEncryptClear = new Button();
            
            // Decrypt Tab Controls
            lblDecryptInput = new Label();
            txtDecryptInput = new TextBox();
            btnDecryptLoadFile = new Button();
            lblDecryptKey = new Label();
            txtDecryptKey = new TextBox();
            btnDecrypt = new Button();
            lblDecryptOutput = new Label();
            txtDecryptOutput = new TextBox();
            btnDecryptSave = new Button();
            btnDecryptClear = new Button();
            
            // OpenFile Dialogs
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            
            // Tab Control Setup
            tabControl.SuspendLayout();
            tabEncrypt.SuspendLayout();
            tabDecrypt.SuspendLayout();
            SuspendLayout();
            
            // tabControl
            tabControl.Controls.Add(tabEncrypt);
            tabControl.Controls.Add(tabDecrypt);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(10, 10);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(980, 580);
            tabControl.TabIndex = 0;
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            
            // tabEncrypt
            tabEncrypt.BackColor = Color.FromArgb(245, 245, 245);
            tabEncrypt.Controls.Add(lblEncryptInput);
            tabEncrypt.Controls.Add(txtEncryptInput);
            tabEncrypt.Controls.Add(btnEncryptLoadFile);
            tabEncrypt.Controls.Add(lblEncryptKey);
            tabEncrypt.Controls.Add(txtEncryptKey);
            tabEncrypt.Controls.Add(btnEncrypt);
            tabEncrypt.Controls.Add(lblEncryptOutput);
            tabEncrypt.Controls.Add(txtEncryptOutput);
            tabEncrypt.Controls.Add(btnEncryptSave);
            tabEncrypt.Controls.Add(btnEncryptClear);
            tabEncrypt.Location = new Point(4, 29);
            tabEncrypt.Name = "tabEncrypt";
            tabEncrypt.Padding = new Padding(15);
            tabEncrypt.Size = new Size(972, 547);
            tabEncrypt.TabIndex = 0;
            tabEncrypt.Text = "Encrypt";
            
            // tabDecrypt
            tabDecrypt.BackColor = Color.FromArgb(245, 245, 245);
            tabDecrypt.Controls.Add(lblDecryptInput);
            tabDecrypt.Controls.Add(txtDecryptInput);
            tabDecrypt.Controls.Add(btnDecryptLoadFile);
            tabDecrypt.Controls.Add(lblDecryptKey);
            tabDecrypt.Controls.Add(txtDecryptKey);
            tabDecrypt.Controls.Add(btnDecrypt);
            tabDecrypt.Controls.Add(lblDecryptOutput);
            tabDecrypt.Controls.Add(txtDecryptOutput);
            tabDecrypt.Controls.Add(btnDecryptSave);
            tabDecrypt.Controls.Add(btnDecryptClear);
            tabDecrypt.Location = new Point(4, 29);
            tabDecrypt.Name = "tabDecrypt";
            tabDecrypt.Padding = new Padding(15);
            tabDecrypt.Size = new Size(972, 547);
            tabDecrypt.TabIndex = 1;
            tabDecrypt.Text = "Decrypt";
            
            // lblEncryptInput
            lblEncryptInput.AutoSize = true;
            lblEncryptInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEncryptInput.ForeColor = Color.FromArgb(60, 60, 60);
            lblEncryptInput.Location = new Point(15, 15);
            lblEncryptInput.Name = "lblEncryptInput";
            lblEncryptInput.Size = new Size(100, 25);
            lblEncryptInput.Text = "Input Text:";
            
            // txtEncryptInput
            txtEncryptInput.Location = new Point(15, 45);
            txtEncryptInput.Multiline = true;
            txtEncryptInput.ScrollBars = ScrollBars.Vertical;
            txtEncryptInput.Font = new Font("Consolas", 10F);
            txtEncryptInput.BackColor = Color.White;
            txtEncryptInput.BorderStyle = BorderStyle.FixedSingle;
            txtEncryptInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtEncryptInput.Size = new Size(450, 350);
            txtEncryptInput.TabIndex = 1;
            
            // btnEncryptLoadFile
            btnEncryptLoadFile.FlatStyle = FlatStyle.Flat;
            btnEncryptLoadFile.BackColor = Color.FromArgb(100, 100, 100);
            btnEncryptLoadFile.ForeColor = Color.White;
            btnEncryptLoadFile.FlatAppearance.BorderSize = 0;
            btnEncryptLoadFile.Font = new Font("Segoe UI", 9F);
            btnEncryptLoadFile.Location = new Point(15, 400);
            btnEncryptLoadFile.Name = "btnEncryptLoadFile";
            btnEncryptLoadFile.Size = new Size(140, 35);
            btnEncryptLoadFile.TabIndex = 2;
            btnEncryptLoadFile.Text = "Load from File";
            btnEncryptLoadFile.UseVisualStyleBackColor = false;
            btnEncryptLoadFile.Click += BtnEncryptLoadFile_Click;
            
            // lblEncryptKey
            lblEncryptKey.AutoSize = true;
            lblEncryptKey.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEncryptKey.ForeColor = Color.FromArgb(60, 60, 60);
            lblEncryptKey.Location = new Point(480, 15);
            lblEncryptKey.Name = "lblEncryptKey";
            lblEncryptKey.Size = new Size(80, 25);
            lblEncryptKey.Text = "Key:";
            
            // txtEncryptKey
            txtEncryptKey.Location = new Point(480, 45);
            txtEncryptKey.Font = new Font("Consolas", 10F);
            txtEncryptKey.BackColor = Color.White;
            txtEncryptKey.BorderStyle = BorderStyle.FixedSingle;
            txtEncryptKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEncryptKey.Size = new Size(460, 30);
            txtEncryptKey.TabIndex = 3;
            txtEncryptKey.PlaceholderText = "Enter encryption key";
            
            // btnEncrypt
            btnEncrypt.FlatStyle = FlatStyle.Flat;
            btnEncrypt.BackColor = Color.FromArgb(80, 80, 80);
            btnEncrypt.ForeColor = Color.White;
            btnEncrypt.FlatAppearance.BorderSize = 0;
            btnEncrypt.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEncrypt.Location = new Point(480, 90);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(460, 45);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "ENCRYPT";
            btnEncrypt.UseVisualStyleBackColor = false;
            btnEncrypt.Click += BtnEncrypt_Click;
            
            // lblEncryptOutput
            lblEncryptOutput.AutoSize = true;
            lblEncryptOutput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEncryptOutput.ForeColor = Color.FromArgb(60, 60, 60);
            lblEncryptOutput.Location = new Point(480, 150);
            lblEncryptOutput.Name = "lblEncryptOutput";
            lblEncryptOutput.Size = new Size(130, 25);
            lblEncryptOutput.Text = "Encrypted Result:";
            
            // txtEncryptOutput
            txtEncryptOutput.Location = new Point(480, 180);
            txtEncryptOutput.Multiline = true;
            txtEncryptOutput.ScrollBars = ScrollBars.Vertical;
            txtEncryptOutput.Font = new Font("Consolas", 10F);
            txtEncryptOutput.BackColor = Color.FromArgb(250, 250, 250);
            txtEncryptOutput.BorderStyle = BorderStyle.FixedSingle;
            txtEncryptOutput.ReadOnly = true;
            txtEncryptOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtEncryptOutput.Size = new Size(460, 215);
            txtEncryptOutput.TabIndex = 5;
            
            // btnEncryptSave
            btnEncryptSave.FlatStyle = FlatStyle.Flat;
            btnEncryptSave.BackColor = Color.FromArgb(100, 100, 100);
            btnEncryptSave.ForeColor = Color.White;
            btnEncryptSave.FlatAppearance.BorderSize = 0;
            btnEncryptSave.Font = new Font("Segoe UI", 9F);
            btnEncryptSave.Location = new Point(480, 400);
            btnEncryptSave.Name = "btnEncryptSave";
            btnEncryptSave.Size = new Size(140, 35);
            btnEncryptSave.TabIndex = 6;
            btnEncryptSave.Text = "Save to File";
            btnEncryptSave.UseVisualStyleBackColor = false;
            btnEncryptSave.Click += BtnEncryptSave_Click;
            
            // btnEncryptClear
            btnEncryptClear.FlatStyle = FlatStyle.Flat;
            btnEncryptClear.BackColor = Color.FromArgb(150, 150, 150);
            btnEncryptClear.ForeColor = Color.White;
            btnEncryptClear.FlatAppearance.BorderSize = 0;
            btnEncryptClear.Font = new Font("Segoe UI", 9F);
            btnEncryptClear.Location = new Point(640, 400);
            btnEncryptClear.Name = "btnEncryptClear";
            btnEncryptClear.Size = new Size(140, 35);
            btnEncryptClear.TabIndex = 7;
            btnEncryptClear.Text = "Clear All";
            btnEncryptClear.UseVisualStyleBackColor = false;
            btnEncryptClear.Click += BtnEncryptClear_Click;
            
            // lblDecryptInput
            lblDecryptInput.AutoSize = true;
            lblDecryptInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDecryptInput.ForeColor = Color.FromArgb(60, 60, 60);
            lblDecryptInput.Location = new Point(15, 15);
            lblDecryptInput.Name = "lblDecryptInput";
            lblDecryptInput.Size = new Size(150, 25);
            lblDecryptInput.Text = "Encrypted Text:";
            
            // txtDecryptInput
            txtDecryptInput.Location = new Point(15, 45);
            txtDecryptInput.Multiline = true;
            txtDecryptInput.ScrollBars = ScrollBars.Vertical;
            txtDecryptInput.Font = new Font("Consolas", 10F);
            txtDecryptInput.BackColor = Color.White;
            txtDecryptInput.BorderStyle = BorderStyle.FixedSingle;
            txtDecryptInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtDecryptInput.Size = new Size(450, 350);
            txtDecryptInput.TabIndex = 1;
            
            // btnDecryptLoadFile
            btnDecryptLoadFile.FlatStyle = FlatStyle.Flat;
            btnDecryptLoadFile.BackColor = Color.FromArgb(100, 100, 100);
            btnDecryptLoadFile.ForeColor = Color.White;
            btnDecryptLoadFile.FlatAppearance.BorderSize = 0;
            btnDecryptLoadFile.Font = new Font("Segoe UI", 9F);
            btnDecryptLoadFile.Location = new Point(15, 400);
            btnDecryptLoadFile.Name = "btnDecryptLoadFile";
            btnDecryptLoadFile.Size = new Size(140, 35);
            btnDecryptLoadFile.TabIndex = 2;
            btnDecryptLoadFile.Text = "Load from File";
            btnDecryptLoadFile.UseVisualStyleBackColor = false;
            btnDecryptLoadFile.Click += BtnDecryptLoadFile_Click;
            
            // lblDecryptKey
            lblDecryptKey.AutoSize = true;
            lblDecryptKey.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDecryptKey.ForeColor = Color.FromArgb(60, 60, 60);
            lblDecryptKey.Location = new Point(480, 15);
            lblDecryptKey.Name = "lblDecryptKey";
            lblDecryptKey.Size = new Size(80, 25);
            lblDecryptKey.Text = "Key:";
            
            // txtDecryptKey
            txtDecryptKey.Location = new Point(480, 45);
            txtDecryptKey.Font = new Font("Consolas", 10F);
            txtDecryptKey.BackColor = Color.White;
            txtDecryptKey.BorderStyle = BorderStyle.FixedSingle;
            txtDecryptKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDecryptKey.Size = new Size(460, 30);
            txtDecryptKey.TabIndex = 3;
            txtDecryptKey.PlaceholderText = "Enter decryption key";
            
            // btnDecrypt
            btnDecrypt.FlatStyle = FlatStyle.Flat;
            btnDecrypt.BackColor = Color.FromArgb(80, 80, 80);
            btnDecrypt.ForeColor = Color.White;
            btnDecrypt.FlatAppearance.BorderSize = 0;
            btnDecrypt.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDecrypt.Location = new Point(480, 90);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(460, 45);
            btnDecrypt.TabIndex = 4;
            btnDecrypt.Text = "DECRYPT";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += BtnDecrypt_Click;
            
            // lblDecryptOutput
            lblDecryptOutput.AutoSize = true;
            lblDecryptOutput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDecryptOutput.ForeColor = Color.FromArgb(60, 60, 60);
            lblDecryptOutput.Location = new Point(480, 150);
            lblDecryptOutput.Name = "lblDecryptOutput";
            lblDecryptOutput.Size = new Size(130, 25);
            lblDecryptOutput.Text = "Decrypted Result:";
            
            // txtDecryptOutput
            txtDecryptOutput.Location = new Point(480, 180);
            txtDecryptOutput.Multiline = true;
            txtDecryptOutput.ScrollBars = ScrollBars.Vertical;
            txtDecryptOutput.Font = new Font("Consolas", 10F);
            txtDecryptOutput.BackColor = Color.FromArgb(250, 250, 250);
            txtDecryptOutput.BorderStyle = BorderStyle.FixedSingle;
            txtDecryptOutput.ReadOnly = true;
            txtDecryptOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtDecryptOutput.Size = new Size(460, 215);
            txtDecryptOutput.TabIndex = 5;
            
            // btnDecryptSave
            btnDecryptSave.FlatStyle = FlatStyle.Flat;
            btnDecryptSave.BackColor = Color.FromArgb(100, 100, 100);
            btnDecryptSave.ForeColor = Color.White;
            btnDecryptSave.FlatAppearance.BorderSize = 0;
            btnDecryptSave.Font = new Font("Segoe UI", 9F);
            btnDecryptSave.Location = new Point(480, 400);
            btnDecryptSave.Name = "btnDecryptSave";
            btnDecryptSave.Size = new Size(140, 35);
            btnDecryptSave.TabIndex = 6;
            btnDecryptSave.Text = "Save to File";
            btnDecryptSave.UseVisualStyleBackColor = false;
            btnDecryptSave.Click += BtnDecryptSave_Click;
            
            // btnDecryptClear
            btnDecryptClear.FlatStyle = FlatStyle.Flat;
            btnDecryptClear.BackColor = Color.FromArgb(150, 150, 150);
            btnDecryptClear.ForeColor = Color.White;
            btnDecryptClear.FlatAppearance.BorderSize = 0;
            btnDecryptClear.Font = new Font("Segoe UI", 9F);
            btnDecryptClear.Location = new Point(640, 400);
            btnDecryptClear.Name = "btnDecryptClear";
            btnDecryptClear.Size = new Size(140, 35);
            btnDecryptClear.TabIndex = 7;
            btnDecryptClear.Text = "Clear All";
            btnDecryptClear.UseVisualStyleBackColor = false;
            btnDecryptClear.Click += BtnDecryptClear_Click;
            
            // openFileDialog
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Title = "Select a file to open";
            
            // saveFileDialog
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save result to file";
            
            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 230);
            ClientSize = new Size(1000, 600);
            Controls.Add(tabControl);
            MinimumSize = new Size(800, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XOR Cipher - Encryption & Decryption";
            tabControl.ResumeLayout(false);
            tabEncrypt.ResumeLayout(false);
            tabEncrypt.PerformLayout();
            tabDecrypt.ResumeLayout(false);
            tabDecrypt.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabEncrypt;
        private TabPage tabDecrypt;
        
        // Encrypt Tab Controls
        private Label lblEncryptInput;
        private TextBox txtEncryptInput;
        private Button btnEncryptLoadFile;
        private Label lblEncryptKey;
        private TextBox txtEncryptKey;
        private Button btnEncrypt;
        private Label lblEncryptOutput;
        private TextBox txtEncryptOutput;
        private Button btnEncryptSave;
        private Button btnEncryptClear;
        
        // Decrypt Tab Controls
        private Label lblDecryptInput;
        private TextBox txtDecryptInput;
        private Button btnDecryptLoadFile;
        private Label lblDecryptKey;
        private TextBox txtDecryptKey;
        private Button btnDecrypt;
        private Label lblDecryptOutput;
        private TextBox txtDecryptOutput;
        private Button btnDecryptSave;
        private Button btnDecryptClear;
        
        // Dialogs
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}
