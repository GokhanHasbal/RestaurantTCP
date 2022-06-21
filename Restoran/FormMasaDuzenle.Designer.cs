
namespace Restoran
{
    partial class FormMasaDuzenle
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
            this.label7 = new System.Windows.Forms.Label();
            this.masa_durum_cb = new System.Windows.Forms.ComboBox();
            this.masa_id_txt = new System.Windows.Forms.TextBox();
            this.btnMasaEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMasaSil = new System.Windows.Forms.Button();
            this.btnMasaDuzenle = new System.Windows.Forms.Button();
            this.masa_adi_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.masa_duzenle_panel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.masa_duzenle_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Restoran.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(650, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 100);
            this.btnExit.TabIndex = 23;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.masa_durum_cb);
            this.groupBox1.Controls.Add(this.masa_id_txt);
            this.groupBox1.Controls.Add(this.btnMasaEkle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnMasaSil);
            this.groupBox1.Controls.Add(this.btnMasaDuzenle);
            this.groupBox1.Controls.Add(this.masa_adi_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 282);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masa Bilgileri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(340, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Masa Durum";
            // 
            // masa_durum_cb
            // 
            this.masa_durum_cb.FormattingEnabled = true;
            this.masa_durum_cb.Items.AddRange(new object[] {
            "False",
            "True"});
            this.masa_durum_cb.Location = new System.Drawing.Point(340, 103);
            this.masa_durum_cb.Name = "masa_durum_cb";
            this.masa_durum_cb.Size = new System.Drawing.Size(125, 25);
            this.masa_durum_cb.TabIndex = 20;
            // 
            // masa_id_txt
            // 
            this.masa_id_txt.Location = new System.Drawing.Point(184, 103);
            this.masa_id_txt.Name = "masa_id_txt";
            this.masa_id_txt.Size = new System.Drawing.Size(125, 25);
            this.masa_id_txt.TabIndex = 19;
            // 
            // btnMasaEkle
            // 
            this.btnMasaEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMasaEkle.Location = new System.Drawing.Point(272, 161);
            this.btnMasaEkle.Name = "btnMasaEkle";
            this.btnMasaEkle.Size = new System.Drawing.Size(95, 70);
            this.btnMasaEkle.TabIndex = 10;
            this.btnMasaEkle.Text = "Yeni Masa Ekle";
            this.btnMasaEkle.UseVisualStyleBackColor = true;
            this.btnMasaEkle.Click += new System.EventHandler(this.btnMasaEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(184, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Masa Id\'si";
            // 
            // btnMasaSil
            // 
            this.btnMasaSil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMasaSil.Location = new System.Drawing.Point(150, 161);
            this.btnMasaSil.Name = "btnMasaSil";
            this.btnMasaSil.Size = new System.Drawing.Size(95, 70);
            this.btnMasaSil.TabIndex = 9;
            this.btnMasaSil.Text = "Masa Sil";
            this.btnMasaSil.UseVisualStyleBackColor = true;
            this.btnMasaSil.Click += new System.EventHandler(this.btnMasaSil_Click);
            // 
            // btnMasaDuzenle
            // 
            this.btnMasaDuzenle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMasaDuzenle.Location = new System.Drawing.Point(28, 161);
            this.btnMasaDuzenle.Name = "btnMasaDuzenle";
            this.btnMasaDuzenle.Size = new System.Drawing.Size(95, 70);
            this.btnMasaDuzenle.TabIndex = 8;
            this.btnMasaDuzenle.Text = "Masa Düzenle";
            this.btnMasaDuzenle.UseVisualStyleBackColor = true;
            this.btnMasaDuzenle.Click += new System.EventHandler(this.btnMasaDuzenle_Click);
            // 
            // masa_adi_txt
            // 
            this.masa_adi_txt.Location = new System.Drawing.Point(28, 103);
            this.masa_adi_txt.Name = "masa_adi_txt";
            this.masa_adi_txt.Size = new System.Drawing.Size(125, 25);
            this.masa_adi_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Masa Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Masa Düzenle";
            // 
            // masa_duzenle_panel
            // 
            this.masa_duzenle_panel.Controls.Add(this.label1);
            this.masa_duzenle_panel.Controls.Add(this.btnExit);
            this.masa_duzenle_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.masa_duzenle_panel.Location = new System.Drawing.Point(0, 0);
            this.masa_duzenle_panel.Name = "masa_duzenle_panel";
            this.masa_duzenle_panel.Size = new System.Drawing.Size(850, 100);
            this.masa_duzenle_panel.TabIndex = 24;
            // 
            // FormMasaDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 460);
            this.Controls.Add(this.masa_duzenle_panel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMasaDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMasaDuzenle";
            this.Load += new System.EventHandler(this.FormMasaDuzenle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.masa_duzenle_panel.ResumeLayout(false);
            this.masa_duzenle_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox masa_durum_cb;
        private System.Windows.Forms.TextBox masa_id_txt;
        private System.Windows.Forms.Button btnMasaEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMasaSil;
        private System.Windows.Forms.Button btnMasaDuzenle;
        private System.Windows.Forms.TextBox masa_adi_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel masa_duzenle_panel;
    }
}