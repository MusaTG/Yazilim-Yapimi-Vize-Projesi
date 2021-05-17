
namespace Yazılım_Yapımı_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.Txt_Sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Giris = new System.Windows.Forms.Button();
            this.CB_SifreGoster = new System.Windows.Forms.CheckBox();
            this.LBL_Kaydol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // Txt_KullaniciAdi
            // 
            this.Txt_KullaniciAdi.Location = new System.Drawing.Point(168, 94);
            this.Txt_KullaniciAdi.Name = "Txt_KullaniciAdi";
            this.Txt_KullaniciAdi.Size = new System.Drawing.Size(132, 35);
            this.Txt_KullaniciAdi.TabIndex = 1;
            // 
            // Txt_Sifre
            // 
            this.Txt_Sifre.Location = new System.Drawing.Point(168, 135);
            this.Txt_Sifre.Name = "Txt_Sifre";
            this.Txt_Sifre.Size = new System.Drawing.Size(132, 35);
            this.Txt_Sifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(91, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giriş Ekranı";
            // 
            // Btn_Giris
            // 
            this.Btn_Giris.Location = new System.Drawing.Point(168, 206);
            this.Btn_Giris.Name = "Btn_Giris";
            this.Btn_Giris.Size = new System.Drawing.Size(132, 39);
            this.Btn_Giris.TabIndex = 5;
            this.Btn_Giris.Text = "Giriş";
            this.Btn_Giris.UseVisualStyleBackColor = true;
            this.Btn_Giris.Click += new System.EventHandler(this.Btn_Giris_Click);
            // 
            // CB_SifreGoster
            // 
            this.CB_SifreGoster.AutoSize = true;
            this.CB_SifreGoster.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB_SifreGoster.Location = new System.Drawing.Point(168, 176);
            this.CB_SifreGoster.Name = "CB_SifreGoster";
            this.CB_SifreGoster.Size = new System.Drawing.Size(116, 24);
            this.CB_SifreGoster.TabIndex = 6;
            this.CB_SifreGoster.Text = "Şifreyi Göster";
            this.CB_SifreGoster.UseVisualStyleBackColor = true;
            this.CB_SifreGoster.CheckedChanged += new System.EventHandler(this.CB_SifreGoster_CheckedChanged);
            // 
            // LBL_Kaydol
            // 
            this.LBL_Kaydol.AutoSize = true;
            this.LBL_Kaydol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Kaydol.Location = new System.Drawing.Point(203, 248);
            this.LBL_Kaydol.Name = "LBL_Kaydol";
            this.LBL_Kaydol.Size = new System.Drawing.Size(57, 21);
            this.LBL_Kaydol.TabIndex = 7;
            this.LBL_Kaydol.Text = "Kaydol";
            this.LBL_Kaydol.Click += new System.EventHandler(this.LBL_Kaydol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 307);
            this.Controls.Add(this.LBL_Kaydol);
            this.Controls.Add(this.CB_SifreGoster);
            this.Controls.Add(this.Btn_Giris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_KullaniciAdi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_KullaniciAdi;
        private System.Windows.Forms.TextBox Txt_Sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Giris;
        private System.Windows.Forms.CheckBox CB_Sifr;
        private System.Windows.Forms.CheckBox CB_SifreGoster;
        private System.Windows.Forms.Label LBL_Kaydol;
    }
}

