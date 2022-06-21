
namespace Restoran
{
    partial class FormMutfak
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
            this.lblGirisYapan = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpbxGelenSiparisler = new System.Windows.Forms.GroupBox();
            this.panelGelenSiparis = new System.Windows.Forms.Panel();
            this.dgvGelenSiparis = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelipAdres = new System.Windows.Forms.Label();
            this.durumPanel = new System.Windows.Forms.Panel();
            this.grpbxGelenSiparisler.SuspendLayout();
            this.panelGelenSiparis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGelenSiparis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(827, 16);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblGirisYapan
            // 
            this.lblGirisYapan.AutoSize = true;
            this.lblGirisYapan.Location = new System.Drawing.Point(769, 20);
            this.lblGirisYapan.Name = "lblGirisYapan";
            this.lblGirisYapan.Size = new System.Drawing.Size(52, 15);
            this.lblGirisYapan.TabIndex = 6;
            this.lblGirisYapan.Text = "Kullanıcı";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Restoran.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Location = new System.Drawing.Point(923, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpbxGelenSiparisler
            // 
            this.grpbxGelenSiparisler.AutoSize = true;
            this.grpbxGelenSiparisler.Controls.Add(this.panelGelenSiparis);
            this.grpbxGelenSiparisler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpbxGelenSiparisler.Location = new System.Drawing.Point(27, 72);
            this.grpbxGelenSiparisler.Name = "grpbxGelenSiparisler";
            this.grpbxGelenSiparisler.Size = new System.Drawing.Size(395, 447);
            this.grpbxGelenSiparisler.TabIndex = 8;
            this.grpbxGelenSiparisler.TabStop = false;
            this.grpbxGelenSiparisler.Text = "Gelen Siparişler";
            // 
            // panelGelenSiparis
            // 
            this.panelGelenSiparis.AutoSize = true;
            this.panelGelenSiparis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelGelenSiparis.Controls.Add(this.dgvGelenSiparis);
            this.panelGelenSiparis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGelenSiparis.Location = new System.Drawing.Point(3, 25);
            this.panelGelenSiparis.Name = "panelGelenSiparis";
            this.panelGelenSiparis.Size = new System.Drawing.Size(389, 419);
            this.panelGelenSiparis.TabIndex = 0;
            // 
            // dgvGelenSiparis
            // 
            this.dgvGelenSiparis.AllowUserToAddRows = false;
            this.dgvGelenSiparis.AllowUserToDeleteRows = false;
            this.dgvGelenSiparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGelenSiparis.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGelenSiparis.ColumnHeadersHeight = 40;
            this.dgvGelenSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGelenSiparis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGelenSiparis.Location = new System.Drawing.Point(0, 0);
            this.dgvGelenSiparis.Name = "dgvGelenSiparis";
            this.dgvGelenSiparis.ReadOnly = true;
            this.dgvGelenSiparis.RowTemplate.Height = 25;
            this.dgvGelenSiparis.Size = new System.Drawing.Size(389, 419);
            this.dgvGelenSiparis.TabIndex = 0;
            this.dgvGelenSiparis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGelenSiparis_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP Adresi:";
            // 
            // labelipAdres
            // 
            this.labelipAdres.AutoSize = true;
            this.labelipAdres.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelipAdres.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelipAdres.Location = new System.Drawing.Point(154, 27);
            this.labelipAdres.Name = "labelipAdres";
            this.labelipAdres.Size = new System.Drawing.Size(59, 25);
            this.labelipAdres.TabIndex = 12;
            this.labelipAdres.Text = "- - - -";
            // 
            // durumPanel
            // 
            this.durumPanel.AutoSize = true;
            this.durumPanel.Location = new System.Drawing.Point(900, 85);
            this.durumPanel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.durumPanel.Name = "durumPanel";
            this.durumPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.durumPanel.Size = new System.Drawing.Size(223, 572);
            this.durumPanel.TabIndex = 13;
            // 
            // FormMutfak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.durumPanel);
            this.Controls.Add(this.labelipAdres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpbxGelenSiparisler);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblGirisYapan);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMutfak";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Text = "FormMutfak";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMutfak_FormClosed);
            this.Load += new System.EventHandler(this.FormMutfak_Load);
            this.grpbxGelenSiparisler.ResumeLayout(false);
            this.grpbxGelenSiparisler.PerformLayout();
            this.panelGelenSiparis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGelenSiparis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblGirisYapan;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpbxGelenSiparisler;
        private System.Windows.Forms.Panel panelGelenSiparis;
        private System.Windows.Forms.DataGridView dgvGelenSiparis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelipAdres;
        private System.Windows.Forms.Panel durumPanel;
    }
}