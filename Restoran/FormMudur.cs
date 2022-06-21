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
    public partial class FormMudur : Form
    {
        public string mudurKullanici = "";
        public int personel_id = 0;
        int urun_id = 0;
        int masa_id = 0;
        int kategori_id = 0;
        int adisyon_id=0;
        public FormMudur()
        {
            InitializeComponent();
        }
        private void FormMudur_Load(object sender, EventArgs e)
        {
            mudur_head_panel.Size = new Size(this.Width, this.Height * 20 / 100);
            mudur_tab_control.Size = new Size(this.Width, this.Height * 80 / 100);
            giris_yapan_label.Text = mudurKullanici + " Hoşgeldin!";

            PersonelDoldur();
            UrunDoldur();
            MasaDoldur();
            AdisyonDoldur();
            KategoriDoldur();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormMudur_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public DataTable DatalarıDoldur(string sorgu)
        {
            Form1 frm = new Form1();
            Garson.db.Open();
            DataTable tablo = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorgu, Garson.db);
            sqlDataAdapter.Fill(tablo);
            Garson.db.Close();
            return tablo;
        }
        public void PersonelDoldur()
        {
            string sorgu = "select Personel.Id as 'Personelin idsi', Yetki.Yetki as 'Personel Yetkisi', Personel.Ad as 'Personel Adı', Personel.SoyAd as 'Personel Soyadı', Personel.KullaniciAdi as 'Personelin Kullanıcı Adı', Personel.Sifre as 'Personelin Şifresi' from Personel inner join Yetki on (Personel.YetkiId=Yetki.Id)";
            DatalarıDoldur(sorgu);
            personel_dgv.DataSource = DatalarıDoldur(sorgu);
            personel_dgv.Columns[0].Visible = false;
        }
        public void UrunDoldur()
        {
            string sorgu = "select Urunler.Id as 'Ürünün Idsi', Kategoriler.Kategori as 'Ürünün Kategorisi', Urunler.Ad as 'Ürünün Adı', Urunler.Aciklama 'Ürünün Açıklaması', Urunler.Resim 'Ürünün Fotoğrafı', Urunler.Fiyat 'Ürünün Fiyatı', Urunler.Durum as 'Ürün Stok Durum' from Urunler inner join Kategoriler on (Urunler.KategoriId=Kategoriler.Id) ";
            DatalarıDoldur(sorgu);
            urunler_dgv.DataSource = DatalarıDoldur(sorgu);
            urunler_dgv.Columns[0].Visible = false;
        }
        public void MasaDoldur()
        {
            string sorgu = "select Masalar.Id as 'Masanın idsi', Masalar.Ad as 'Masa Adı', Masalar.Durum as 'Masa Durum' from Masalar";
            DatalarıDoldur(sorgu);
            masalar_dgv.DataSource = DatalarıDoldur(sorgu);
            masalar_dgv.Columns[0].Visible = false;
        }
        public void AdisyonDoldur()
        {
            string sorgu = "select Adisyon.Id as 'Adisyon Idsi', Masalar.Ad as 'Masanın Adı', Personel.Ad as 'İlgilenen Personel', Adisyon.OlusturmaTarihi as 'Adisyon Açma Tarihi', Adisyon.KapatmaTarihi as 'Adisyon Kapanma Tarihi', Adisyon.ToplamFiyat as 'Adisyon Toplam Tutar' from Adisyon inner join Masalar on(Adisyon.MasaId=Masalar.Id) inner join Personel on (Adisyon.PersonelId=Personel.Id)";
            DatalarıDoldur(sorgu);
            adisyon_dgv.DataSource = DatalarıDoldur(sorgu);
            adisyon_dgv.Columns[0].Visible = false;
        }
        public void KategoriDoldur()
        {
            string sorgu = "select Kategoriler.Id as 'Kategori Idsi', Kategoriler.Kategori as 'Kategori Adı', Kategoriler.Aciklama as 'Kategori Aciklaması' from Kategoriler";
            DatalarıDoldur(sorgu);
            kategori_dgv.DataSource = DatalarıDoldur(sorgu);
            kategori_dgv.Columns[0].Visible = false;
        }
        private void personel_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            personel_id = Convert.ToInt32(personel_dgv.CurrentRow.Cells["Personelin idsi"].Value);
            string personel_adi = personel_dgv.CurrentRow.Cells["Personel Adı"].Value.ToString();
            FormPersonelDuzenle fpd = new FormPersonelDuzenle();
            fpd.personel_id = personel_id;
            fpd.personel_adi = personel_adi;
            fpd.ShowDialog();
        }
        private void urunler_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            urun_id = Convert.ToInt32(urunler_dgv.CurrentRow.Cells["Ürünün Idsi"].Value);
            string urun_adi = urunler_dgv.CurrentRow.Cells["Ürünün Adı"].Value.ToString();
            FormUrunDuzenle fud = new FormUrunDuzenle();
            fud.urun_id = urun_id;
            fud.urun_adi = urun_adi;
            fud.ShowDialog();
        }
        private void masalar_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            masa_id = Convert.ToInt32(masalar_dgv.CurrentRow.Cells["Masanın idsi"].Value);
            string masa_adi = masalar_dgv.CurrentRow.Cells["Masa Adı"].Value.ToString();
            FormMasaDuzenle fmd = new FormMasaDuzenle();
            fmd.masa_id = masa_id;
            fmd.masa_adi = masa_adi;
            fmd.ShowDialog();

        }
        private void kategori_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            kategori_id = Convert.ToInt32(kategori_dgv.CurrentRow.Cells["Kategori Idsi"].Value);
            string kategori_adi = kategori_dgv.CurrentRow.Cells["Kategori Adı"].Value.ToString();
            FormKategoriDuzenle fkd = new FormKategoriDuzenle();
            fkd.kategori_id = kategori_id;
            fkd.kategori_adi = kategori_adi;
            fkd.ShowDialog();
        }
        private void btnYenile_Click(object sender, EventArgs e)
        {
            PersonelDoldur();
            UrunDoldur();
            MasaDoldur();
            AdisyonDoldur();
            KategoriDoldur();
        }
        private void adisyon_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            adisyon_id = Convert.ToInt32(adisyon_dgv.CurrentRow.Cells["Adisyon Idsi"].Value);
            FormAdisyonGoruntule fag = new FormAdisyonGoruntule();
            fag.adisyon_id = adisyon_id;
            fag.ShowDialog();
        }
    }
}
