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
    public partial class FormKategoriDuzenle : Form
    {
        public int kategori_id = 0;
        public string mudurKullanici = "";
        public string kategori_adi = "";
        public FormKategoriDuzenle()
        {
            InitializeComponent();
        }
        private void FormKategoriDuzenle_Load(object sender, EventArgs e)
        {
            kategori_id_txt.Enabled = false;
            btnExit.Location = new Point(this.Width - 29, -1);
            kategori_duzenle_panel.Size = new Size(this.Width, this.Height * 20 / 100);
            groupBox1.Size = new Size(this.Width, this.Height * 80 / 100);
            KategoriGetir(kategori_id);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void KategoriGetir(int masa_id)
        {
            Garson.db.Open();
            string sorgu = "Select * from Kategoriler where Id='" + kategori_id + "' ";
            SqlCommand kg = new SqlCommand(sorgu, Garson.db);
            SqlDataReader kategorioku = kg.ExecuteReader();
            if (kategorioku.Read())
            {
                kategori_adi_txt.Text = kategorioku["Kategori"].ToString();
                kategori_id_txt.Text = kategorioku["Id"].ToString();
                kategori_aciklama_rtb.Text = kategorioku["Aciklama"].ToString();
            }
            Garson.db.Close();
        }
        private void btnKategoriDuzenle_Click(object sender, EventArgs e)
        {
            KategoriDuzenleSorgu();
            KategoriGetir(kategori_id);
        }
        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            string kategori_adi = kategori_adi_txt.Text;
            DialogResult silkontrol = new DialogResult();
            silkontrol = MessageBox.Show(kategori_adi + " Adlı Kategori Silinsin mi?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (silkontrol == DialogResult.Yes)
            {
                KategoriSilSorgu();
            }
            else
            {
                MessageBox.Show("Kategori Silme İptal");
            }
        }
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            FormKategoriEkle fke = new FormKategoriEkle();
            fke.ShowDialog();
        }
        public void KategoriSilSorgu()
        {
            Garson.db.Open();
            string sorgu = "delete from Kategoriler where Id='" + kategori_id + "' ";
            SqlCommand kategorisil = new SqlCommand(sorgu, Garson.db);
            kategorisil.ExecuteNonQuery();
            Garson.db.Close();
            MessageBox.Show("Kategori Silme Başarılı");
            this.Close();
        }
        public void KategoriDuzenleSorgu()
        {
            string kategori_adi = kategori_adi_txt.Text;
            int kategori_id = Convert.ToInt32(kategori_id_txt.Text);
            string kategori_aciklama = kategori_aciklama_rtb.Text;
            Garson.db.Open();
            string sorgu = "update Kategoriler set Kategori='" + kategori_adi + "',  Aciklama=" + kategori_aciklama + " where Id='" + kategori_id + "'";
            SqlCommand kategoriduzenle = new SqlCommand(sorgu, Garson.db);
            kategoriduzenle.ExecuteNonQuery();
            MessageBox.Show("Kategori Düzenleme Başarılı.");
            Garson.db.Close();
        }
    }
}
