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
    public partial class FormPersonelEkle : Form
    {
        public FormPersonelEkle()
        {
            InitializeComponent();
        }
        private void FormPersonelEkle_Load(object sender, EventArgs e)
        {
            personel_ekle_panel.Size = new Size(this.Width, this.Height * 20 / 100);
            groupBox1.Size = new Size(this.Width, this.Height  / 100 * 80);

            YetkiDoldur();
            personel_yetki_id_cb.SelectedIndex = -1;
        }
        public void YetkiDoldur()
        {
            personel_yetki_id_cb.Items.Clear();

            Garson.db.Open();

            DataTable tablo = new DataTable("Yetki");

            string sorgu = "select * from Yetki ";
            SqlCommand yetkigetir = new SqlCommand(sorgu, Garson.db);
            SqlDataReader yetkioku = yetkigetir.ExecuteReader();

            tablo.Load(yetkioku);
            personel_yetki_id_cb.DataSource = tablo;

            personel_yetki_id_cb.DisplayMember = "Yetki";
            personel_yetki_id_cb.ValueMember = "Id";


            Garson.db.Close();
        }
        public void TextSifirla()
        {
            personel_adi_txt.Clear();
            personel_soyadi_txt.Clear();
            personel_kullaniciadi_txt.Clear();
            personel_sifre_txt.Clear();
            personel_adi_txt.Focus();
            personel_yetki_id_cb.SelectedIndex = -1;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void PersonelEkleSorgu()
        {
            string personel_adi = personel_adi_txt.Text;
            string personel_soyadi = personel_soyadi_txt.Text;
            string personel_kullaniciadi = personel_kullaniciadi_txt.Text;
            string personel_sifre = personel_sifre_txt.Text;
            int personel_yetki_id = Convert.ToInt32(personel_yetki_id_cb.SelectedValue);
            Garson.db.Open();
            string sorgu = "insert into Personel (Ad, SoyAd, KullaniciAdi, Sifre, YetkiId) values ('" + personel_adi + "', '" + personel_soyadi + "', '" + personel_kullaniciadi + "', '" + personel_sifre + "', " + personel_yetki_id + ")";
            SqlCommand personelekle = new SqlCommand(sorgu, Garson.db);
            personelekle.ExecuteNonQuery();
            MessageBox.Show("Personel Ekleme Başarılı.");
            Garson.db.Close();

        }
           private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            string personel_adi = personel_adi_txt.Text;
            string personel_soyadi = personel_soyadi_txt.Text;
            string personel_kullaniciadi = personel_kullaniciadi_txt.Text;
            string personel_sifre = personel_sifre_txt.Text;
            int personel_yetki_id = Convert.ToInt32(personel_yetki_id_cb.SelectedValue);

            if (personel_adi != "" && personel_soyadi != "" && personel_kullaniciadi != "" && personel_sifre != "" && personel_yetki_id != -1)
            {
                PersonelEkleSorgu();
                TextSifirla();
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tekrar Deneyiniz.");
            }
        }
    }
}
