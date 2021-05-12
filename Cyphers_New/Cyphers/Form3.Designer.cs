
namespace Cyphers
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtb_UncipheredText = new System.Windows.Forms.TextBox();
            this.txtb_CipheredText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cipher = new System.Windows.Forms.Button();
            this.btn_Decipher = new System.Windows.Forms.Button();
            this.btn_ClearUncipheredText = new System.Windows.Forms.Button();
            this.btn_ClearCipheredText = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtb_UncipheredText
            // 
            this.txtb_UncipheredText.Location = new System.Drawing.Point(43, 64);
            this.txtb_UncipheredText.Multiline = true;
            this.txtb_UncipheredText.Name = "txtb_UncipheredText";
            this.txtb_UncipheredText.Size = new System.Drawing.Size(100, 114);
            this.txtb_UncipheredText.TabIndex = 0;
            // 
            // txtb_CipheredText
            // 
            this.txtb_CipheredText.Location = new System.Drawing.Point(43, 246);
            this.txtb_CipheredText.Multiline = true;
            this.txtb_CipheredText.Name = "txtb_CipheredText";
            this.txtb_CipheredText.Size = new System.Drawing.Size(100, 109);
            this.txtb_CipheredText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unciphered Text";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ciphered Text";
            // 
            // btn_Cipher
            // 
            this.btn_Cipher.Location = new System.Drawing.Point(288, 64);
            this.btn_Cipher.Name = "btn_Cipher";
            this.btn_Cipher.Size = new System.Drawing.Size(74, 32);
            this.btn_Cipher.TabIndex = 4;
            this.btn_Cipher.Text = "Cipher";
            this.btn_Cipher.UseVisualStyleBackColor = true;
            this.btn_Cipher.Click += new System.EventHandler(this.btn_Cipher_Click);
            // 
            // btn_Decipher
            // 
            this.btn_Decipher.Location = new System.Drawing.Point(288, 245);
            this.btn_Decipher.Name = "btn_Decipher";
            this.btn_Decipher.Size = new System.Drawing.Size(74, 35);
            this.btn_Decipher.TabIndex = 5;
            this.btn_Decipher.Text = "Decipher";
            this.btn_Decipher.UseVisualStyleBackColor = true;
            this.btn_Decipher.Click += new System.EventHandler(this.btn_Decipher_Click);
            // 
            // btn_ClearUncipheredText
            // 
            this.btn_ClearUncipheredText.Location = new System.Drawing.Point(439, 64);
            this.btn_ClearUncipheredText.Name = "btn_ClearUncipheredText";
            this.btn_ClearUncipheredText.Size = new System.Drawing.Size(75, 32);
            this.btn_ClearUncipheredText.TabIndex = 6;
            this.btn_ClearUncipheredText.Text = "Clear text box";
            this.btn_ClearUncipheredText.UseVisualStyleBackColor = true;
            this.btn_ClearUncipheredText.Click += new System.EventHandler(this.btn_ClearUncipheredText_Click);
            // 
            // btn_ClearCipheredText
            // 
            this.btn_ClearCipheredText.Location = new System.Drawing.Point(439, 245);
            this.btn_ClearCipheredText.Name = "btn_ClearCipheredText";
            this.btn_ClearCipheredText.Size = new System.Drawing.Size(75, 35);
            this.btn_ClearCipheredText.TabIndex = 7;
            this.btn_ClearCipheredText.Text = "Clear text box";
            this.btn_ClearCipheredText.UseVisualStyleBackColor = true;
            this.btn_ClearCipheredText.Click += new System.EventHandler(this.btn_ClearCipheredText_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(594, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 139);
            this.label3.TabIndex = 8;
            this.label3.Text = "Only Latin alphabet. Please enter only word";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ClearCipheredText);
            this.Controls.Add(this.btn_ClearUncipheredText);
            this.Controls.Add(this.btn_Decipher);
            this.Controls.Add(this.btn_Cipher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_CipheredText);
            this.Controls.Add(this.txtb_UncipheredText);
            this.Name = "Form3";
            this.Text = "Vernam Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_UncipheredText;
        private System.Windows.Forms.TextBox txtb_CipheredText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cipher;
        private System.Windows.Forms.Button btn_Decipher;
        private System.Windows.Forms.Button btn_ClearUncipheredText;
        private System.Windows.Forms.Button btn_ClearCipheredText;
        private System.Windows.Forms.Label label3;
    }
}