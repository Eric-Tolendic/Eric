using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cyphers
{
    public partial class Form2 : Form
    {
        private ICipherDecipher myCipher;
        public Form2()
        {
            //myCipher = new CaesarCipher();
            myCipher = new VigenereCipher();
            InitializeComponent();
            MessageBox.Show("Vigenere cipher is a method of encrypting alphabetic text by using a series of interwoven Caesar ciphers, based on the letters of a keyword. It employs a form of polyalphabetic substitution.");
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
            string textCiphered = myCipher.Cipher(textToBeCiphered, "hitler");
            txtb_CipheredText.Text = textCiphered;
        }

        private void btn_Decipher_Click(object sender, EventArgs e)
        {
            string textToBeUnciphered = txtb_CipheredText.Text;
            string textUnciphered = myCipher.Decipher(textToBeUnciphered, "hitler");
            txtb_UncipheredText.Text = textUnciphered;
        }
    }
}
