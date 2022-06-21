
namespace Restoran
{
    partial class SiparisForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.siparis_dgv = new System.Windows.Forms.DataGridView();
            this.yemekler_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.kategori_fpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.kapat_btn = new System.Windows.Forms.Button();
            this.alt_btn_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.sip_sil_btn = new ReaLTaiizor.Controls.HopeButton();
            this.sip_temiz_btn = new ReaLTaiizor.Controls.HopeButton();
            this.hopeButton1 = new ReaLTaiizor.Controls.HopeButton();
            this.masa_panel = new System.Windows.Forms.Panel();
            this.masa_lbl = new ReaLTaiizor.Controls.BigLabel();
            this.adet_lbl = new ReaLTaiizor.Controls.BigLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c_btn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siparis_dgv)).BeginInit();
            this.alt_btn_panel.SuspendLayout();
            this.masa_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.siparis_dgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(784, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 614);
            this.panel2.TabIndex = 2;
            // 
            // siparis_dgv
            // 
            this.siparis_dgv.AllowUserToAddRows = false;
            this.siparis_dgv.AllowUserToDeleteRows = false;
            this.siparis_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.siparis_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.siparis_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siparis_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siparis_dgv.Location = new System.Drawing.Point(0, 0);
            this.siparis_dgv.Name = "siparis_dgv";
            this.siparis_dgv.ReadOnly = true;
            this.siparis_dgv.RowTemplate.Height = 25;
            this.siparis_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.siparis_dgv.Size = new System.Drawing.Size(543, 614);
            this.siparis_dgv.TabIndex = 0;
            this.siparis_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.siparis_dgv_CellClick);
            // 
            // yemekler_panel
            // 
            this.yemekler_panel.BackColor = System.Drawing.Color.Linen;
            this.yemekler_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.yemekler_panel.Location = new System.Drawing.Point(143, 68);
            this.yemekler_panel.Name = "yemekler_panel";
            this.yemekler_panel.Size = new System.Drawing.Size(568, 614);
            this.yemekler_panel.TabIndex = 7;
            // 
            // kategori_fpanel
            // 
            this.kategori_fpanel.BackColor = System.Drawing.Color.Beige;
            this.kategori_fpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.kategori_fpanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.kategori_fpanel.Location = new System.Drawing.Point(0, 68);
            this.kategori_fpanel.Name = "kategori_fpanel";
            this.kategori_fpanel.Size = new System.Drawing.Size(143, 614);
            this.kategori_fpanel.TabIndex = 0;
            // 
            // kapat_btn
            // 
            this.kapat_btn.BackColor = System.Drawing.Color.Tomato;
            this.kapat_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kapat_btn.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kapat_btn.Location = new System.Drawing.Point(1198, 3);
            this.kapat_btn.Name = "kapat_btn";
            this.kapat_btn.Size = new System.Drawing.Size(126, 86);
            this.kapat_btn.TabIndex = 10;
            this.kapat_btn.Text = "X";
            this.kapat_btn.UseVisualStyleBackColor = false;
            this.kapat_btn.Click += new System.EventHandler(this.kapat_btn_Click);
            // 
            // alt_btn_panel
            // 
            this.alt_btn_panel.AutoSize = true;
            this.alt_btn_panel.BackColor = System.Drawing.Color.DarkKhaki;
            this.alt_btn_panel.Controls.Add(this.kapat_btn);
            this.alt_btn_panel.Controls.Add(this.sip_sil_btn);
            this.alt_btn_panel.Controls.Add(this.sip_temiz_btn);
            this.alt_btn_panel.Controls.Add(this.hopeButton1);
            this.alt_btn_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.alt_btn_panel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.alt_btn_panel.Location = new System.Drawing.Point(0, 682);
            this.alt_btn_panel.Name = "alt_btn_panel";
            this.alt_btn_panel.Size = new System.Drawing.Size(1327, 92);
            this.alt_btn_panel.TabIndex = 15;
            // 
            // sip_sil_btn
            // 
            this.sip_sil_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.sip_sil_btn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.sip_sil_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sip_sil_btn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.sip_sil_btn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sip_sil_btn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sip_sil_btn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.sip_sil_btn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.sip_sil_btn.Location = new System.Drawing.Point(1066, 3);
            this.sip_sil_btn.Name = "sip_sil_btn";
            this.sip_sil_btn.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.sip_sil_btn.Size = new System.Drawing.Size(126, 86);
            this.sip_sil_btn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.sip_sil_btn.TabIndex = 11;
            this.sip_sil_btn.Text = "Siparişi Sil";
            this.sip_sil_btn.TextColor = System.Drawing.Color.White;
            this.sip_sil_btn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.sip_sil_btn.Click += new System.EventHandler(this.sip_sil_btn_Click);
            // 
            // sip_temiz_btn
            // 
            this.sip_temiz_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.sip_temiz_btn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.sip_temiz_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sip_temiz_btn.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.sip_temiz_btn.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sip_temiz_btn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sip_temiz_btn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.sip_temiz_btn.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.sip_temiz_btn.Location = new System.Drawing.Point(934, 3);
            this.sip_temiz_btn.Name = "sip_temiz_btn";
            this.sip_temiz_btn.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sip_temiz_btn.Size = new System.Drawing.Size(126, 86);
            this.sip_temiz_btn.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.sip_temiz_btn.TabIndex = 12;
            this.sip_temiz_btn.Text = "Siparişi Temizle";
            this.sip_temiz_btn.TextColor = System.Drawing.Color.White;
            this.sip_temiz_btn.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.sip_temiz_btn.Click += new System.EventHandler(this.sip_temiz_btn_Click);
            // 
            // hopeButton1
            // 
            this.hopeButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeButton1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.hopeButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeButton1.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeButton1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeButton1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hopeButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeButton1.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeButton1.Location = new System.Drawing.Point(802, 3);
            this.hopeButton1.Name = "hopeButton1";
            this.hopeButton1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButton1.Size = new System.Drawing.Size(126, 86);
            this.hopeButton1.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.hopeButton1.TabIndex = 13;
            this.hopeButton1.Text = "Siparişi Gönder";
            this.hopeButton1.TextColor = System.Drawing.Color.White;
            this.hopeButton1.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.hopeButton1.Click += new System.EventHandler(this.hopeButton1_Click);
            // 
            // masa_panel
            // 
            this.masa_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.masa_panel.Controls.Add(this.masa_lbl);
            this.masa_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.masa_panel.Location = new System.Drawing.Point(0, 0);
            this.masa_panel.Name = "masa_panel";
            this.masa_panel.Size = new System.Drawing.Size(1327, 68);
            this.masa_panel.TabIndex = 17;
            // 
            // masa_lbl
            // 
            this.masa_lbl.AutoSize = true;
            this.masa_lbl.BackColor = System.Drawing.Color.Transparent;
            this.masa_lbl.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.masa_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.masa_lbl.Location = new System.Drawing.Point(12, 9);
            this.masa_lbl.Name = "masa_lbl";
            this.masa_lbl.Size = new System.Drawing.Size(99, 46);
            this.masa_lbl.TabIndex = 0;
            this.masa_lbl.Text = "Label";
            // 
            // adet_lbl
            // 
            this.adet_lbl.BackColor = System.Drawing.Color.DarkSalmon;
            this.adet_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.adet_lbl.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adet_lbl.ForeColor = System.Drawing.Color.White;
            this.adet_lbl.Location = new System.Drawing.Point(0, 0);
            this.adet_lbl.Name = "adet_lbl";
            this.adet_lbl.Size = new System.Drawing.Size(73, 41);
            this.adet_lbl.TabIndex = 0;
            this.adet_lbl.Text = "1";
            this.adet_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orchid;
            this.panel1.Controls.Add(this.c_btn);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.adet_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(711, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 614);
            this.panel1.TabIndex = 18;
            // 
            // c_btn
            // 
            this.c_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.c_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.c_btn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.c_btn.Location = new System.Drawing.Point(0, 42);
            this.c_btn.Margin = new System.Windows.Forms.Padding(0);
            this.c_btn.Name = "c_btn";
            this.c_btn.Size = new System.Drawing.Size(73, 59);
            this.c_btn.TabIndex = 19;
            this.c_btn.Text = "C";
            this.c_btn.UseVisualStyleBackColor = true;
            this.c_btn.Click += new System.EventHandler(this.c_btn_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Location = new System.Drawing.Point(0, 101);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 57);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(0, 158);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(73, 57);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(0, 215);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 57);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(0, 272);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 57);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(0, 329);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 57);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(0, 386);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 57);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(0, 443);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 57);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(0, 500);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 557);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1327, 774);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.yemekler_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.kategori_fpanel);
            this.Controls.Add(this.masa_panel);
            this.Controls.Add(this.alt_btn_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SiparisForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiparisForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siparis_dgv)).EndInit();
            this.alt_btn_panel.ResumeLayout(false);
            this.masa_panel.ResumeLayout(false);
            this.masa_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ürün_iptal_btn;
        private System.Windows.Forms.FlowLayoutPanel yemekler_panel;
        private System.Windows.Forms.Button kapat_btn;
        private System.Windows.Forms.FlowLayoutPanel kategori_fpanel;
        private System.Windows.Forms.FlowLayoutPanel alt_btn_panel;
        private System.Windows.Forms.Panel masa_panel;
        private ReaLTaiizor.Controls.BigLabel adet_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button c_btn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView siparis_dgv;
        private ReaLTaiizor.Controls.HopeButton sip_sil_btn;
        private ReaLTaiizor.Controls.HopeButton sip_temiz_btn;
        private ReaLTaiizor.Controls.HopeButton hopeButton1;
        private ReaLTaiizor.Controls.BigLabel masa_lbl;
    }
}