using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Net;


namespace Restoran
{
    public class Garson
    {

        public static SqlConnection db;

        static Form1 form1 = new Form1();
        public static string sqlServerIp;

        public static void sqlAyarla(string ip)
        {
            sqlServerIp = ip;
            db = new SqlConnection("Data Source=" + sqlServerIp + ";Initial Catalog=Restoran;Persist Security Info=True;User ID=sa;Password=" + "123456789" + "");

        }

        

        int personelId;
        int masaId;
        int kisiSayisi;
        string olusturmaTarihi;
        string kapatmaTarihi;
        bool durum;
        double toplamFiyat;

        public void GarsonBilgi(int personelId, int masaId, int kisiSayisi, string olusturmaTarihi, string kapatmaTarihi, bool durum, double toplamFiyat)
        {
            this.personelId = personelId;
            this.masaId = masaId;
            this.kisiSayisi = kisiSayisi;
            this.olusturmaTarihi = olusturmaTarihi;
            this.kapatmaTarihi = kapatmaTarihi;
            this.durum = durum;
            this.toplamFiyat = toplamFiyat;
        }

        public void AdisyonAc(int personelId, int masaId, int kisiSayisi, string olusturmaTarihi, string kapatmaTarihi, bool durum, double toplamFiyat)
        {
            DialogResult masaAcSoru = new DialogResult();
            masaAcSoru = MessageBox.Show(masaId + "'nolu masa açılsın mı?", "Masa Aç", MessageBoxButtons.OKCancel);
            if (masaAcSoru == DialogResult.OK)
            {
                MessageBox.Show(masaId + "'nolu masa açılmıştır.");
                sorguGonder("update Masalar Set Durum=0 where Id="+masaId+"");
            }
            else
            {
                MessageBox.Show("Masa açma iptal edildi.");
            }
        }

        public static void sorguGonder(string sorgu)
        {
            db.Open();
            SqlCommand komut = new SqlCommand(sorgu, db);
            komut.ExecuteNonQuery();
            db.Close();
        }



        public static void tabloDoldur(string sorgu,DataGridView dgv)
        {

            db.Open();
            DataTable tablo = new DataTable();
            SqlDataAdapter veriGetir = new SqlDataAdapter(sorgu, db);
            veriGetir.Fill(tablo);
            dgv.DataSource = tablo;
            db.Close();

        }

        public List<string> veriCek(string sorgu,string sutun)
        {
            List<string> liste = new List<string>();

            db.Open();
            SqlCommand komut = new SqlCommand(sorgu, db);

            SqlDataReader verioku = komut.ExecuteReader();

            while (verioku.Read())
            {
                liste.Add(verioku[sutun].ToString());
            }

            db.Close();



            return liste;
        }

        public static string GetLocalIPAddress()
        {
            string myHost = System.Net.Dns.GetHostName();
            string IpAddress = "127.0.0.1";
            System.Net.IPHostEntry myIPs = System.Net.Dns.GetHostEntry(myHost);
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                IpAddress = myIPs.AddressList[1].ToString();
            }
            else
            {
                IpAddress = "127.0.0.1";
            }
            return IpAddress;
            
        }



    }
}
