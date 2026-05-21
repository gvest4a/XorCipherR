namespace XorCipherR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// XOR encryption/decryption algorithm
        /// </summary>
        private string XorCipher(string input, string key)
        {
            if (string.IsNullOrEmpty(key))
                return input;

            char[] result = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                result[i] = (char)(input[i] ^ key[i % key.Length]);
            }
            return new string(result);
        }

        /// <summary>
        /// Convert string to hex representation
        /// </summary>
        private string StringToHex(string input)
        {
            StringBuilder hex = new StringBuilder();
            foreach (char c in input)
            {
                hex.Append(((int)c).ToString("X2"));
            }
            return hex.ToString();
        }

        /// <summary>
        /// Convert hex representation back to string
        /// </summary>
        private string HexToString(string hex)
        {
            try
            {
                StringBuilder result = new StringBuilder();
                for (int i = 0; i < hex.Length; i += 2)
                {
                    if (i + 1 < hex.Length)
                    {
                        string hexPair = hex.Substring(i, 2);
                        int value = Convert.ToInt32(hexPair, 16);
                        result.Append((char)value);
                    }
                }
                return result.ToString();
            }
            catch
            {
                return hex; // Return as-is if conversion fails
            }
        }

        #region Encrypt Tab Event Handlers

        private void BtnEncrypt_Click(object? sender, EventArgs e)
        {
            string input = txtEncryptInput.Text;
            string key = txtEncryptKey.Text;

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter text to encrypt.", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter an encryption key.", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string encrypted = XorCipher(input, key);
                string hexOutput = StringToHex(encrypted);
                txtEncryptOutput.Text = hexOutput;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encryption error: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEncryptLoadFile_Click(object? sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string content = File.ReadAllText(openFileDialog.FileName);
                    txtEncryptInput.Text = content;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading file: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEncryptSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEncryptOutput.Text))
            {
                MessageBox.Show("No encrypted data to save.", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog.FileName = "encrypted_output.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, txtEncryptOutput.Text);
                    MessageBox.Show("Encrypted data saved successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEncryptClear_Click(object? sender, EventArgs e)
        {
            txtEncryptInput.Clear();
            txtEncryptKey.Clear();
            txtEncryptOutput.Clear();
        }

        #endregion

        #region Decrypt Tab Event Handlers

        private void BtnDecrypt_Click(object? sender, EventArgs e)
        {
            string input = txtDecryptInput.Text;
            string key = txtDecryptKey.Text;

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter encrypted text to decrypt.", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter a decryption key.", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // First convert from hex back to encrypted string
                string encryptedData = HexToString(input);
                // Then decrypt using XOR
                string decrypted = XorCipher(encryptedData, key);
                txtDecryptOutput.Text = decrypted;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Decryption error: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDecryptLoadFile_Click(object? sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string content = File.ReadAllText(openFileDialog.FileName);
                    txtDecryptInput.Text = content;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading file: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnDecryptSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDecryptOutput.Text))
            {
                MessageBox.Show("No decrypted data to save.", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog.FileName = "decrypted_output.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, txtDecryptOutput.Text);
                    MessageBox.Show("Decrypted data saved successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnDecryptClear_Click(object? sender, EventArgs e)
        {
            txtDecryptInput.Clear();
            txtDecryptKey.Clear();
            txtDecryptOutput.Clear();
        }

        #endregion
    }
}
