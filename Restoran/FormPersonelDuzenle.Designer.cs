﻿namespace Restoran
{
    partial class FormPersonelDuzenle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.personel_yetki_id_cb = new System.Windows.Forms.ComboBox();
            this.personel_id_txt = new System.Windows.Forms.TextBox();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.btnPersonelDuzenle = new System.Windows.Forms.Button();
            this.personel_sifre_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.personel_kullaniciadi_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.personel_soyadi_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.personel_adi_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.personel_duzenle_panel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.personel_duzenle_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Düzenle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.personel_yetki_id_cb);
            this.groupBox1.Controls.Add(this.personel_id_txt);
            this.groupBox1.Controls.Add(this.btnPersonelEkle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnPersonelSil);
            this.groupBox1.Controls.Add(this.btnPersonelDuzenle);
            this.groupBox1.Controls.Add(this.personel_sifre_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.personel_kullaniciadi_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.personel_soyadi_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.personel_adi_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 281);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(173, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Personel Yetkisi";
            // 
            // personel_yetki_id_cb
            // 
            this.personel_yetki_id_cb.FormattingEnabled = true;
            this.personel_yetki_id_cb.Location = new System.Drawing.Point(178, 252);
            this.personel_yetki_id_cb.Name = "personel_yetki_id_cb";
            this.personel_yetki_id_cb.Size = new System.Drawing.Size(125, 25);
            this.personel_yetki_id_cb.TabIndex = 20;
            // 
            // personel_id_txt
            // 
            this.personel_id_txt.Location = new System.Drawing.Point(30, 255);
            this.personel_id_txt.Name = "personel_id_txt";
            this.personel_id_txt.Size = new System.Drawing.Size(125, 25);
            this.personel_id_txt.TabIndex = 19;
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.BackColor = System.Drawing.Color.Green;
            this.btnPersonelEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPersonelEkle.Location = new System.Drawing.Point(399, 190);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(95, 70);
            this.btnPersonelEkle.TabIndex = 10;
            this.btnPersonelEkle.Text = "Yeni Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = false;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(29, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Personel Id\'si";
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.BackColor = System.Drawing.Color.Red;
            this.btnPersonelSil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPersonelSil.Location = new System.Drawing.Point(454, 103);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(95, 70);
            this.btnPersonelSil.TabIndex = 9;
            this.btnPersonelSil.Text = "Personeli Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = false;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // btnPersonelDuzenle
            // 
            this.btnPersonelDuzenle.BackColor = System.Drawing.Color.Yellow;
            this.btnPersonelDuzenle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPersonelDuzenle.Location = new System.Drawing.Point(345, 103);
            this.btnPersonelDuzenle.Name = "btnPersonelDuzenle";
            this.btnPersonelDuzenle.Size = new System.Drawing.Size(95, 70);
            this.btnPersonelDuzenle.TabIndex = 8;
            this.btnPersonelDuzenle.Text = "Personel Düzenle";
            this.btnPersonelDuzenle.UseVisualStyleBackColor = false;
            this.btnPersonelDuzenle.Click += new System.EventHandler(this.btnPersonelDuzenle_Click);
            // 
            // personel_sifre_txt
            // 
            this.personel_sifre_txt.Location = new System.Drawing.Point(178, 179);
            this.personel_sifre_txt.Name = "personel_sifre_txt";
            this.personel_sifre_txt.Size = new System.Drawing.Size(125, 25);
            this.personel_sifre_txt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(177, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Şifresi";
            // 
            // personel_kullaniciadi_txt
            // 
            this.personel_kullaniciadi_txt.Location = new System.Drawing.Point(178, 103);
            this.personel_kullaniciadi_txt.Name = "personel_kullaniciadi_txt";
            this.personel_kullaniciadi_txt.Size = new System.Drawing.Size(125, 25);
            this.personel_kullaniciadi_txt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(177, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // personel_soyadi_txt
            // 
            this.personel_soyadi_txt.Location = new System.Drawing.Point(30, 179);
            this.personel_soyadi_txt.Name = "personel_soyadi_txt";
            this.personel_soyadi_txt.Size = new System.Drawing.Size(125, 25);
            this.personel_soyadi_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel Soyadı";
            // 
            // personel_adi_txt
            // 
            this.personel_adi_txt.Location = new System.Drawing.Point(30, 103);
            this.personel_adi_txt.Name = "personel_adi_txt";
            this.personel_adi_txt.Size = new System.Drawing.Size(125, 25);
            this.personel_adi_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Personel Adı";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Restoran.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(650, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 118);
            this.btnExit.TabIndex = 15;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // personel_duzenle_panel
            // 
            this.personel_duzenle_panel.Controls.Add(this.label1);
            this.personel_duzenle_panel.Controls.Add(this.btnExit);
            this.personel_duzenle_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.personel_duzenle_panel.Location = new System.Drawing.Point(0, 0);
            this.personel_duzenle_panel.Name = "personel_duzenle_panel";
            this.personel_duzenle_panel.Size = new System.Drawing.Size(850, 118);
            this.personel_duzenle_panel.TabIndex = 16;
            // 
            // FormPersonelDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 460);
            this.Controls.Add(this.personel_duzenle_panel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPersonelDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPersonelDuzenle";
            this.Load += new System.EventHandler(this.FormPersonelDuzenle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.personel_duzenle_panel.ResumeLayout(false);
            this.personel_duzenle_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.Button btnPersonelDuzenle;
        private System.Windows.Forms.TextBox personel_sifre_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox personel_kullaniciadi_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox personel_soyadi_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox personel_adi_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox personel_id_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox personel_yetki_id_cb;
        private System.Windows.Forms.Panel personel_duzenle_panel;
    }
}