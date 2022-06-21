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
    public partial class FormMasaDuzenle : Form
    {
        public int masa_id = 0;
        public string mudurKullanici = "";
        public string masa_adi = "";
        public FormMasaDuzenle()
        {
            InitializeComponent();
        }
        private void FormMasaDuzenle_Load(object sender, EventArgs e)
        {
            masa_id_txt.Enabled = false;
            btnExit.Location = new Point(this.Width - 29, -1);
            masa_duzenle_panel.Size = new Size(this.Width, this.Height * 20 / 100);
            groupBox1.Size = new Size(this.Width, this.Height * 80 / 100);
            MasaGetir(masa_id);
        }
        public void MasaGetir(int masa_id)
        {
            Form1 frm = new Form1();
            Garson.db.Open();
            string sorgu = "Select * from Masalar where Id='" + masa_id + "' ";
            SqlCommand mg = new SqlCommand(sorgu, Garson.db);
            SqlDataReader masaoku = mg.ExecuteReader();
            if (masaoku.Read())
            {
                masa_adi_txt.Text = masaoku["Ad"].ToString();
                masa_id_txt.Text = masaoku["Id"].ToString();
                masa_durum_cb.SelectedIndex = Convert.ToInt32(masaoku["Durum"]);
            }
            Garson.db.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMasaDuzenle_Click(object sender, EventArgs e)
        {
            MasaDuzenleSorgu();
            MasaGetir(masa_id);
        }
        private void btnMasaSil_Click(object sender, EventArgs e)
        {
            string masa_adi = masa_adi_txt.Text;
            DialogResult silkontrol = new DialogResult();
            silkontrol = MessageBox.Show(masa_adi + " Adlı Masa Silinsin mi?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (silkontrol == DialogResult.Yes)
            {
                MasaSilSorgu();
            }
            else
            {
                MessageBox.Show("Masa Silme İptal");
            }
        }
        private void btnMasaEkle_Click(object sender, EventArgs e)
        {
            FormMasaEkle fme = new FormMasaEkle();
            fme.ShowDialog();
        }
        public void MasaSilSorgu()
        {
            Form1 frm = new Form1();
            Garson.db.Open();
            string sorgu = "delete from Masalar where Id='" + masa_id + "' ";
            SqlCommand urunsil = new SqlCommand(sorgu, Garson.db);
            urunsil.ExecuteNonQuery();
            Garson.db.Close();
            MessageBox.Show("Masa Silme Başarılı");
            this.Close();
        }
        public void MasaDuzenleSorgu()
        {
            string masa_adi = masa_adi_txt.Text;
            int masa_id = Convert.ToInt32(masa_id_txt.Text);
            int masa_durum = Convert.ToInt32(masa_durum_cb.SelectedIndex);
            Form1 frm = new Form1();
            Garson.db.Open();
            string sorgu = "update Masalar set Ad='" + masa_adi + "',  Durum=" + masa_durum + " where Id='" + masa_id + "'";
            SqlCommand personelduzenle = new SqlCommand(sorgu, Garson.db);
            personelduzenle.ExecuteNonQuery();
            MessageBox.Show("Masa Düzenleme Başarılı.");
            Garson.db.Close();
        }
        
    }
}
