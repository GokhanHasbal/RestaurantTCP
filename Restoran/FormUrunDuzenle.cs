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
    public partial class FormUrunDuzenle : Form
    {
        public int urun_id = 0;
        public string mudurKullanici = "";
        public string urun_adi = "";
        public FormUrunDuzenle()
        {
            InitializeComponent();
        }
        private void FormUrunDuzenle_Load(object sender, EventArgs e)
        {
            urun_id_txt.Enabled = false;
            urun_duzenle_panel.Size = new Size(this.Width, this.Height * 20 / 100);
            groupBox1.Size = new Size(this.Width, this.Height * 80 / 100);
            KategoriDoldur();
            UrunGetir(urun_id);
        }
        public void KategoriDoldur()
        {
            urun_kategori_cb.Items.Clear();
            Garson.db.Open();
            DataTable tablo = new DataTable("Kategoriler");
            string sorgu = "select * from Kategoriler ";
            SqlCommand kategorigetir = new SqlCommand(sorgu, Garson.db);
            SqlDataReader kategorioku = kategorigetir.ExecuteReader();
            tablo.Load(kategorioku);
            urun_kategori_cb.DataSource = tablo;
            urun_kategori_cb.DisplayMember = "Kategori";
            urun_kategori_cb.ValueMember = "Id";
            Garson.db.Close();
        }
        public void UrunGetir(int urun_id)
        {
            Garson.db.Open();
            string sorgu = "Select * from Urunler where Id='" + urun_id + "'";
            SqlCommand ug = new SqlCommand(sorgu, Garson.db);
            SqlDataReader urunoku = ug.ExecuteReader();
            if (urunoku.Read())
            {
                urun_adi_txt.Text = urunoku["Ad"].ToString();
                urun_id_txt.Text = urunoku["Id"].ToString();
                urun_fiyat_txt.Text = urunoku["Fiyat"].ToString();
                urun_resim_txt.Text = urunoku["Resim"].ToString();
                urun_aciklama_rtb.Text = urunoku["Aciklama"].ToString();
                urun_kategori_cb.SelectedValue = urunoku["KategoriId"].ToString();
                urun_durum_cb.SelectedIndex = Convert.ToInt32(urunoku["Durum"]);
            }
            Garson.db.Close();
        }
        private void btnUrunlDuzenle_Click(object sender, EventArgs e)
        {
            BilgiAl();
            UrunDuzenleSorgu();
            UrunGetir(urun_id);
        }
        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            string urun_adi = urun_adi_txt.Text;
            DialogResult silkontrol = new DialogResult();
            silkontrol = MessageBox.Show(urun_adi + " Adlı Ürün Silinsin mi?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (silkontrol == DialogResult.Yes)
            {
                UrunSilSorgu();

                //SqlCommand silkomut = new SqlCommand();           // proc gelirse
                //silkomut.Connection = Garson.db;
                //silkomut.CommandType = CommandType.StoredProcedure;
                //silkomut.CommandText = "yazarSil";
                //silkomut.Parameters.Add("yazarId", SqlDbType.Int).Value = yazarId;      //soldaki id proc'daki sağdaki id yukarıda tanımladığımız
                //silkomut.ExecuteNonQuery();

                //MessageBox.Show("Masa Silme Başarılı");
                //this.Close();
            }
            else
            {
                MessageBox.Show("Ürün Silme İptal");
            }
        }
        private void btnUrunlEkle_Click(object sender, EventArgs e)
        {
            FormUrunEkle fue = new FormUrunEkle();
            fue.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void BilgiAl()
        {
            string urun_adi = urun_adi_txt.Text;
            int urun_id = Convert.ToInt32(urun_id_txt.Text);
            string urun_fiyat = urun_fiyat_txt.Text;
            string urun_foto = urun_resim_txt.Text;
            string urun_aciklama = urun_aciklama_rtb.Text;
            int urun_kategori = Convert.ToInt32(urun_kategori_cb.SelectedValue);
            int urun_durum = Convert.ToInt32(urun_durum_cb.SelectedIndex);
        }
        public void UrunDuzenleSorgu()
        {
            string urun_adi = urun_adi_txt.Text;
            int urun_id = Convert.ToInt32(urun_id_txt.Text);
            string urun_fiyat = urun_fiyat_txt.Text;
            string urun_foto = urun_resim_txt.Text;
            string urun_aciklama = urun_aciklama_rtb.Text;
            int urun_kategori = Convert.ToInt32(urun_kategori_cb.SelectedValue);
            int urun_durum = Convert.ToInt32(urun_durum_cb.SelectedIndex);
            Garson.db.Open();
            string sorgu = "update Urunler set Ad='" + urun_adi + "', Fiyat = '" + urun_fiyat + "', Resim='" + urun_foto + "', Aciklama='" + urun_aciklama + "', KategoriId=" + urun_kategori + ", Durum=" + urun_durum + " where Id='" + urun_id + "'";
            SqlCommand personelduzenle = new SqlCommand(sorgu, Garson.db);
            personelduzenle.ExecuteNonQuery();
            MessageBox.Show("Ürün Düzenleme Başarılı.");
            Garson.db.Close();
        }
        public void UrunSilSorgu()
        {
            Garson.db.Open();
            string sorgu = "delete from Urunler where Id='" + urun_id + "' ";
            SqlCommand urunsil = new SqlCommand(sorgu, Garson.db);
            urunsil.ExecuteNonQuery();
            Garson.db.Close();
            MessageBox.Show("Ürün Silme Başarılı");
            this.Close();
        }
    }
}
