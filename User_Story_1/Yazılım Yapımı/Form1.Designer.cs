
namespace Yazılım_Yapımı
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.btn_Kapat = new System.Windows.Forms.Button();
            this.panelGiris = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Btn_Giris = new System.Windows.Forms.Button();
            this.Txt_Sifre = new System.Windows.Forms.TextBox();
            this.Txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelKayıtOl = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Adres = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Telefon = new System.Windows.Forms.TextBox();
            this.Txt_TCKimlikNo = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            this.Btn_KayitOl = new System.Windows.Forms.Button();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.Txt_Ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelGiris.SuspendLayout();
            this.panelKayıtOl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            this.btnGirisYap.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGirisYap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGirisYap.ForeColor = System.Drawing.Color.Maroon;
            this.btnGirisYap.Location = new System.Drawing.Point(8, 48);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(200, 40);
            this.btnGirisYap.TabIndex = 7;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.btnKayitOl.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKayitOl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKayitOl.ForeColor = System.Drawing.Color.Maroon;
            this.btnKayitOl.Location = new System.Drawing.Point(208, 48);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(200, 40);
            this.btnKayitOl.TabIndex = 8;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // btn_Kapat
            // 
            this.btn_Kapat.BackColor = System.Drawing.Color.Maroon;
            this.btn_Kapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Kapat.BackgroundImage")));
            this.btn_Kapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kapat.Location = new System.Drawing.Point(378, 12);
            this.btn_Kapat.Name = "btn_Kapat";
            this.btn_Kapat.Size = new System.Drawing.Size(30, 30);
            this.btn_Kapat.TabIndex = 11;
            this.btn_Kapat.UseVisualStyleBackColor = false;
            this.btn_Kapat.Click += new System.EventHandler(this.btn_Kapat_Click);
            // 
            // panelGiris
            // 
            this.panelGiris.Controls.Add(this.checkBox1);
            this.panelGiris.Controls.Add(this.Btn_Giris);
            this.panelGiris.Controls.Add(this.Txt_Sifre);
            this.panelGiris.Controls.Add(this.Txt_KullaniciAdi);
            this.panelGiris.Controls.Add(this.label3);
            this.panelGiris.Controls.Add(this.label1);
            this.panelGiris.Location = new System.Drawing.Point(10, 94);
            this.panelGiris.Name = "panelGiris";
            this.panelGiris.Size = new System.Drawing.Size(398, 344);
            this.panelGiris.TabIndex = 36;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.Maroon;
            this.checkBox1.Location = new System.Drawing.Point(183, 171);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 25);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Btn_Giris
            // 
            this.Btn_Giris.BackColor = System.Drawing.Color.Tomato;
            this.Btn_Giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Giris.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Giris.ForeColor = System.Drawing.Color.Teal;
            this.Btn_Giris.Location = new System.Drawing.Point(95, 211);
            this.Btn_Giris.Name = "Btn_Giris";
            this.Btn_Giris.Size = new System.Drawing.Size(200, 40);
            this.Btn_Giris.TabIndex = 11;
            this.Btn_Giris.Text = "Giriş Yap";
            this.Btn_Giris.UseVisualStyleBackColor = false;
            // 
            // Txt_Sifre
            // 
            this.Txt_Sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.Txt_Sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Sifre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Sifre.ForeColor = System.Drawing.Color.Maroon;
            this.Txt_Sifre.Location = new System.Drawing.Point(183, 136);
            this.Txt_Sifre.Name = "Txt_Sifre";
            this.Txt_Sifre.Size = new System.Drawing.Size(150, 29);
            this.Txt_Sifre.TabIndex = 10;
            // 
            // Txt_KullaniciAdi
            // 
            this.Txt_KullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.Txt_KullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_KullaniciAdi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_KullaniciAdi.ForeColor = System.Drawing.Color.Maroon;
            this.Txt_KullaniciAdi.Location = new System.Drawing.Point(183, 101);
            this.Txt_KullaniciAdi.Name = "Txt_KullaniciAdi";
            this.Txt_KullaniciAdi.Size = new System.Drawing.Size(150, 29);
            this.Txt_KullaniciAdi.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(132, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(66, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // panelKayıtOl
            // 
            this.panelKayıtOl.Controls.Add(this.label10);
            this.panelKayıtOl.Controls.Add(this.label9);
            this.panelKayıtOl.Controls.Add(this.label8);
            this.panelKayıtOl.Controls.Add(this.label7);
            this.panelKayıtOl.Controls.Add(this.label6);
            this.panelKayıtOl.Controls.Add(this.label5);
            this.panelKayıtOl.Controls.Add(this.label4);
            this.panelKayıtOl.Controls.Add(this.Txt_Adres);
            this.panelKayıtOl.Controls.Add(this.Txt_Email);
            this.panelKayıtOl.Controls.Add(this.Txt_Telefon);
            this.panelKayıtOl.Controls.Add(this.Txt_TCKimlikNo);
            this.panelKayıtOl.Controls.Add(this.Txt_Password);
            this.panelKayıtOl.Controls.Add(this.Txt_UserName);
            this.panelKayıtOl.Controls.Add(this.Btn_KayitOl);
            this.panelKayıtOl.Controls.Add(this.TxtSoyad);
            this.panelKayıtOl.Controls.Add(this.Txt_Ad);
            this.panelKayıtOl.Controls.Add(this.label2);
            this.panelKayıtOl.Location = new System.Drawing.Point(10, 94);
            this.panelKayıtOl.Name = "panelKayıtOl";
            this.panelKayıtOl.Size = new System.Drawing.Size(398, 344);
            this.panelKayıtOl.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(137, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 21);
            this.label10.TabIndex = 70;
            this.label10.Text = "Adres";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(135, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 21);
            this.label9.TabIndex = 69;
            this.label9.Text = "E-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(126, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 68;
            this.label8.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(76, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 21);
            this.label7.TabIndex = 67;
            this.label7.Text = "TC Kimlik No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(108, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 66;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(81, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 65;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(134, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 64;
            this.label4.Text = "Soyad";
            // 
            // Txt_Adres
            // 
            this.Txt_Adres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.Txt_Adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Adres.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Adres.ForeColor = System.Drawing.Color.Maroon;
            this.Txt_Adres.Location = new System.Drawing.Point(198, 260);
            this.Txt_Adres.Name = "Txt_Adres";
            this.Txt_Adres.Size = new System.Drawing.Size(150, 29);
            this.Txt_Adres.TabIndex = 63;
            // 
            // Txt_Email
            // 
            this.Txt_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.Txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Email.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Email.ForeColor = System.Drawing.Color.Maroon;
            this.Txt_Email.Location = new System.Drawing.Point(198, 225);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(150, 29);
            this.Txt_Email.TabIndex = 62;
            // 
            // Txt_Telefon
            // 
            this.Txt_Telefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.Txt_Telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Telefon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Telefon.ForeColor = System.Drawing.Color.Maroon;
            this.Txt_Telefon.Location = new System.Drawing.Point(198, 190);
            this.Txt_Telefon.Name = "Txt_Telefon";
            this.Txt_Telefon.Size = new System.Drawing.Size(150, 29);
            this.Txt_Telefon.TabIndex = 61;
            // 
            // Txt_TCKimlikNo
            // 
            this.Txt_TCKimlikNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.Txt_TCKimlikNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_TCKimlikNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_TCKimlikNo.ForeColor = System.Drawing.Color.Maroon;
            this.Txt_TCKimlikNo.Location = new System.Drawing.Point(198, 155);
            this.Txt_TCKimlikNo.Name = "Txt_TCKimlikNo";
            this.Txt_TCKimlikNo.Size = new System.Drawing.Size(150, 29);
            this.Txt_TCKimlikNo.TabIndex = 60;
            // 
            // Txt_Password
            // 
            this.Txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.Txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Password.ForeColor = System.Drawing.Color.Maroon;
            this.Txt_Password.Location = new System.Drawing.Point(198, 120);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(150, 29);
            this.Txt_Password.TabIndex = 59;
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.Txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_UserName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_UserName.ForeColor = System.Drawing.Color.Maroon;
            this.Txt_UserName.Location = new System.Drawing.Point(198, 85);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(150, 29);
            this.Txt_UserName.TabIndex = 58;
            // 
            // Btn_KayitOl
            // 
            this.Btn_KayitOl.BackColor = System.Drawing.Color.Tomato;
            this.Btn_KayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_KayitOl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_KayitOl.ForeColor = System.Drawing.Color.Teal;
            this.Btn_KayitOl.Location = new System.Drawing.Point(100, 295);
            this.Btn_KayitOl.Name = "Btn_KayitOl";
            this.Btn_KayitOl.Size = new System.Drawing.Size(200, 40);
            this.Btn_KayitOl.TabIndex = 57;
            this.Btn_KayitOl.Text = "Kayıt Ol";
            this.Btn_KayitOl.UseVisualStyleBackColor = false;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.TxtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSoyad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSoyad.ForeColor = System.Drawing.Color.Maroon;
            this.TxtSoyad.Location = new System.Drawing.Point(198, 50);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(150, 29);
            this.TxtSoyad.TabIndex = 56;
            // 
            // Txt_Ad
            // 
            this.Txt_Ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.Txt_Ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Ad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Ad.ForeColor = System.Drawing.Color.Maroon;
            this.Txt_Ad.Location = new System.Drawing.Point(198, 15);
            this.Txt_Ad.Name = "Txt_Ad";
            this.Txt_Ad.Size = new System.Drawing.Size(150, 29);
            this.Txt_Ad.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(159, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 21);
            this.label2.TabIndex = 54;
            this.label2.Text = "Ad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(418, 451);
            this.Controls.Add(this.btn_Kapat);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.panelGiris);
            this.Controls.Add(this.panelKayıtOl);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelGiris.ResumeLayout(false);
            this.panelGiris.PerformLayout();
            this.panelKayıtOl.ResumeLayout(false);
            this.panelKayıtOl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Button btn_Kapat;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Panel panelGiris;
        private System.Windows.Forms.Button Btn_Giris;
        private System.Windows.Forms.TextBox Txt_Sifre;
        private System.Windows.Forms.TextBox Txt_KullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelKayıtOl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Adres;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Telefon;
        private System.Windows.Forms.TextBox Txt_TCKimlikNo;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.TextBox Txt_UserName;
        private System.Windows.Forms.Button Btn_KayitOl;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox Txt_Ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

