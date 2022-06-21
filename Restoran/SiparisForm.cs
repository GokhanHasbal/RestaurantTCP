using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using Button = System.Windows.Forms.Button;
using SimpleTCP;

namespace Restoran
{
    public partial class SiparisForm : Form
    {
        public int adisyon_id;
        public int siparis_id;
        public int kategori_id = 0;
        public int urun_id;
        public bool durum = false;
        public int masa_Id;
        public int personel_id;
        public DateTime tarih;
        public int kisi_sayisi;
        FormGarson formGarson = new FormGarson();
        public string ClientIp;
        public int ClientPort;

        public SiparisForm()
        {
            InitializeComponent();
            
        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            kategoriGetir();
            Garson.db.Open();
            DataTable rfv = new DataTable();
            SqlCommand comm = new SqlCommand("select Siparis.Id,Urunler.Ad,Siparis.Adet from Siparis inner join Urunler on(Siparis.UrunId = Urunler.Id) where AdisyonId ="+adisyon_id+"", Garson.db);

            SqlDataAdapter siparis_goster = new SqlDataAdapter(comm);

            siparis_goster.Fill(rfv);

            siparis_dgv.DataSource = rfv;
            Garson.db.Close();
            masa_lbl.Text = "Masa " + masa_Id;
            siparis_dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;//autosize belli sütünun
            siparis_dgv.Columns[0].Visible = false;


        }

        

        public void yemekGetir(int kategori_id)//parantez için kategori id ile gelecek
        {

            Garson.db.Open();
            SqlCommand comm = new SqlCommand("select urunler.Id,Ad,Kategori,KategoriId,Fiyat from Urunler inner join Kategoriler on(Urunler.KategoriId=Kategoriler.Id) where KategoriId='" + kategori_id + "'", Garson.db);
            SqlDataReader kid = comm.ExecuteReader();
            while (kid.Read())
            {
                HopeButton btn = new HopeButton();
                btn.Name ="button_"+kid["Id"];
                btn.Text = kid["Ad"].ToString();
                btn.PrimaryColor = Color.MediumVioletRed;
                btn.Click += Btn_Click;
                btn.Width = 120;
                btn.Height = 90;
                yemekler_panel.Controls.Add(btn);
                durum = true;

            }

            Garson.db.Close();
        }

        public void kategoriGetir()
        {
            Garson.db.Open();
            SqlCommand comm = new SqlCommand("select Id,Kategori from Kategoriler", Garson.db);
            SqlDataReader kg = comm.ExecuteReader();

            while (kg.Read())
            {
                HopeButton btn = new HopeButton();
                btn.Name = "button_" + kg["Id"];
                btn.Text = kg["Kategori"].ToString();
                btn.Click += Btn_Click1;
                btn.Width = 140;
                btn.Height = 100;
                kategori_fpanel.Controls.Add(btn);
                
            }
            Garson.db.Close();
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            kategori_id = Convert.ToInt32((sender as HopeButton).Name.Substring(7));
            yemekler_panel.Controls.Clear();
            yemekGetir(kategori_id);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            urun_id = Convert.ToInt32((sender as HopeButton).Name.Substring(7));


            Garson.sorguGonder("exec SiparisVer "+adisyon_id.ToString()+","+urun_id.ToString()+","+adet_lbl.Text+"");
            Garson.tabloDoldur("select Siparis.Id,Ad,Siparis.Adet from Siparis inner join Urunler on(Siparis.UrunId=Urunler.Id) where AdisyonId="+adisyon_id.ToString()+"",siparis_dgv);
            //form1.db.Open();
            //SqlCommand qwe = new SqlCommand();
            //qwe.Connection = form1.db;
            //qwe.CommandType = CommandType.StoredProcedure;
            //qwe.CommandText = "SiparisVer";
            //qwe.Parameters.Add("AdisyonId", SqlDbType.Int).Value = adisyon_id;
            //qwe.Parameters.Add("urunid", SqlDbType.Int).Value = urun_id;
            //qwe.Parameters.Add("Adet", SqlDbType.Int).Value = adet_lbl.Text;
            

            //DataTable tablo = new DataTable();

            //SqlDataAdapter siparis_ekle = new SqlDataAdapter(qwe);

            //siparis_ekle.Fill(tablo);

            //siparis_dgv.DataSource = tablo;
            //form1.db.Close();
            
        }

        private void kapat_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Kapat Butonu

        private void button1_Click(object sender, EventArgs e)
        {
            adet_lbl.Text = (sender as Button).Text;
        }

        private void c_btn_Click(object sender, EventArgs e)
        {
            adet_lbl.Text = "0";
        }

        private void sip_sil_btn_Click(object sender, EventArgs e)
        {

            Garson.db.Open();
            SqlCommand silkomut = new SqlCommand();
            silkomut.Connection = Garson.db;
            silkomut.CommandType = CommandType.StoredProcedure;
            silkomut.CommandText = "SiparisSil";//veri tabanında bulunan procedurenin adı
            silkomut.Parameters.Add("siparisId", SqlDbType.Int).Value = siparis_id;
            silkomut.ExecuteNonQuery();
            Garson.db.Close();
            siparis_dgv.Rows.Remove(siparis_dgv.CurrentRow);
        }

        private void siparis_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            siparis_id = Convert.ToInt32(siparis_dgv.CurrentRow.Cells["Id"].Value);
        }

        private void sip_temiz_btn_Click(object sender, EventArgs e)
        {
            Garson.db.Open();
            SqlCommand silkomut = new SqlCommand();
            silkomut.Connection = Garson.db;
            silkomut.CommandType = CommandType.StoredProcedure;
            silkomut.CommandText = "SiparislerSil";//veri tabanında bulunan procedurenin adı
            silkomut.Parameters.Add("adisyonId", SqlDbType.Int).Value = adisyon_id;
            silkomut.ExecuteNonQuery();
            if (siparis_dgv.Rows.Count > 0)
            {
                do
                {
                    siparis_dgv.Rows.RemoveAt(0);
                }
                while (siparis_dgv.Rows.Count > 0);
            }
            Garson.db.Close();
        }

        private void hopeButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Seçili siparişler gönderilecek! Emin misiniz?", "Sipariş Gönderimi", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    formGarson.client.Connect(ClientIp, ClientPort);

                    formGarson.client.WriteLine("2," + "Yeni Sipariş Geldi!");

                }
                catch
                {
                    MessageBox.Show("Mutfak online değil!");

                }
            }
            else
            {
                MessageBox.Show("Sipariş gönderimi iptal edildi!");
            }

        }
    }
}
