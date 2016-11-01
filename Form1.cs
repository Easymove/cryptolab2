using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptolab2
{
    public partial class MainForm : Form
    {
        private readonly DESutils _cryptolizer;

        public MainForm()
        {
            InitializeComponent();
            _cryptolizer = new DESutils(outputTextBox);
        }

        private void browseEncrypt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                encryptFileBox.Text = openFileDialog1.FileName;
            }
        }

        private void browseDecrypt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                decryptFileBox.Text = openFileDialog1.FileName;
            }
        }

        private void pyschButton_Click(object sender, EventArgs e)
        {
            if (encryptInputBox.Text != "")
            {
                outputTextBox.AppendText(string.Format("Encoding of \"{0}\" started:\n", encryptInputBox.Text));
                outputTextBox.AppendText(string.Format("BYTES \"{0}\"\n", BitConverter.ToString(new ASCIIEncoding().GetBytes(encryptInputBox.Text))));
                var result = _cryptolizer.EncryptText(encryptInputBox.Text);
                outputTextBox.AppendText("Result:\n");
                outputTextBox.AppendText(string.Format("BYTES: \"{0}\"\n", BitConverter.ToString(result)));
                encryptInputBox.Text = "";
            }
            if (decryptInputBox.Text != "")
            {
                outputTextBox.AppendText(string.Format("Decoding of \"{0}\" started:\n", decryptInputBox.Text));
                var result = _cryptolizer.DecryptText(decryptInputBox.Text).TrimEnd('\0');
                outputTextBox.AppendText("Result:\n");
                outputTextBox.AppendText(string.Format("BYTES: \"{0}\"\n", BitConverter.ToString(new ASCIIEncoding().GetBytes(result))));
                outputTextBox.AppendText(string.Format("STRING: \"{0}\"\n", result));
                decryptInputBox.Text = "";
            }
            if (encryptFileBox.Text != "")
            {
                outputTextBox.AppendText(string.Format("Encoding of \"{0}\" started:\n", encryptFileBox.Text));
                _cryptolizer.EncryptFile(encryptFileBox.Text, encryptFileBox.Text + ".encrypted");
                outputTextBox.AppendText("Encoding finished!\n");
                encryptFileBox.Text = "";
            }
            if (decryptFileBox.Text != "")
            {
                outputTextBox.AppendText(string.Format("Encoding of \"{0}\" started:\n", decryptFileBox.Text));
                _cryptolizer.DecryptFile(decryptFileBox.Text, decryptFileBox.Text + ".decrypted");
                outputTextBox.AppendText("Decoding finished!\n");
                decryptFileBox.Text = "";
            }
        }
    }
}
