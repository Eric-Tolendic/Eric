using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cyphers
{
    public partial class FormCore : Form
    {
        public FormCore()
        {
            InitializeComponent();
            MessageBox.Show("Hello. You are using Cipher Application by Eric");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 testDialog = new Form1();
            this.Visible = false;
            testDialog.ShowDialog(this);
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 testDialog = new Form2();
            this.Visible = false;
            testDialog.ShowDialog(this);
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 testDialog = new Form3();
            this.Visible = false;
            testDialog.ShowDialog(this);
            this.Visible = true;
        }
    }
}
