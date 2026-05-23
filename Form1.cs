using System.Text;

namespace XorCipherR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        private string StringToHex(string input)
        {
            StringBuilder hex = new StringBuilder();
            foreach (char c in input)
            {
                hex.Append(((int)c).ToString("X2"));
            }
            return hex.ToString();
        }

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
                return hex; 
            }
        }

        private void BtnEncrypt_Click(object? sender, EventArgs e)
        {
            string input = txtEncryptInput.Text;
            string key = txtEncryptKey.Text;

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Пожалуйста, введите текст", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Пожалуйста, введите ключ", "Внимание",
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
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
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
                    MessageBox.Show($"Ошибка загрузки файла: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEncryptSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEncryptOutput.Text))
            {
                MessageBox.Show("Нет данных для сохранения", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog.FileName = "encrypted_output.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, txtEncryptOutput.Text);
                    MessageBox.Show("Успешно сохранено", "Успешно",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
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

        private void BtnDecrypt_Click(object? sender, EventArgs e)
        {
            string input = txtDecryptInput.Text;
            string key = txtDecryptKey.Text;

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Пожалуйста, введите текст", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Пожалуйста, введите ключ", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
         
                string encryptedData = HexToString(input);
                string decrypted = XorCipher(encryptedData, key);

                txtDecryptOutput.Text = decrypted;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
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
                    MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnDecryptSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDecryptOutput.Text))
            {
                MessageBox.Show("Нет данных для сохранения", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog.FileName = "decrypted_output.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, txtDecryptOutput.Text);
                    MessageBox.Show("Успешно сохранено", "Успешно",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
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
    }
}
