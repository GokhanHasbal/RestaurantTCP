namespace Restoran
{
    partial class FormSifremiUnuttum
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
            this.txtSifreUnuttum = new System.Windows.Forms.TextBox();
            this.labelKullanici = new System.Windows.Forms.Label();
            this.labelSifreUnuttum = new System.Windows.Forms.Label();
            this.btnSifreUnuttum = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSifreUnuttum
            // 
            this.txtSifreUnuttum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSifreUnuttum.Location = new System.Drawing.Point(27, 74);
            this.txtSifreUnuttum.Name = "txtSifreUnuttum";
            this.txtSifreUnuttum.Size = new System.Drawing.Size(190, 32);
            this.txtSifreUnuttum.TabIndex = 0;
            // 
            // labelKullanici
            // 
            this.labelKullanici.AutoSize = true;
            this.labelKullanici.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKullanici.Location = new System.Drawing.Point(27, 34);
            this.labelKullanici.Name = "labelKullanici";
            this.labelKullanici.Size = new System.Drawing.Size(117, 25);
            this.labelKullanici.TabIndex = 1;
            this.labelKullanici.Text = "Kullanıcı Adı";
            // 
            // labelSifreUnuttum
            // 
            this.labelSifreUnuttum.AutoSize = true;
            this.labelSifreUnuttum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSifreUnuttum.Location = new System.Drawing.Point(239, 77);
            this.labelSifreUnuttum.Name = "labelSifreUnuttum";
            this.labelSifreUnuttum.Size = new System.Drawing.Size(0, 25);
            this.labelSifreUnuttum.TabIndex = 2;
            // 
            // btnSifreUnuttum
            // 
            this.btnSifreUnuttum.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSifreUnuttum.Location = new System.Drawing.Point(27, 130);
            this.btnSifreUnuttum.Name = "btnSifreUnuttum";
            this.btnSifreUnuttum.Size = new System.Drawing.Size(190, 45);
            this.btnSifreUnuttum.TabIndex = 3;
            this.btnSifreUnuttum.Text = "İpucu Göster";
            this.btnSifreUnuttum.UseVisualStyleBackColor = true;
            this.btnSifreUnuttum.Click += new System.EventHandler(this.btnSifreUnuttum_Click);
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.Controls.Add(this.btnExit);
            this.panel.Controls.Add(this.labelKullanici);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(306, 218);
            this.panel.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Restoran.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Location = new System.Drawing.Point(276, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(306, 228);
            this.Controls.Add(this.btnSifreUnuttum);
            this.Controls.Add(this.labelSifreUnuttum);
            this.Controls.Add(this.txtSifreUnuttum);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSifremiUnuttum";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSifremiUnuttum";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifreUnuttum;
        private System.Windows.Forms.Label labelKullanici;
        private System.Windows.Forms.Label labelSifreUnuttum;
        private System.Windows.Forms.Button btnSifreUnuttum;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnExit;
    }
}