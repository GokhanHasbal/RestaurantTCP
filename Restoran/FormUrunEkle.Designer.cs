
namespace Restoran
{
    partial class FormUrunEkle
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
            this.urun_fiyat_num = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.urun_aciklama_rtb = new System.Windows.Forms.RichTextBox();
            this.urun_resim_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.urun_kategori_cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.urun_durum_cb = new System.Windows.Forms.ComboBox();
            this.btnUrunlEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.urun_adi_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.urun_ekle_panel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urun_fiyat_num)).BeginInit();
            this.urun_ekle_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Ekle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.urun_fiyat_num);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.urun_aciklama_rtb);
            this.groupBox1.Controls.Add(this.urun_resim_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.urun_kategori_cb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.urun_durum_cb);
            this.groupBox1.Controls.Add(this.btnUrunlEkle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.urun_adi_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 315);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // urun_fiyat_num
            // 
            this.urun_fiyat_num.Location = new System.Drawing.Point(29, 252);
            this.urun_fiyat_num.Name = "urun_fiyat_num";
            this.urun_fiyat_num.Size = new System.Drawing.Size(120, 25);
            this.urun_fiyat_num.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(315, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Ürün Açıklama";
            // 
            // urun_aciklama_rtb
            // 
            this.urun_aciklama_rtb.Location = new System.Drawing.Point(315, 122);
            this.urun_aciklama_rtb.Name = "urun_aciklama_rtb";
            this.urun_aciklama_rtb.Size = new System.Drawing.Size(280, 155);
            this.urun_aciklama_rtb.TabIndex = 26;
            this.urun_aciklama_rtb.Text = "";
            // 
            // urun_resim_txt
            // 
            this.urun_resim_txt.Location = new System.Drawing.Point(29, 183);
            this.urun_resim_txt.Name = "urun_resim_txt";
            this.urun_resim_txt.Size = new System.Drawing.Size(125, 25);
            this.urun_resim_txt.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(28, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ürün Foto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(172, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ürün Kategori";
            // 
            // urun_kategori_cb
            // 
            this.urun_kategori_cb.FormattingEnabled = true;
            this.urun_kategori_cb.Location = new System.Drawing.Point(171, 179);
            this.urun_kategori_cb.Name = "urun_kategori_cb";
            this.urun_kategori_cb.Size = new System.Drawing.Size(125, 25);
            this.urun_kategori_cb.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(173, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ürün Durum";
            // 
            // urun_durum_cb
            // 
            this.urun_durum_cb.FormattingEnabled = true;
            this.urun_durum_cb.Items.AddRange(new object[] {
            "False",
            "True"});
            this.urun_durum_cb.Location = new System.Drawing.Point(172, 252);
            this.urun_durum_cb.Name = "urun_durum_cb";
            this.urun_durum_cb.Size = new System.Drawing.Size(125, 25);
            this.urun_durum_cb.TabIndex = 20;
            // 
            // btnUrunlEkle
            // 
            this.btnUrunlEkle.BackColor = System.Drawing.Color.Green;
            this.btnUrunlEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUrunlEkle.Location = new System.Drawing.Point(634, 183);
            this.btnUrunlEkle.Name = "btnUrunlEkle";
            this.btnUrunlEkle.Size = new System.Drawing.Size(95, 70);
            this.btnUrunlEkle.TabIndex = 10;
            this.btnUrunlEkle.Text = "Ürün Ekle";
            this.btnUrunlEkle.UseVisualStyleBackColor = false;
            this.btnUrunlEkle.Click += new System.EventHandler(this.btnUrunlEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ürün Fiyat";
            // 
            // urun_adi_txt
            // 
            this.urun_adi_txt.Location = new System.Drawing.Point(29, 103);
            this.urun_adi_txt.Name = "urun_adi_txt";
            this.urun_adi_txt.Size = new System.Drawing.Size(125, 25);
            this.urun_adi_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Restoran.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(650, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 76);
            this.btnExit.TabIndex = 21;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // urun_ekle_panel
            // 
            this.urun_ekle_panel.Controls.Add(this.label1);
            this.urun_ekle_panel.Controls.Add(this.btnExit);
            this.urun_ekle_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.urun_ekle_panel.Location = new System.Drawing.Point(0, 0);
            this.urun_ekle_panel.Name = "urun_ekle_panel";
            this.urun_ekle_panel.Size = new System.Drawing.Size(850, 76);
            this.urun_ekle_panel.TabIndex = 22;
            // 
            // FormUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 460);
            this.Controls.Add(this.urun_ekle_panel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUrunEkle";
            this.Load += new System.EventHandler(this.FormUrunEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urun_fiyat_num)).EndInit();
            this.urun_ekle_panel.ResumeLayout(false);
            this.urun_ekle_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox urun_aciklama_rtb;
        private System.Windows.Forms.TextBox urun_resim_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox urun_kategori_cb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox urun_durum_cb;
        private System.Windows.Forms.Button btnUrunlEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox urun_adi_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel urun_ekle_panel;
        private System.Windows.Forms.NumericUpDown urun_fiyat_num;
    }
}