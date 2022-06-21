using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Drawing.Poison;
using Button = System.Windows.Forms.Button;
using SimpleTCP;


namespace Restoran
{
    public partial class FormGarson : Form
    {
        public static string GarsonKullanici = "";
        public bool durum = false;
        public int masa_id = 0;
        public static int personel_id = 2;
        public int adisyon_id;
        public int kisi_sayisi = 1;
        Form1 form1 = new Form1();
        public SimpleTcpServer server = new SimpleTcpServer();
        public SimpleTcpClient client = new SimpleTcpClient();
        public static string localHostIp;
        public string ServerIp;
        public int ServerPort;
        public string ClientIp;
        public int ClientPort = 3535;
        string[] gelenMesaj;
        Random rndm = new Random();





        public FormGarson()
        {
            InitializeComponent();
        }

        private void FormGarson_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void FormGarson_Load(object sender, EventArgs e)
        {
            ServerIp = localHostIp;
            ServerPort = rndm.Next(11000, 12000);

            labelIpAdres.Text = localHostIp;
            btnExit2.Location = new Point(this.Width - 29, -1);
            btnCikis.Font = new Font("Segoe UI", lostPanel2.Width / 130);
            btnCikis.Location = new Point(btnExit2.Location.X - 30 - btnCikis.Width / 5 * 4, 0);

            lblGirisYapan.Text = GarsonKullanici;
            lblGirisYapan.Font = new Font("Segoe UI", this.Width / 120);

            lblGirisYapan.Location = new Point(btnCikis.Location.X - btnCikis.Width / 4 - lblGirisYapan.Width, btnCikis.Height / 6);

            btnCikis.AutoSize = true;
            poisonDataGridView1.DefaultCellStyle.Font = new Font(poisonDataGridView1.Font.FontFamily, this.Width / 120);
            poisonDataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(poisonDataGridView1.Font.FontFamily, this.Width / 100);

            panelHesap.Size = new Size(poisonDataGridView1.Width, 235);
            panelHesap.Location = new Point(0, poisonDataGridView1.Height - panelHesap.Height);
            //panelHesap.Dock = DockStyle.Bottom;
            panelHesap.Visible = false;


            //lblGirisYapan.Location = new Point(btnCikis.Location.X-10-lblGirisYapan.Width,lblGirisYapan.Location.Y);

            masaGetir();
            siparis_btn.Visible = false;
            hesap_btn.Visible = false;

            server.Delimiter = 0x13; //enter komut ile gelen veriyi yakalama
            server.StringEncoder = Encoding.UTF8;

            server.DataReceived += Server_DataReceived;
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(ServerIp);
            server.Start(ip, ServerPort);
            client.StringEncoder = Encoding.UTF8;




        }








        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            gelenMesaj = e.MessageString.Remove(e.MessageString.Length - 1).Split(',');

            if (gelenMesaj[0] == "0")
            {
                client.Disconnect();

            }
            else if (gelenMesaj[0] == "1")
            {
                MessageBox.Show(gelenMesaj[1].ToString());

            }





        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            client.Connect(ClientIp, ClientPort);

            client.WriteLine("0," + GarsonKullanici);

            this.Close();
            client.Disconnect();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            client.Connect(ClientIp, ClientPort);

            client.WriteLine("0," + GarsonKullanici);
            client.Disconnect();

            this.Hide();

            form1.Show();

        }


        public void masaGetir()
        {
            Garson.db.Open();
            SqlCommand comm = new SqlCommand("select Id,Ad,Durum From Masalar", Garson.db);
            SqlDataReader mg = comm.ExecuteReader();

            while (mg.Read())
            {

                Button tile = new Button();
                tile.Name = "tile_" + mg["Id"];
                tile.Text = mg["Ad"].ToString();
                tile.Font = new Font(this.Font.FontFamily, 12);
                tile.FlatStyle = FlatStyle.Popup;
                tile.BackgroundImage = Restoran.Properties.Resources.table;
                tile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                tile.Click += Btn_Click;
                tile.Size = new Size(160, 120);
                if (Convert.ToBoolean(mg["Durum"]) == true)
                {
                    tile.BackColor = Color.Red;

                }
                else
                {
                    tile.BackColor = Color.LightGreen;

                }
                tile.Margin = new Padding(40);
                masa_fpanel.Controls.Add(tile);

            }

            Garson.db.Close();
        }

