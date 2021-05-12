using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cyphers
{
    public partial class Form3 : Form
    {
        private ICipherDecipher myCipher;
        public Form3()
        {
            myCipher = new VernamCipher();
            InitializeComponent();
            MessageBox.Show("Vernam cipher is, in theory, a perfect cipher. Instead of a single key, each plaintext character is encrypted using its own key");
        }

        private void btn_ClearUncipheredText_Click(object sender, EventArgs e)
        {
            txtb_UncipheredText.Text = string.Empty;
        }

        private void btn_ClearCipheredText_Click(object sender, EventArgs e)
        {
            txtb_CipheredText.Clear();
        }

        private void btn_Cipher_Click(object sender, EventArgs e)
        {
            string textToBeCiphered = txtb_UncipheredText.Text;
            string textCiphered = myCipher.Cipher(textToBeCiphered, "Eric");
            txtb_CipheredText.Text = textCiphered;
        }

        private void btn_Decipher_Click(object sender, EventArgs e)
        {
            string textToBeUnciphered = txtb_CipheredText.Text;
            string textUnciphered = myCipher.Decipher(textToBeUnciphered, "Eric");
            txtb_UncipheredText.Text = textUnciphered;
        }
    }
}
