namespace cryptolab2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.encryptInputBox = new System.Windows.Forms.TextBox();
            this.decryptInputBox = new System.Windows.Forms.TextBox();
            this.pyschButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.encryptFileBox = new System.Windows.Forms.TextBox();
            this.decryptFileBox = new System.Windows.Forms.TextBox();
            this.browseEncrypt = new System.Windows.Forms.Button();
            this.browseDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Micra", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text to encrypt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Micra", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text to decrypt:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTextBox.Location = new System.Drawing.Point(12, 150);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(805, 199);
            this.outputTextBox.TabIndex = 2;
            // 
            // encryptInputBox
            // 
            this.encryptInputBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptInputBox.Location = new System.Drawing.Point(316, 10);
            this.encryptInputBox.Name = "encryptInputBox";
            this.encryptInputBox.Size = new System.Drawing.Size(656, 26);
            this.encryptInputBox.TabIndex = 3;
            // 
            // decryptInputBox
            // 
            this.decryptInputBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptInputBox.Location = new System.Drawing.Point(316, 44);
            this.decryptInputBox.Name = "decryptInputBox";
            this.decryptInputBox.Size = new System.Drawing.Size(656, 26);
            this.decryptInputBox.TabIndex = 4;
            // 
            // pyschButton
            // 
            this.pyschButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pyschButton.BackgroundImage")));
            this.pyschButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pyschButton.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pyschButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pyschButton.Location = new System.Drawing.Point(830, 207);
            this.pyschButton.Name = "pyschButton";
            this.pyschButton.Size = new System.Drawing.Size(142, 142);
            this.pyschButton.TabIndex = 5;
            this.pyschButton.Text = "PYSCH!";
            this.pyschButton.UseVisualStyleBackColor = true;
            this.pyschButton.Click += new System.EventHandler(this.pyschButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Micra", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "File to encrypt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Micra", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "File to decrypt:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // encryptFileBox
            // 
            this.encryptFileBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptFileBox.Location = new System.Drawing.Point(316, 75);
            this.encryptFileBox.Name = "encryptFileBox";
            this.encryptFileBox.Size = new System.Drawing.Size(543, 26);
            this.encryptFileBox.TabIndex = 8;
            // 
            // decryptFileBox
            // 
            this.decryptFileBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptFileBox.Location = new System.Drawing.Point(316, 108);
            this.decryptFileBox.Name = "decryptFileBox";
            this.decryptFileBox.Size = new System.Drawing.Size(543, 26);
            this.decryptFileBox.TabIndex = 9;
            // 
            // browseEncrypt
            // 
            this.browseEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browseEncrypt.Location = new System.Drawing.Point(866, 75);
            this.browseEncrypt.Name = "browseEncrypt";
            this.browseEncrypt.Size = new System.Drawing.Size(106, 24);
            this.browseEncrypt.TabIndex = 10;
            this.browseEncrypt.Text = "browse";
            this.browseEncrypt.UseVisualStyleBackColor = true;
            this.browseEncrypt.Click += new System.EventHandler(this.browseEncrypt_Click);
            // 
            // browseDecrypt
            // 
            this.browseDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browseDecrypt.Location = new System.Drawing.Point(865, 108);
            this.browseDecrypt.Name = "browseDecrypt";
            this.browseDecrypt.Size = new System.Drawing.Size(107, 24);
            this.browseDecrypt.TabIndex = 11;
            this.browseDecrypt.Text = "browse";
            this.browseDecrypt.UseVisualStyleBackColor = true;
            this.browseDecrypt.Click += new System.EventHandler(this.browseDecrypt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.browseDecrypt);
            this.Controls.Add(this.browseEncrypt);
            this.Controls.Add(this.decryptFileBox);
            this.Controls.Add(this.encryptFileBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pyschButton);
            this.Controls.Add(this.decryptInputBox);
            this.Controls.Add(this.encryptInputBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 400);
            this.MinimumSize = new System.Drawing.Size(1000, 400);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "DES CBC encoder/decoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox encryptInputBox;
        private System.Windows.Forms.TextBox decryptInputBox;
        private System.Windows.Forms.Button pyschButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox encryptFileBox;
        private System.Windows.Forms.TextBox decryptFileBox;
        private System.Windows.Forms.Button browseEncrypt;
        private System.Windows.Forms.Button browseDecrypt;
    }
}

