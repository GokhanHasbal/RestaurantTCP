
namespace Restoran
{
    partial class FormMudur
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
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.mudur_tab_control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.personel_dgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.urunler_dgv = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.masalar_dgv = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.kategori_dgv = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.adisyon_dgv = new System.Windows.Forms.DataGridView();
            this.mudur_head_panel = new System.Windows.Forms.Panel();
            this.btnYenile = new System.Windows.Forms.Button();
            this.giris_yapan_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mudur_tab_control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personel_dgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunler_dgv)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masalar_dgv)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategori_dgv)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adisyon_dgv)).BeginInit();
            this.mudur_head_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCikis.Location = new System.Drawing.Point(804, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(200, 153);
            this.btnCikis.TabIndex = 14;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Restoran.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(604, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 153);
            this.btnExit.TabIndex = 12;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mudur_tab_control
            // 
            this.mudur_tab_control.Controls.Add(this.tabPage1);
            this.mudur_tab_control.Controls.Add(this.tabPage2);
            this.mudur_tab_control.Controls.Add(this.tabPage3);
            this.mudur_tab_control.Controls.Add(this.tabPage5);
            this.mudur_tab_control.Controls.Add(this.tabPage4);
            this.mudur_tab_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mudur_tab_control.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mudur_tab_control.Location = new System.Drawing.Point(0, 171);
            this.mudur_tab_control.Name = "mudur_tab_control";
            this.mudur_tab_control.SelectedIndex = 0;
            this.mudur_tab_control.Size = new System.Drawing.Size(1004, 457);
            this.mudur_tab_control.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.personel_dgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(996, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // personel_dgv
            // 
            this.personel_dgv.AllowUserToAddRows = false;
            this.personel_dgv.AllowUserToDeleteRows = false;
            this.personel_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personel_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.personel_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personel_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personel_dgv.Location = new System.Drawing.Point(3, 3);
            this.personel_dgv.Name = "personel_dgv";
            this.personel_dgv.ReadOnly = true;
            this.personel_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.personel_dgv.RowTemplate.Height = 25;
            this.personel_dgv.Size = new System.Drawing.Size(990, 413);
            this.personel_dgv.TabIndex = 0;
            this.personel_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personel_dgv_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.urunler_dgv);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(996, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürünler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // urunler_dgv
            // 
            this.urunler_dgv.AllowUserToAddRows = false;
            this.urunler_dgv.AllowUserToDeleteRows = false;
            this.urunler_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.urunler_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.urunler_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunler_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urunler_dgv.Location = new System.Drawing.Point(3, 3);
            this.urunler_dgv.Name = "urunler_dgv";
            this.urunler_dgv.ReadOnly = true;
            this.urunler_dgv.RowTemplate.Height = 25;
            this.urunler_dgv.Size = new System.Drawing.Size(990, 413);
            this.urunler_dgv.TabIndex = 0;
            this.urunler_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.urunler_dgv_CellDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.masalar_dgv);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(996, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Masalar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // masalar_dgv
            // 
            this.masalar_dgv.AllowUserToAddRows = false;
            this.masalar_dgv.AllowUserToDeleteRows = false;
            this.masalar_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.masalar_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.masalar_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masalar_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masalar_dgv.Location = new System.Drawing.Point(3, 3);
            this.masalar_dgv.Name = "masalar_dgv";
            this.masalar_dgv.ReadOnly = true;
            this.masalar_dgv.RowTemplate.Height = 25;
            this.masalar_dgv.Size = new System.Drawing.Size(990, 413);
            this.masalar_dgv.TabIndex = 0;
            this.masalar_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.masalar_dgv_CellDoubleClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.kategori_dgv);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(996, 419);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Kategoriler";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // kategori_dgv
            // 
            this.kategori_dgv.AllowUserToAddRows = false;
            this.kategori_dgv.AllowUserToDeleteRows = false;
            this.kategori_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kategori_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.kategori_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kategori_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kategori_dgv.Location = new System.Drawing.Point(3, 3);
            this.kategori_dgv.Name = "kategori_dgv";
            this.kategori_dgv.ReadOnly = true;
            this.kategori_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.kategori_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.kategori_dgv.RowTemplate.Height = 25;
            this.kategori_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kategori_dgv.Size = new System.Drawing.Size(990, 413);
            this.kategori_dgv.TabIndex = 0;
            this.kategori_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kategori_dgv_CellDoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.adisyon_dgv);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(996, 419);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Adisyon";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // adisyon_dgv
            // 
            this.adisyon_dgv.AllowUserToAddRows = false;
            this.adisyon_dgv.AllowUserToDeleteRows = false;
            this.adisyon_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adisyon_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.adisyon_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adisyon_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adisyon_dgv.Location = new System.Drawing.Point(3, 3);
            this.adisyon_dgv.Name = "adisyon_dgv";
            this.adisyon_dgv.ReadOnly = true;
            this.adisyon_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.adisyon_dgv.RowTemplate.Height = 25;
            this.adisyon_dgv.Size = new System.Drawing.Size(990, 413);
            this.adisyon_dgv.TabIndex = 0;
            this.adisyon_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adisyon_dgv_CellDoubleClick);
            // 
            // mudur_head_panel
            // 
            this.mudur_head_panel.Controls.Add(this.btnYenile);
            this.mudur_head_panel.Controls.Add(this.giris_yapan_label);
            this.mudur_head_panel.Controls.Add(this.label1);
            this.mudur_head_panel.Controls.Add(this.btnExit);
            this.mudur_head_panel.Controls.Add(this.btnCikis);
            this.mudur_head_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mudur_head_panel.Location = new System.Drawing.Point(0, 0);
            this.mudur_head_panel.Name = "mudur_head_panel";
            this.mudur_head_panel.Size = new System.Drawing.Size(1004, 153);
            this.mudur_head_panel.TabIndex = 16;
            // 
            // btnYenile
            // 
            this.btnYenile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnYenile.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYenile.Location = new System.Drawing.Point(404, 0);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(200, 153);
            this.btnYenile.TabIndex = 17;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // giris_yapan_label
            // 
            this.giris_yapan_label.AutoSize = true;
            this.giris_yapan_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.giris_yapan_label.Location = new System.Drawing.Point(233, 21);
            this.giris_yapan_label.Name = "giris_yapan_label";
            this.giris_yapan_label.Size = new System.Drawing.Size(0, 37);
            this.giris_yapan_label.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Müdür Sistemi";
            // 
            // FormMudur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 628);
            this.Controls.Add(this.mudur_head_panel);
            this.Controls.Add(this.mudur_tab_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMudur";
            this.Text = "FormMudur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMudur_FormClosed);
            this.Load += new System.EventHandler(this.FormMudur_Load);
            this.mudur_tab_control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personel_dgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.urunler_dgv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masalar_dgv)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kategori_dgv)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adisyon_dgv)).EndInit();
            this.mudur_head_panel.ResumeLayout(false);
            this.mudur_head_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl mudur_tab_control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView personel_dgv;
        private System.Windows.Forms.DataGridView urunler_dgv;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView masalar_dgv;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView adisyon_dgv;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView kategori_dgv;
        private System.Windows.Forms.Panel mudur_head_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label giris_yapan_label;
        private System.Windows.Forms.Button btnYenile;
    }
}