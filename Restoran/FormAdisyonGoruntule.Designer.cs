namespace Restoran
{
    partial class FormAdisyonGoruntule
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
            this.adisyon_detay_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.adisyon_detay_dgv = new System.Windows.Forms.DataGridView();
            this.adisyon_detay_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adisyon_detay_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // adisyon_detay_panel
            // 
            this.adisyon_detay_panel.Controls.Add(this.label1);
            this.adisyon_detay_panel.Controls.Add(this.btnExit);
            this.adisyon_detay_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.adisyon_detay_panel.Location = new System.Drawing.Point(0, 0);
            this.adisyon_detay_panel.Name = "adisyon_detay_panel";
            this.adisyon_detay_panel.Size = new System.Drawing.Size(800, 100);
            this.adisyon_detay_panel.TabIndex = 20;
            this.adisyon_detay_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.adisyon_detay_panel_MouseDown);
            this.adisyon_detay_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.adisyon_detay_panel_MouseMove);
            this.adisyon_detay_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.adisyon_detay_panel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adisyon Detay";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Restoran.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(600, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 100);
            this.btnExit.TabIndex = 18;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // adisyon_detay_dgv
            // 
            this.adisyon_detay_dgv.AllowUserToAddRows = false;
            this.adisyon_detay_dgv.AllowUserToDeleteRows = false;
            this.adisyon_detay_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adisyon_detay_dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.adisyon_detay_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adisyon_detay_dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adisyon_detay_dgv.Location = new System.Drawing.Point(0, 166);
            this.adisyon_detay_dgv.Name = "adisyon_detay_dgv";
            this.adisyon_detay_dgv.ReadOnly = true;
            this.adisyon_detay_dgv.RowTemplate.Height = 25;
            this.adisyon_detay_dgv.Size = new System.Drawing.Size(800, 284);
            this.adisyon_detay_dgv.TabIndex = 21;
            // 
            // FormAdisyonGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adisyon_detay_dgv);
            this.Controls.Add(this.adisyon_detay_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdisyonGoruntule";
            this.Text = "FormAdisyonGoruntule";
            this.Load += new System.EventHandler(this.FormAdisyonGoruntule_Load);
            this.adisyon_detay_panel.ResumeLayout(false);
            this.adisyon_detay_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adisyon_detay_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adisyon_detay_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView adisyon_detay_dgv;
    }
}