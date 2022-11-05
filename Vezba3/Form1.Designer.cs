namespace Vezba3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPublic = new System.Windows.Forms.RichTextBox();
            this.txtPrivate = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEncrypt = new System.Windows.Forms.RichTextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtDecMsg = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Public Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Private Key";
            // 
            // txtPublic
            // 
            this.txtPublic.Location = new System.Drawing.Point(54, 49);
            this.txtPublic.Name = "txtPublic";
            this.txtPublic.Size = new System.Drawing.Size(222, 96);
            this.txtPublic.TabIndex = 3;
            this.txtPublic.Text = "";
            // 
            // txtPrivate
            // 
            this.txtPrivate.Location = new System.Drawing.Point(499, 50);
            this.txtPrivate.Name = "txtPrivate";
            this.txtPrivate.Size = new System.Drawing.Size(204, 96);
            this.txtPrivate.TabIndex = 4;
            this.txtPrivate.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Текст";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(16, 221);
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(260, 20);
            this.txtPlain.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Енкрипција";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(54, 320);
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(222, 96);
            this.txtEncrypt.TabIndex = 8;
            this.txtEncrypt.Text = "";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(496, 204);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(106, 13);
            this.label.TabIndex = 9;
            this.label.Text = "Енкриптиран Текст";
            // 
            // txtDecMsg
            // 
            this.txtDecMsg.Location = new System.Drawing.Point(499, 257);
            this.txtDecMsg.Name = "txtDecMsg";
            this.txtDecMsg.Size = new System.Drawing.Size(204, 96);
            this.txtDecMsg.TabIndex = 10;
            this.txtDecMsg.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Декрипција";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(499, 418);
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(204, 20);
            this.txtDecrypt.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtDecMsg);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtEncrypt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrivate);
            this.Controls.Add(this.txtPublic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtPublic;
        private System.Windows.Forms.RichTextBox txtPrivate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtEncrypt;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RichTextBox txtDecMsg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDecrypt;
    }
}

