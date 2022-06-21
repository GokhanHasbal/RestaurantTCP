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
    public partial class FormMasaEkle : Form
    {
        public FormMasaEkle()
        {
            InitializeComponent();
        }
        private void FormMasaEkle_Load(object sender, EventArgs e)
        {
            masa_durum_cb.SelectedIndex = -1;
            mase_ekle_panel.Size = new Size(this.Width, this.Height*20/100);
            groupBox1.Size =  new Size(this.Width, this.Height * 80 / 100);
        }
        private void btnMasaEkle_Click(object sender, EventArgs e)
        {
            string masa_adi = masa_adi_txt.Text;
            int masa_durum = Convert.ToInt32(masa_durum_cb.SelectedIndex);
            if (masa_adi != ""  && masa_durum != -1)
            {
                MasaEkleSorgu();
                TextSifirla();
            }
            else
            {
                MessageBox.Show("Eksik Bilgi Girdiniz. Lütfen Tekrar Deneyiniz.");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void TextSifirla()
        {
            masa_adi_txt.Clear();
            masa_durum_cb.SelectedIndex = -1;
            masa_adi_txt.Focus();
        }
        public void MasaEkleSorgu()
        {
            string masa_adi = masa_adi_txt.Text;
            int masa_durum = Convert.ToInt32(masa_durum_cb.SelectedIndex);
            Form1 frm = new Form1();
            Garson.db.Open();
            string sorgu = "insert into Masalar (Ad, Durum) values ('" + masa_adi + "', " + masa_durum + " )";
            SqlCommand masaekle = new SqlCommand(sorgu, Garson.db);
            masaekle.ExecuteNonQuery();
            MessageBox.Show("Masa Ekleme Başarılı.");
            Garson.db.Close();
        }
    }
}
