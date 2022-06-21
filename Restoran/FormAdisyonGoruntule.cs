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
    public partial class FormAdisyonGoruntule : Form
    {
        public int adisyon_id = 0;

        public bool moveStatus = false;
        public Point moveForm = new Point(0, 0);

        public FormAdisyonGoruntule()
        {
            InitializeComponent();
        }
        private void FormAdisyonGoruntule_Load(object sender, EventArgs e)
        {
            AdisyonDoldur();
            adisyon_detay_panel.Size = new Size(this.Width, this.Height * 20 / 100);
            adisyon_detay_dgv.Size = new Size(this.Width, this.Height * 80 / 100);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DataTable DatalarıDoldur(string sorgu)
        {
            Garson.db.Open();
            DataTable tablo = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorgu, Garson.db);
            sqlDataAdapter.Fill(tablo);
            Garson.db.Close();
            return tablo;
        }
        public void AdisyonDoldur()
        {
            string sorgu = "select Urunler.Ad as 'Ürün Adı',Siparis.Aciklama,Siparis.Adet from Siparis inner join Urunler on(Siparis.UrunId=Urunler.Id) where AdisyonId='" + adisyon_id + "'";
            DatalarıDoldur(sorgu);
            adisyon_detay_dgv.DataSource = DatalarıDoldur(sorgu);
        }

        private void adisyon_detay_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveStatus == true)
            {
                this.Location = new Point(this.Location.X + (e.Location.X - moveForm.X), this.Location.Y + (e.Location.Y - moveForm.Y));
            }
        }

        private void adisyon_detay_panel_MouseDown(object sender, MouseEventArgs e)
        {
            moveStatus = true;
            moveForm = e.Location;
        }

        private void adisyon_detay_panel_MouseUp(object sender, MouseEventArgs e)
        {
            moveStatus = false;

        }
    }
}
