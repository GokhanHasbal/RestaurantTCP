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
    public partial class FormUrunEkle : Form
    {
        public FormUrunEkle()
        {
            InitializeComponent();
        }
        public void KategoriDoldur()
        {
            urun_kategori_cb.Items.Clear();
            Garson.db.Open();
            DataTable tablo = new DataTable("Kategoriler");
            string sorgu = "select * from Kategoriler";
            SqlCommand kategorigetir = new SqlCommand(sorgu, Garson.db);
            SqlDataReader kategorioku = kategorigetir.ExecuteReader();
            tablo.Load(kategorioku);
            urun_kategori_cb.DataSource = tablo;
            urun_kategori_cb.DisplayMember = "Kategori";
            urun_kategori_cb.ValueMember = "Id";
            Garson.db.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void TextSifirla()
        {
            urun_adi_txt.Clear();
            urun_resim_txt.Clear();
            urun_aciklama_rtb.Clear();
            urun_kategori_cb.SelectedIndex = -1;
            urun_durum_cb.SelectedIndex = -1;
            urun_adi_txt.Focus();
        }
        private void FormUrunEkle_Load(object sender, EventArgs e)
        {
            urun_fiyat_num.DecimalPlaces=2;
            urun_fiyat_num.Increment = 0.1m;

            KategoriDoldur();
            urun_kategori_cb.SelectedIndex = -1;
            urun_durum_cb.SelectedIndex = -1;
            urun_ekle_panel.Size = new Size(this.Width, this.Height * 20 / 100);
            groupBox1.Size = new Size(this.Width, this.Height * 80 / 100);
        }
        public void UrunEkleSorgu()
        {
            string urun_adi = urun_adi_txt.Text;
            int urun_fiyat = Convert.ToInt32(urun_fiyat_num.Value);
            string urun_foto = urun_resim_txt.Text;
            string urun_aciklama = urun_aciklama_rtb.Text;
            int urun_kategori = Convert.ToInt32(urun_kategori_cb.SelectedValue);
            int urun_durum = Convert.ToInt32(urun_durum_cb.SelectedIndex);
            Form1 frm = new Form1();
            Garson.db.Open();
            string sorgu = "insert into Urunler (Ad, Aciklama, Resim, Fiyat, Durum, KategoriId) values ('" + urun_adi + "', '" + urun_aciklama + "', '" + urun_foto + "', " + urun_fiyat + ", " + urun_durum + ", " + urun_kategori + ")";
            SqlCommand urunekle = new SqlCommand(sorgu, Garson.db);
            urunekle.ExecuteNonQuery();
            MessageBox.Show("Ürün Ekleme Başarılı.");
            Garson.db.Close();
        }
        private void btnUrunlEkle_Click(object sender, EventArgs e)
        {
            string urun_adi = urun_adi_txt.Text;
            int urun_fiyat = Convert.ToInt32(urun_fiyat_num.Value);
            string urun_foto = urun_resim_txt.Text;
            string urun_aciklama = urun_aciklama_rtb.Text;
            int urun_kategori = Convert.ToInt32(urun_kategori_cb.SelectedValue);
            int urun_durum = Convert.ToInt32(urun_durum_cb.SelectedIndex);

            if (urun_adi != "" && urun_fiyat >0 && urun_foto != "" && urun_aciklama != "" && urun_kategori != -1 && urun_durum != -1)
            {
                UrunEkleSorgu();
                TextSifirla();
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tekrar Deneyiniz.");

            }
        }
    }
}
