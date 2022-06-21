
namespace Restoran
{
    partial class FormKategoriDuzenle
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
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kategori_aciklama_rtb = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kategori_id_txt = new System.Windows.Forms.TextBox();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.btnKategoriDuzenle = new System.Windows.Forms.Button();
            this.kategori_adi_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kategori_duzenle_panel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.kategori_duzenle_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Restoran.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(650, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 104);
            this.btnExit.TabIndex = 28;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kategori_aciklama_rtb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.kategori_id_txt);
            this.groupBox1.Controls.Add(this.btnKategoriEkle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnKategoriSil);
            this.groupBox1.Controls.Add(this.btnKategoriDuzenle);
            this.groupBox1.Controls.Add(this.kategori_adi_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 315);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Bilgileri";
            // 
            // kategori_aciklama_rtb
            // 
            this.kategori_aciklama_rtb.Location = new System.Drawing.Point(402, 103);
            this.kategori_aciklama_rtb.Name = "kategori_aciklama_rtb";
            this.kategori_aciklama_rtb.Size = new System.Drawing.Size(280, 155);
            this.kategori_aciklama_rtb.TabIndex = 22;
            this.kategori_aciklama_rtb.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(402, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Kategori Açıklama";
            // 
            // kategori_id_txt
            // 
            this.kategori_id_txt.Location = new System.Drawing.Point(255, 103);
            this.kategori_id_txt.Name = "kategori_id_txt";
            this.kategori_id_txt.Size = new System.Drawing.Size(100, 25);
            this.kategori_id_txt.TabIndex = 19;
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.BackColor = System.Drawing.Color.Green;
            this.btnKategoriEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKategoriEkle.Location = new System.Drawing.Point(270, 161);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(95, 70);
            this.btnKategoriEkle.TabIndex = 10;
            this.btnKategoriEkle.Text = "Yeni Kategori Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = false;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(255, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Kategori Id\'si";
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.BackColor = System.Drawing.Color.Red;
            this.btnKategoriSil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKategoriSil.Location = new System.Drawing.Point(149, 161);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(95, 70);
            this.btnKategoriSil.TabIndex = 9;
            this.btnKategoriSil.Text = "Kategori Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = false;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // btnKategoriDuzenle
            // 
            this.btnKategoriDuzenle.BackColor = System.Drawing.Color.Yellow;
            this.btnKategoriDuzenle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKategoriDuzenle.Location = new System.Drawing.Point(28, 161);
            this.btnKategoriDuzenle.Name = "btnKategoriDuzenle";
            this.btnKategoriDuzenle.Size = new System.Drawing.Size(95, 70);
            this.btnKategoriDuzenle.TabIndex = 8;
            this.btnKategoriDuzenle.Text = "Kategori Düzenle";
            this.btnKategoriDuzenle.UseVisualStyleBackColor = false;
            this.btnKategoriDuzenle.Click += new System.EventHandler(this.btnKategoriDuzenle_Click);
            // 
            // kategori_adi_txt
            // 
            this.kategori_adi_txt.Location = new System.Drawing.Point(28, 103);
            this.kategori_adi_txt.Name = "kategori_adi_txt";
            this.kategori_adi_txt.Size = new System.Drawing.Size(210, 25);
            this.kategori_adi_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "Kategori Düzenle";
            // 
            // kategori_duzenle_panel
            // 
            this.kategori_duzenle_panel.Controls.Add(this.label1);
            this.kategori_duzenle_panel.Controls.Add(this.btnExit);
            this.kategori_duzenle_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kategori_duzenle_panel.Location = new System.Drawing.Point(0, 0);
            this.kategori_duzenle_panel.Name = "kategori_duzenle_panel";
            this.kategori_duzenle_panel.Size = new System.Drawing.Size(850, 104);
            this.kategori_duzenle_panel.TabIndex = 28;
            // 
            // FormKategoriDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 460);
            this.Controls.Add(this.kategori_duzenle_panel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKategoriDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKategoriDuzenle";
            this.Load += new System.EventHandler(this.FormKategoriDuzenle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.kategori_duzenle_panel.ResumeLayout(false);
            this.kategori_duzenle_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox kategori_aciklama_rtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kategori_id_txt;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.Button btnKategoriDuzenle;
        private System.Windows.Forms.TextBox kategori_adi_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel kategori_duzenle_panel;
    }
}