        public void Btn_Click(object sender, EventArgs e)
        {
            masa_id = Convert.ToInt32((sender as Button).Name.Substring(5));
            Garson.db.Open();
            SqlCommand comm = new SqlCommand("select* From Masalar where Id=" + masa_id, Garson.db);
            SqlDataReader stat = comm.ExecuteReader();
            bool durum = false;
            panelHesap.Visible= false;

            if (stat.Read())
            {

                if ((bool)stat["Durum"] == true)
                {
                    durum = true;
                    siparis_btn.Visible = true;
                    hesap_btn.Visible = true;
                }
                else
                {
                    durum = false;

                }

            }
            Garson.db.Close();
            if (durum == true)
            {
                Garson.db.Open();
                SqlCommand zxc = new SqlCommand("select Id from Adisyon where MasaId=" + masa_id + " and Durum=1 ", Garson.db);
                SqlDataReader asd = zxc.ExecuteReader();
                if (asd.Read())
                {
                    adisyon_id = Convert.ToInt32(asd["Id"]);
                }


                Garson.db.Close();
                siparisGetir(masa_id);

            }
            else
            {
                DialogResult masa_kontrol = new DialogResult();
                SiparisForm gt = new SiparisForm();

                masa_kontrol = MessageBox.Show("Adisyon Açılsın mı?", "Masa Aç", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (masa_kontrol == DialogResult.Yes)
                {

                    gt.tarih = DateTime.Now;
                    gt.masa_Id = masa_id;
                    gt.personel_id = personel_id;
                    gt.kisi_sayisi = kisi_sayisi;
                    Garson.db.Open();
                    SqlCommand asd = new SqlCommand();
                    asd.Connection = Garson.db;
                    asd.CommandType = CommandType.StoredProcedure;
                    asd.CommandText = "adisyonEkle";
                    asd.Parameters.Add("masaid", SqlDbType.Int).Value = masa_id;
                    asd.Parameters.Add("personelid", SqlDbType.Int).Value = personel_id;
                    asd.Parameters.Add("kisisayisi", SqlDbType.Int).Value = kisi_sayisi;
                    asd.Parameters.Add("otarih", SqlDbType.DateTime).Value = DateTime.Now;
                    asd.Parameters.Add("durum", SqlDbType.Bit).Value = true;
                    SqlDataReader qwerty = asd.ExecuteReader();
                    if (qwerty.Read())
                    {
                        adisyon_id = Convert.ToInt32(qwerty["Id"]);
                    }
                    Garson.db.Close();
                    int index = masa_fpanel.Controls.IndexOfKey("tile_" + masa_id.ToString());
                    masa_fpanel.Controls[index].BackColor = Color.Red;

                }

            }

        }

        private void siparisGetir(int masa_id)
        {
            SqlCommand comm1 = new SqlCommand();
            comm1.Connection = Garson.db;
            comm1.CommandType = CommandType.StoredProcedure;
            comm1.CommandText = "masaAdisyonGoster";
            comm1.Parameters.Add("masaId", SqlDbType.Int).Value = masa_id;

            DataTable tablo = new DataTable();

            SqlDataAdapter siparis_getir = new SqlDataAdapter(comm1);

            siparis_getir.Fill(tablo);

            poisonDataGridView1.DataSource = tablo;
            poisonDataGridView1.Columns[0].Visible = false;

            //poisonDataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            poisonDataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            poisonDataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

        }


        private void siparis_btn_Click(object sender, EventArgs e)
        {
            panelHesap.Visible = false;
            SiparisForm sp = new SiparisForm();
            sp.adisyon_id = adisyon_id;
            sp.masa_Id = masa_id;
            sp.ClientIp = ClientIp;
            sp.ClientPort = ClientPort;
            sp.ShowDialog();
        }

        private void hesap_btn_Click(object sender, EventArgs e)
        {
            if (panelHesap.Visible==false)
            {
                panelHesap.Visible = true;

            }
            else
            {
                panelHesap.Visible = false;

            }
            int toplamtutar = 0;
            for (int i = 0; i < poisonDataGridView1.RowCount; i++)
            {
                toplamtutar += Convert.ToInt32(poisonDataGridView1.Rows[i].Cells[3].Value);
            }
            labelToplamTutar.Text = "Toplam Tutar: " + toplamtutar.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            DialogResult masa_kapat = new DialogResult();

            masa_kapat = MessageBox.Show("Adisyon Kapatılsın mı?", "Masa Kapat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (masa_kapat == DialogResult.Yes)
            {
                poisonDataGridView1.DataSource = null;
                panelHesap.Visible = false; 
                SiparisForm gt = new SiparisForm();
                gt.tarih = DateTime.Now;
                gt.masa_Id = masa_id;
                Garson.db.Open();
                SqlCommand asd = new SqlCommand();
                asd.Connection = Garson.db;
                asd.CommandType = CommandType.StoredProcedure;
                asd.CommandText = "adisyonkapat";
                asd.Parameters.Add("adisyonid", SqlDbType.Int).Value = adisyon_id;
                asd.Parameters.Add("masaid", SqlDbType.Int).Value = masa_id;
                asd.Parameters.Add("ktarih", SqlDbType.DateTime).Value = DateTime.Now;
                asd.Parameters.Add("durum", SqlDbType.Bit).Value = false;
                SqlDataReader qwerty = asd.ExecuteReader();

                Garson.db.Close();
                int index = masa_fpanel.Controls.IndexOfKey("tile_" + masa_id.ToString());
                masa_fpanel.Controls[index].BackColor = Color.LightGreen;


                try
                {
                    client.Connect(ClientIp, ClientPort);

                    client.WriteLine("2," + "Masa ID: " + "'"+masa_id+"' hesabı kapandı!");
                    client.Disconnect();

                }
                catch
                {
                    MessageBox.Show("Mutfak online değil veya yanlış IP adresi girildi!");
                }

            }
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            if (txtMutfakIp.Text != "")
            {
                ClientIp = txtMutfakIp.Text;

            try
                {
                    client.Connect(ClientIp, ClientPort);

                    client.WriteLine("1," + GarsonKullanici + "," + ServerIp.ToString() + "," + ServerPort.ToString());
                    client.Disconnect();
                    MessageBox.Show("Mutfak bağlantısı başarılı!");

                }
                catch
                {
                    MessageBox.Show("Mutfak online değil veya yanlış IP adresi girildi!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce Mutfak IP adresini giriniz!");
            }




        }
    }
}
