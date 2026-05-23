namespace XorCipherR
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl = new TabControl();
            tabEncrypt = new TabPage();
            labelTitleEncrypt = new Label();
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
            tabDecrypt = new TabPage();
            labelTitleDecrypt = new Label();
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
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            tabControl.SuspendLayout();
            tabEncrypt.SuspendLayout();
            tabDecrypt.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabEncrypt);
            tabControl.Controls.Add(tabDecrypt);
            tabControl.Location = new Point(10, 10);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(980, 580);
            tabControl.TabIndex = 0;
            // 
            // tabEncrypt
            // 
            tabEncrypt.BackColor = Color.FromArgb(245, 245, 245);
            tabEncrypt.Controls.Add(labelTitleEncrypt);
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
            tabEncrypt.Text = "Шифрование";
            // 
            // labelTitleEncrypt
            // 
            labelTitleEncrypt.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitleEncrypt.ForeColor = Color.FromArgb(60, 60, 60);
            labelTitleEncrypt.Image = (Image)resources.GetObject("labelTitleEncrypt.Image");
            labelTitleEncrypt.ImageAlign = ContentAlignment.MiddleLeft;
            labelTitleEncrypt.Location = new Point(18, 15);
            labelTitleEncrypt.Name = "labelTitleEncrypt";
            labelTitleEncrypt.Size = new Size(254, 42);
            labelTitleEncrypt.TabIndex = 8;
            labelTitleEncrypt.Text = "Шифрование";
            labelTitleEncrypt.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEncryptInput
            // 
            lblEncryptInput.AutoSize = true;
            lblEncryptInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEncryptInput.ForeColor = Color.FromArgb(60, 60, 60);
            lblEncryptInput.Location = new Point(18, 91);
            lblEncryptInput.Name = "lblEncryptInput";
            lblEncryptInput.Size = new Size(109, 23);
            lblEncryptInput.TabIndex = 0;
            lblEncryptInput.Text = "Ввод текста";
            // 
            // txtEncryptInput
            // 
            txtEncryptInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtEncryptInput.BackColor = Color.White;
            txtEncryptInput.BorderStyle = BorderStyle.FixedSingle;
            txtEncryptInput.Font = new Font("Consolas", 10F);
            txtEncryptInput.Location = new Point(18, 121);
            txtEncryptInput.Multiline = true;
            txtEncryptInput.Name = "txtEncryptInput";
            txtEncryptInput.ScrollBars = ScrollBars.Vertical;
            txtEncryptInput.Size = new Size(450, 350);
            txtEncryptInput.TabIndex = 1;
            // 
            // btnEncryptLoadFile
            // 
            btnEncryptLoadFile.AutoSize = true;
            btnEncryptLoadFile.BackColor = Color.FromArgb(100, 100, 100);
            btnEncryptLoadFile.Cursor = Cursors.Hand;
            btnEncryptLoadFile.FlatAppearance.BorderSize = 0;
            btnEncryptLoadFile.FlatStyle = FlatStyle.Flat;
            btnEncryptLoadFile.Font = new Font("Segoe UI", 9F);
            btnEncryptLoadFile.ForeColor = Color.White;
            btnEncryptLoadFile.Image = (Image)resources.GetObject("btnEncryptLoadFile.Image");
            btnEncryptLoadFile.Location = new Point(18, 476);
            btnEncryptLoadFile.Name = "btnEncryptLoadFile";
            btnEncryptLoadFile.Size = new Size(146, 35);
            btnEncryptLoadFile.TabIndex = 2;
            btnEncryptLoadFile.Text = "Загрузить файл";
            btnEncryptLoadFile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEncryptLoadFile.UseVisualStyleBackColor = false;
            btnEncryptLoadFile.Click += BtnEncryptLoadFile_Click;
            // 
            // lblEncryptKey
            // 
            lblEncryptKey.AutoSize = true;
            lblEncryptKey.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEncryptKey.ForeColor = Color.FromArgb(60, 60, 60);
            lblEncryptKey.Location = new Point(483, 91);
            lblEncryptKey.Name = "lblEncryptKey";
            lblEncryptKey.Size = new Size(57, 23);
            lblEncryptKey.TabIndex = 3;
            lblEncryptKey.Text = "Ключ";
            // 
            // txtEncryptKey
            // 
            txtEncryptKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEncryptKey.BackColor = Color.White;
            txtEncryptKey.BorderStyle = BorderStyle.FixedSingle;
            txtEncryptKey.Font = new Font("Consolas", 10F);
            txtEncryptKey.Location = new Point(483, 121);
            txtEncryptKey.Name = "txtEncryptKey";
            txtEncryptKey.PlaceholderText = "Введите ключ";
            txtEncryptKey.Size = new Size(460, 27);
            txtEncryptKey.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            btnEncrypt.BackColor = Color.FromArgb(58, 58, 58);
            btnEncrypt.Cursor = Cursors.Hand;
            btnEncrypt.FlatAppearance.BorderSize = 0;
            btnEncrypt.FlatStyle = FlatStyle.Flat;
            btnEncrypt.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEncrypt.ForeColor = Color.White;
            btnEncrypt.Location = new Point(483, 166);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(460, 45);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "Зашифровать";
            btnEncrypt.UseVisualStyleBackColor = false;
            btnEncrypt.Click += BtnEncrypt_Click;
            // 
            // lblEncryptOutput
            // 
            lblEncryptOutput.AutoSize = true;
            lblEncryptOutput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEncryptOutput.ForeColor = Color.FromArgb(60, 60, 60);
            lblEncryptOutput.Location = new Point(483, 226);
            lblEncryptOutput.Name = "lblEncryptOutput";
            lblEncryptOutput.Size = new Size(88, 23);
            lblEncryptOutput.TabIndex = 5;
            lblEncryptOutput.Text = "Результат";
            // 
            // txtEncryptOutput
            // 
            txtEncryptOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtEncryptOutput.BackColor = Color.FromArgb(250, 250, 250);
            txtEncryptOutput.BorderStyle = BorderStyle.FixedSingle;
            txtEncryptOutput.Font = new Font("Consolas", 10F);
            txtEncryptOutput.Location = new Point(483, 256);
            txtEncryptOutput.Multiline = true;
            txtEncryptOutput.Name = "txtEncryptOutput";
            txtEncryptOutput.ReadOnly = true;
            txtEncryptOutput.ScrollBars = ScrollBars.Vertical;
            txtEncryptOutput.Size = new Size(460, 215);
            txtEncryptOutput.TabIndex = 5;
            // 
            // btnEncryptSave
            // 
            btnEncryptSave.AutoSize = true;
            btnEncryptSave.BackColor = Color.FromArgb(100, 100, 100);
            btnEncryptSave.Cursor = Cursors.Hand;
            btnEncryptSave.FlatAppearance.BorderSize = 0;
            btnEncryptSave.FlatStyle = FlatStyle.Flat;
            btnEncryptSave.Font = new Font("Segoe UI", 9F);
            btnEncryptSave.ForeColor = Color.White;
            btnEncryptSave.Image = (Image)resources.GetObject("btnEncryptSave.Image");
            btnEncryptSave.Location = new Point(483, 476);
            btnEncryptSave.Name = "btnEncryptSave";
            btnEncryptSave.Size = new Size(152, 35);
            btnEncryptSave.TabIndex = 6;
            btnEncryptSave.Text = "Сохранить файл";
            btnEncryptSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEncryptSave.UseVisualStyleBackColor = false;
            btnEncryptSave.Click += BtnEncryptSave_Click;
            // 
            // btnEncryptClear
            // 
            btnEncryptClear.AutoSize = true;
            btnEncryptClear.BackColor = Color.FromArgb(140, 140, 140);
            btnEncryptClear.Cursor = Cursors.Hand;
            btnEncryptClear.FlatAppearance.BorderSize = 0;
            btnEncryptClear.FlatStyle = FlatStyle.Flat;
            btnEncryptClear.Font = new Font("Segoe UI", 9F);
            btnEncryptClear.ForeColor = Color.White;
            btnEncryptClear.Location = new Point(643, 476);
            btnEncryptClear.Name = "btnEncryptClear";
            btnEncryptClear.Size = new Size(140, 35);
            btnEncryptClear.TabIndex = 7;
            btnEncryptClear.Text = "Очистить все";
            btnEncryptClear.UseVisualStyleBackColor = false;
            btnEncryptClear.Click += BtnEncryptClear_Click;
            // 
            // tabDecrypt
            // 
            tabDecrypt.BackColor = Color.FromArgb(245, 245, 245);
            tabDecrypt.Controls.Add(labelTitleDecrypt);
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
            tabDecrypt.Text = "Дешифрование";
            // 
            // labelTitleDecrypt
            // 
            labelTitleDecrypt.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitleDecrypt.ForeColor = Color.FromArgb(60, 60, 60);
            labelTitleDecrypt.Image = (Image)resources.GetObject("labelTitleDecrypt.Image");
            labelTitleDecrypt.ImageAlign = ContentAlignment.MiddleLeft;
            labelTitleDecrypt.Location = new Point(18, 15);
            labelTitleDecrypt.Name = "labelTitleDecrypt";
            labelTitleDecrypt.Size = new Size(292, 42);
            labelTitleDecrypt.TabIndex = 9;
            labelTitleDecrypt.Text = "Дешифрование";
            labelTitleDecrypt.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDecryptInput
            // 
            lblDecryptInput.AutoSize = true;
            lblDecryptInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDecryptInput.ForeColor = Color.FromArgb(60, 60, 60);
            lblDecryptInput.Location = new Point(18, 91);
            lblDecryptInput.Name = "lblDecryptInput";
            lblDecryptInput.Size = new Size(109, 23);
            lblDecryptInput.TabIndex = 0;
            lblDecryptInput.Text = "Ввод текста";
            // 
            // txtDecryptInput
            // 
            txtDecryptInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtDecryptInput.BackColor = Color.White;
            txtDecryptInput.BorderStyle = BorderStyle.FixedSingle;
            txtDecryptInput.Font = new Font("Consolas", 10F);
            txtDecryptInput.Location = new Point(18, 121);
            txtDecryptInput.Multiline = true;
            txtDecryptInput.Name = "txtDecryptInput";
            txtDecryptInput.ScrollBars = ScrollBars.Vertical;
            txtDecryptInput.Size = new Size(450, 350);
            txtDecryptInput.TabIndex = 1;
            // 
            // btnDecryptLoadFile
            // 
            btnDecryptLoadFile.AutoSize = true;
            btnDecryptLoadFile.BackColor = Color.FromArgb(100, 100, 100);
            btnDecryptLoadFile.FlatAppearance.BorderSize = 0;
            btnDecryptLoadFile.FlatStyle = FlatStyle.Flat;
            btnDecryptLoadFile.Font = new Font("Segoe UI", 9F);
            btnDecryptLoadFile.ForeColor = Color.White;
            btnDecryptLoadFile.Image = (Image)resources.GetObject("btnDecryptLoadFile.Image");
            btnDecryptLoadFile.Location = new Point(18, 476);
            btnDecryptLoadFile.Name = "btnDecryptLoadFile";
            btnDecryptLoadFile.Size = new Size(146, 35);
            btnDecryptLoadFile.TabIndex = 2;
            btnDecryptLoadFile.Text = "Загрузить файл";
            btnDecryptLoadFile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDecryptLoadFile.UseVisualStyleBackColor = false;
            btnDecryptLoadFile.Click += BtnDecryptLoadFile_Click;
            // 
            // lblDecryptKey
            // 
            lblDecryptKey.AutoSize = true;
            lblDecryptKey.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDecryptKey.ForeColor = Color.FromArgb(60, 60, 60);
            lblDecryptKey.Location = new Point(483, 91);
            lblDecryptKey.Name = "lblDecryptKey";
            lblDecryptKey.Size = new Size(57, 23);
            lblDecryptKey.TabIndex = 3;
            lblDecryptKey.Text = "Ключ";
            // 
            // txtDecryptKey
            // 
            txtDecryptKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDecryptKey.BackColor = Color.White;
            txtDecryptKey.BorderStyle = BorderStyle.FixedSingle;
            txtDecryptKey.Font = new Font("Consolas", 10F);
            txtDecryptKey.Location = new Point(483, 121);
            txtDecryptKey.Name = "txtDecryptKey";
            txtDecryptKey.PlaceholderText = "Введите ключ";
            txtDecryptKey.Size = new Size(460, 27);
            txtDecryptKey.TabIndex = 3;
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackColor = Color.FromArgb(58, 58, 58);
            btnDecrypt.FlatAppearance.BorderSize = 0;
            btnDecrypt.FlatStyle = FlatStyle.Flat;
            btnDecrypt.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDecrypt.ForeColor = Color.White;
            btnDecrypt.Location = new Point(483, 166);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(460, 45);
            btnDecrypt.TabIndex = 4;
            btnDecrypt.Text = "Дешифровать";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += BtnDecrypt_Click;
            // 
            // lblDecryptOutput
            // 
            lblDecryptOutput.AutoSize = true;
            lblDecryptOutput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDecryptOutput.ForeColor = Color.FromArgb(60, 60, 60);
            lblDecryptOutput.Location = new Point(483, 226);
            lblDecryptOutput.Name = "lblDecryptOutput";
            lblDecryptOutput.Size = new Size(88, 23);
            lblDecryptOutput.TabIndex = 5;
            lblDecryptOutput.Text = "Результат";
            // 
            // txtDecryptOutput
            // 
            txtDecryptOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtDecryptOutput.BackColor = Color.FromArgb(250, 250, 250);
            txtDecryptOutput.BorderStyle = BorderStyle.FixedSingle;
            txtDecryptOutput.Font = new Font("Consolas", 10F);
            txtDecryptOutput.Location = new Point(483, 256);
            txtDecryptOutput.Multiline = true;
            txtDecryptOutput.Name = "txtDecryptOutput";
            txtDecryptOutput.ReadOnly = true;
            txtDecryptOutput.ScrollBars = ScrollBars.Vertical;
            txtDecryptOutput.Size = new Size(460, 215);
            txtDecryptOutput.TabIndex = 5;
            // 
            // btnDecryptSave
            // 
            btnDecryptSave.AutoSize = true;
            btnDecryptSave.BackColor = Color.FromArgb(100, 100, 100);
            btnDecryptSave.FlatAppearance.BorderSize = 0;
            btnDecryptSave.FlatStyle = FlatStyle.Flat;
            btnDecryptSave.Font = new Font("Segoe UI", 9F);
            btnDecryptSave.ForeColor = Color.White;
            btnDecryptSave.Image = (Image)resources.GetObject("btnDecryptSave.Image");
            btnDecryptSave.Location = new Point(483, 476);
            btnDecryptSave.Name = "btnDecryptSave";
            btnDecryptSave.Size = new Size(152, 35);
            btnDecryptSave.TabIndex = 6;
            btnDecryptSave.Text = "Сохранить файл";
            btnDecryptSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDecryptSave.UseVisualStyleBackColor = false;
            btnDecryptSave.Click += BtnDecryptSave_Click;
            // 
            // btnDecryptClear
            // 
            btnDecryptClear.AutoSize = true;
            btnDecryptClear.BackColor = Color.FromArgb(140, 140, 140);
            btnDecryptClear.FlatAppearance.BorderSize = 0;
            btnDecryptClear.FlatStyle = FlatStyle.Flat;
            btnDecryptClear.Font = new Font("Segoe UI", 9F);
            btnDecryptClear.ForeColor = Color.White;
            btnDecryptClear.Location = new Point(643, 476);
            btnDecryptClear.Name = "btnDecryptClear";
            btnDecryptClear.Size = new Size(140, 35);
            btnDecryptClear.TabIndex = 7;
            btnDecryptClear.Text = "Очистить все";
            btnDecryptClear.UseVisualStyleBackColor = false;
            btnDecryptClear.Click += BtnDecryptClear_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Title = "Выберите файл для открытия";
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Сохранить результат в файл";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 230, 230);
            ClientSize = new Size(1000, 600);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(800, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XOR Шифрование";
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
        
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Label labelTitleEncrypt;
        private Label labelTitleDecrypt;
    }
}
