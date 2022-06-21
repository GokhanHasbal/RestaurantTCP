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
    public partial class FormPersonelDuzenle : Form
    {
        public int personel_id = 0;
        public string personel_adi = "";
        public string mudurKullanici = "";

        public FormPersonelDuzenle()
        {
            InitializeComponent();
        }
        private void FormPersonelDuzenle_Load(object sender, EventArgs e)
        {
            personel_id_txt.Enabled = false;
            personel_duzenle_panel.Size = new Size(this.Width, this.Height * 20 / 100);
            groupBox1.Size = new Size(this.Width, this.Height * 80 / 100);
            personel_yetki_id_cb.SelectedIndex = -1;
            YetkiDoldur();
            PersonelGetir(personel_id);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPersonelDuzenle_Click(object sender, EventArgs e)
        {
            PersonelDuzenleSorgu();
            PersonelGetir(personel_id);
        }
        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            string personel_adi = personel_adi_txt.Text;
            DialogResult silkontrol = new DialogResult();
            silkontrol = MessageBox.Show(personel_adi + " Adlı Personel Silinsin mi?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (silkontrol == DialogResult.Yes)
            {
                PersonelSilSorgu();
            }
            else
            {
                MessageBox.Show("Personel Silme İptal");
            }
        }
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            FormPersonelEkle fpe = new FormPersonelEkle();
            fpe.ShowDialog();
        }
        public void PersonelGetir (int personel_id)
        {
            Garson.db.Open();
            string sorgu = "Select * from Personel where Id='"+personel_id+"'";
            SqlCommand pg = new SqlCommand(sorgu, Garson.db);
            SqlDataReader personeloku = pg.ExecuteReader();
            if (personeloku.Read())
            {
                personel_adi_txt.Text = personeloku["Ad"].ToString();
                personel_soyadi_txt.Text = personeloku["Soyad"].ToString();
                personel_kullaniciadi_txt.Text = personeloku["KullaniciAdi"].ToString();
                personel_sifre_txt.Text = personeloku["Sifre"].ToString();
                personel_id_txt.Text=personeloku["Id"].ToString();
                personel_yetki_id_cb.SelectedValue = personeloku["YetkiId"].ToString();
            }
            Garson.db.Close();
        }
        public void YetkiDoldur()
        {
            Garson.db.Open();
            DataTable tablo = new DataTable("Yetki");
            string sorgu = "select * from Yetki";
            SqlCommand yetkigetir = new SqlCommand(sorgu, Garson.db);
            SqlDataReader yetkioku = yetkigetir.ExecuteReader();
            tablo.Load(yetkioku);
            personel_yetki_id_cb.DataSource = tablo;
            personel_yetki_id_cb.DisplayMember = "Yetki";
            personel_yetki_id_cb.ValueMember = "Id";
            Garson.db.Close();
        }
        public void PersonelDuzenleSorgu()
        {
            string personel_adi = personel_adi_txt.Text;
            string personel_soyadi = personel_soyadi_txt.Text;
            string personel_kullaniciadi = personel_kullaniciadi_txt.Text;
            string personel_sifre = personel_sifre_txt.Text;
            int personel_yetki_id = Convert.ToInt32(personel_yetki_id_cb.SelectedValue);

            string sorgu = "update Personel set Ad='" + personel_adi + "', Soyad='" + personel_soyadi + "', KullaniciAdi='" + personel_kullaniciadi + "', Sifre='" + personel_sifre + "', YetkiId=" + personel_yetki_id + " where Id='" + personel_id + "' ";
            SqlCommand personelduzenle = new SqlCommand(sorgu, Garson.db);
            personelduzenle.ExecuteNonQuery();
            MessageBox.Show("Personel Düzenleme Başarılı.");
            Garson.db.Close();
        }
        public void PersonelSilSorgu()
        {
            Garson.db.Open();
            string sorgu = "delete from Personel where Id='" + personel_id + "' ";
            SqlCommand personelsil = new SqlCommand(sorgu, Garson.db);
            personelsil.ExecuteNonQuery();
            Garson.db.Close();
            MessageBox.Show("Personel Silme Başarılı");
            this.Close();
        }
    }
}
