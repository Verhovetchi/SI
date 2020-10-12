namespace RSAEncrypt
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
               this.components = new System.ComponentModel.Container();
               this.txtPlain = new System.Windows.Forms.TextBox();
               this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
               this.txtEncrypt = new System.Windows.Forms.TextBox();
               this.btnEncrypt = new System.Windows.Forms.Button();
               this.btnDecrypt = new System.Windows.Forms.Button();
               this.lbInput = new System.Windows.Forms.Label();
               this.lbEncrypted = new System.Windows.Forms.Label();
               this.lbDecrypted = new System.Windows.Forms.Label();
               this.txtDecrypt = new System.Windows.Forms.TextBox();
               this.SuspendLayout();
               // 
               // txtPlain
               // 
               this.txtPlain.Location = new System.Drawing.Point(30, 37);
               this.txtPlain.Multiline = true;
               this.txtPlain.Name = "txtPlain";
               this.txtPlain.Size = new System.Drawing.Size(664, 96);
               this.txtPlain.TabIndex = 0;
               // 
               // contextMenuStrip1
               // 
               this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
               this.contextMenuStrip1.Name = "contextMenuStrip1";
               this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
               // 
               // txtEncrypt
               // 
               this.txtEncrypt.Location = new System.Drawing.Point(30, 176);
               this.txtEncrypt.Multiline = true;
               this.txtEncrypt.Name = "txtEncrypt";
               this.txtEncrypt.Size = new System.Drawing.Size(664, 103);
               this.txtEncrypt.TabIndex = 2;
               // 
               // btnEncrypt
               // 
               this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
               this.btnEncrypt.Location = new System.Drawing.Point(700, 37);
               this.btnEncrypt.Name = "btnEncrypt";
               this.btnEncrypt.Size = new System.Drawing.Size(88, 38);
               this.btnEncrypt.TabIndex = 4;
               this.btnEncrypt.Text = "Encrypt";
               this.btnEncrypt.UseVisualStyleBackColor = true;
               this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
               // 
               // btnDecrypt
               // 
               this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
               this.btnDecrypt.Location = new System.Drawing.Point(700, 93);
               this.btnDecrypt.Name = "btnDecrypt";
               this.btnDecrypt.Size = new System.Drawing.Size(88, 40);
               this.btnDecrypt.TabIndex = 5;
               this.btnDecrypt.Text = "Decrypt";
               this.btnDecrypt.UseVisualStyleBackColor = true;
               this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
               // 
               // lbInput
               // 
               this.lbInput.AutoSize = true;
               this.lbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
               this.lbInput.Location = new System.Drawing.Point(27, 9);
               this.lbInput.Name = "lbInput";
               this.lbInput.Size = new System.Drawing.Size(91, 25);
               this.lbInput.TabIndex = 6;
               this.lbInput.Text = "Input text";
               // 
               // lbEncrypted
               // 
               this.lbEncrypted.AutoSize = true;
               this.lbEncrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
               this.lbEncrypted.Location = new System.Drawing.Point(27, 148);
               this.lbEncrypted.Name = "lbEncrypted";
               this.lbEncrypted.Size = new System.Drawing.Size(144, 25);
               this.lbEncrypted.TabIndex = 7;
               this.lbEncrypted.Text = "Encrypted Text";
               // 
               // lbDecrypted
               // 
               this.lbDecrypted.AutoSize = true;
               this.lbDecrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
               this.lbDecrypted.Location = new System.Drawing.Point(27, 301);
               this.lbDecrypted.Name = "lbDecrypted";
               this.lbDecrypted.Size = new System.Drawing.Size(145, 25);
               this.lbDecrypted.TabIndex = 8;
               this.lbDecrypted.Text = "Decrypted Text";
               // 
               // txtDecrypt
               // 
               this.txtDecrypt.Location = new System.Drawing.Point(30, 335);
               this.txtDecrypt.Multiline = true;
               this.txtDecrypt.Name = "txtDecrypt";
               this.txtDecrypt.Size = new System.Drawing.Size(664, 103);
               this.txtDecrypt.TabIndex = 9;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.AliceBlue;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.txtDecrypt);
               this.Controls.Add(this.lbDecrypted);
               this.Controls.Add(this.lbEncrypted);
               this.Controls.Add(this.lbInput);
               this.Controls.Add(this.btnDecrypt);
               this.Controls.Add(this.btnEncrypt);
               this.Controls.Add(this.txtEncrypt);
               this.Controls.Add(this.txtPlain);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
               this.Name = "Form1";
               this.Text = "RSA Algorithm";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TextBox txtPlain;
          private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
          private System.Windows.Forms.TextBox txtEncrypt;
          private System.Windows.Forms.Button btnEncrypt;
          private System.Windows.Forms.Button btnDecrypt;
          private System.Windows.Forms.Label lbInput;
          private System.Windows.Forms.Label lbEncrypted;
          private System.Windows.Forms.Label lbDecrypted;
          private System.Windows.Forms.TextBox txtDecrypt;
     }
}

