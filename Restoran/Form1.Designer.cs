
namespace Restoran
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
            this.components = new System.ComponentModel.Container();
            this.grpBoxGirisEkrani = new System.Windows.Forms.GroupBox();
            this.labelSifreUnuttum = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.labelBaslik = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.timerGiris = new System.Windows.Forms.Timer(this.components);
            this.btnSqlBaglan = new System.Windows.Forms.Button();
            this.txtSqlip = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxGirisEkrani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxGirisEkrani
            // 
            this.grpBoxGirisEkrani.Controls.Add(this.labelSifreUnuttum);
            this.grpBoxGirisEkrani.Controls.Add(this.txtKullaniciAdi);
            this.grpBoxGirisEkrani.Controls.Add(this.btnGiris);
            this.grpBoxGirisEkrani.Controls.Add(this.txtSifre);
            this.grpBoxGirisEkrani.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpBoxGirisEkrani.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBoxGirisEkrani.Location = new System.Drawing.Point(222, 121);
            this.grpBoxGirisEkrani.Name = "grpBoxGirisEkrani";
            this.grpBoxGirisEkrani.Size = new System.Drawing.Size(340, 311);
            this.grpBoxGirisEkrani.TabIndex = 2;
            this.grpBoxGirisEkrani.TabStop = false;
            this.grpBoxGirisEkrani.Text = "Personel Girişi";
            // 
            // labelSifreUnuttum
            // 
            this.labelSifreUnuttum.AutoSize = true;
            this.labelSifreUnuttum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelSifreUnuttum.Location = new System.Drawing.Point(93, 259);
            this.labelSifreUnuttum.Name = "labelSifreUnuttum";
            this.labelSifreUnuttum.Size = new System.Drawing.Size(145, 21);
            this.labelSifreUnuttum.TabIndex = 6;
            this.labelSifreUnuttum.Text = "Şifreni mi Unuttun?";
            this.labelSifreUnuttum.Click += new System.EventHandler(this.labelSifreUnuttum_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKullaniciAdi.Location = new System.Drawing.Point(47, 57);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(240, 34);
            this.txtKullaniciAdi.TabIndex = 3;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(47, 196);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(240, 43);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSifre.Location = new System.Drawing.Point(47, 118);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.PlaceholderText = "Şifre";
            this.txtSifre.Size = new System.Drawing.Size(240, 34);
            this.txtSifre.TabIndex = 4;
            // 
            // picLoading
            // 
            this.picLoading.BackColor = System.Drawing.Color.Transparent;
            this.picLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLoading.Image = global::Restoran.Properties.Resources.loading;
            this.picLoading.Location = new System.Drawing.Point(12, 32);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(140, 140);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoading.TabIndex = 0;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // labelBaslik
            // 
            this.labelBaslik.AutoSize = true;
            this.labelBaslik.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBaslik.Location = new System.Drawing.Point(215, 32);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(268, 28);
            this.labelBaslik.TabIndex = 7;
            this.labelBaslik.Text = "Restoran Personel Giriş Ekranı";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Restoran.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Location = new System.Drawing.Point(749, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timerGiris
            // 
            this.timerGiris.Interval = 1000;
            this.timerGiris.Tick += new System.EventHandler(this.timerGiris_Tick);
            // 
            // btnSqlBaglan
            // 
            this.btnSqlBaglan.ForeColor = System.Drawing.Color.Black;
            this.btnSqlBaglan.Location = new System.Drawing.Point(45, 82);
            this.btnSqlBaglan.Name = "btnSqlBaglan";
            this.btnSqlBaglan.Size = new System.Drawing.Size(97, 33);
            this.btnSqlBaglan.TabIndex = 9;
            this.btnSqlBaglan.Text = "Bağlan";
            this.btnSqlBaglan.UseVisualStyleBackColor = true;
            this.btnSqlBaglan.Click += new System.EventHandler(this.btnSqlBaglan_Click);
            // 
            // txtSqlip
            // 
            this.txtSqlip.Location = new System.Drawing.Point(18, 53);
            this.txtSqlip.Name = "txtSqlip";
            this.txtSqlip.Size = new System.Drawing.Size(134, 23);
            this.txtSqlip.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSqlip);
            this.groupBox1.Controls.Add(this.btnSqlBaglan);
            this.groupBox1.Location = new System.Drawing.Point(610, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 128);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sql Server Giriş";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sql IP Adresi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.labelBaslik);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpBoxGirisEkrani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.grpBoxGirisEkrani.ResumeLayout(false);
            this.grpBoxGirisEkrani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxGirisEkrani;
        private System.Windows.Forms.Label labelSifreUnuttum;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label labelBaslik;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.Timer timerGiris;
        private System.Windows.Forms.Button btnSqlBaglan;
        private System.Windows.Forms.TextBox txtSqlip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

