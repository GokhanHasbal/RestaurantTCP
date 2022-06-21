using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restoran
{
    public partial class FormKategoriEkle : Form
    {
        public FormKategoriEkle()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            string kategori_adi = kategori_adi_txt.Text;
            string kategori_aciklama = kategori_aciklama_rtb.Text;
            if (kategori_adi != "" && kategori_aciklama != "")
            {
                KategoriEkleSorgu();
                TextSifirla();
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tekrar Deneyiniz.");
            }
        }
        public void TextSifirla()
        {
            kategori_adi_txt.Clear();
            kategori_aciklama_rtb.Clear();
            kategori_adi_txt.Focus();
        }
        private void FormKategoriEkle_Load(object sender, EventArgs e)
        {
            kategori_ekle_panel.Size = new Size(this.Width, this.Height*20/100);
            groupBox1.Size = new Size(this.Width, this.Height * 80 / 100);
        }
        public void KategoriEkleSorgu()
        {
            string kategori_adi = kategori_adi_txt.Text;
            string kategori_aciklama = kategori_aciklama_rtb.Text;
            Form1 frm = new Form1();
            Garson.db.Open();
            string sorgu = "insert into Kategoriler (Kategori, Aciklama) values ('" + kategori_adi + "',  '" + kategori_aciklama + "'  )";
            SqlCommand kategoriekle = new SqlCommand(sorgu, Garson.db);
            kategoriekle.ExecuteNonQuery();
            MessageBox.Show("Kategori Ekleme Başarılı.");
            Garson.db.Close();
        }
    }
}