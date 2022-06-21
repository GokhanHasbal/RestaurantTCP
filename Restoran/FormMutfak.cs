using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;
using System.Data.SqlClient;


namespace Restoran
{
    public partial class FormMutfak : Form
    {
        SimpleTcpServer server = new SimpleTcpServer();
        SimpleTcpClient client = new SimpleTcpClient();
        public static string localHostIp;

        string ClientIp;
        int ClientPort;
        public string mutfakKullanici = "";
        public int personelId;
        Garson Garson = new Garson();
        Form1 form1 = new Form1();
        bool panelMove = false;
        Point panelLocation = new Point();
        List<List<string>> GarsonList = new List<List<string>>();
        public int a = 0;
        public string ServerIp;
        int ServerPort = 3535;


        public FormMutfak()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void FormMutfak_Load(object sender, EventArgs e)
        {
            ServerIp = localHostIp;

            labelipAdres.Text = localHostIp;
            btnExit.Location = new Point(this.Width - 29, -1);
            lblGirisYapan.Text = mutfakKullanici;
            lblGirisYapan.Font = new Font("Segoe UI", this.Width / 120);
            btnCikis.Location = new Point(btnExit.Location.X - 30 - btnCikis.Width / 5 * 4, 0);
            btnCikis.Font = new Font("Segoe UI", this.Width / 130);
            btnCikis.AutoSize = true;

            lblGirisYapan.Location = new Point(btnCikis.Location.X - btnCikis.Width / 4 - lblGirisYapan.Width, btnCikis.Height / 6);

            Garson.tabloDoldur("select Adisyon.Id,Masalar.Ad as 'Masa Adı',Adisyon.OlusturmaTarihi as 'Oluşturma Tarihi',Adisyon.Durum from Adisyon inner join Masalar on(Masalar.Id=Adisyon.MasaId) where Adisyon.Durum=1", dgvGelenSiparis);

            grpbxGelenSiparisler.Size = new Size(this.Width / 100 * 26, this.Height - grpbxGelenSiparisler.Location.Y);
            dgvGelenSiparis.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvGelenSiparis.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvGelenSiparis.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGelenSiparis.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvGelenSiparis.DefaultCellStyle.Font = new Font("Segoe UI", this.Width / 140);
            this.dgvGelenSiparis.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", this.Width / 140);



            server.Delimiter = 0x13; //enter komut ile gelen veriyi yakalama
            server.StringEncoder = Encoding.UTF8; //UTF8 Türkçe Dil karakterlerini içeren dil kütüphanesi
            server.DataReceived += Server_DataReceived;

            System.Net.IPAddress ip = System.Net.IPAddress.Parse(ServerIp);
            server.Start(ip, ServerPort);

            client.StringEncoder = Encoding.UTF8;


        }



        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            List<string> gelenMesaj = e.MessageString.Remove(e.MessageString.Length - 1).Split(',').ToList();

            if (gelenMesaj[0].ToString() == "2")
            {
                dgvGelenSiparis.Invoke((MethodInvoker)delegate ()
                {
                    Garson.tabloDoldur("select Adisyon.Id,Masalar.Ad as 'Masa Adı',Adisyon.OlusturmaTarihi as 'Oluşturma Tarihi',Adisyon.Durum from Adisyon inner join Masalar on(Masalar.Id=Adisyon.MasaId) where Adisyon.Durum=1", dgvGelenSiparis);
                    MessageBox.Show(gelenMesaj[1].ToString(), "Yeni Sipariş");
                });

            }


            if (gelenMesaj[0].ToString() != "2")
            {
                durumPanel.Invoke((MethodInvoker)delegate ()
                {
                    if (gelenMesaj[0].ToString() == "1")
                    {

                        if (GarsonList.Count > 0)
                        {
                            for (int i = 0; i < GarsonList.Count; i++)
                            {
                                if (GarsonList[i].Contains(gelenMesaj[1]) == false)
                                {
                                    GarsonList.Add(gelenMesaj);
                                    MessageBox.Show(gelenMesaj[1] + " online oldu");
                                    break;

                                }
                            }


                        }
                        else if (GarsonList.Count == 0)
                        {
                            GarsonList.Add(gelenMesaj);
                            MessageBox.Show(gelenMesaj[1] + " online oldu");

                        }

                        GarsonDurum(GarsonList);


                    }
                    else if (gelenMesaj[0].ToString() == "0")
                    {
                        for (int i = 0; i < GarsonList.Count; i++)
                        {

                            if (GarsonList[i].Contains(gelenMesaj[1].ToString()))
                            {
                                GarsonList.RemoveAt(i);
                                MessageBox.Show(gelenMesaj[1].ToString() + " adlı Garson artık online değil!");

                            }
                        }

                        GarsonDurum(GarsonList);

                    }

                });
            }
        }

        private void FormMutfak_FormClosed(object sender, FormClosedEventArgs e)
        {
            server.Stop();
            client.Disconnect();

            Application.Exit();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            server.Stop();

        }


        private void dgvGelenSiparis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int AdisyonId = Convert.ToInt32(dgvGelenSiparis.CurrentRow.Cells["Id"].Value);
            string masaAdi = dgvGelenSiparis.CurrentRow.Cells["Masa Adı"].Value.ToString();
            int index = Convert.ToInt32(dgvGelenSiparis.CurrentRow.Index);
            GroupboxOlustur(AdisyonId, dgvGelenSiparis, masaAdi, index);
        }

        public void GroupboxOlustur(int id, DataGridView dgv, string masaAdi, int sira)
        {
            Control[] controlArray = this.Controls.Find("groupPanel_" + id.ToString(), true);
            if (controlArray.Length == 0)
            {
                Panel groupPanel = new Panel();
                Panel panel0 = new Panel();
                Panel panel1 = new Panel();
                Panel panel2 = new Panel();
                Panel panel3 = new Panel();
                Button btnHazir = new Button();
                Button btnKapat = new Button();
                Label baslik = new Label();

                groupPanel.Controls.Add(panel0);
                groupPanel.Controls.Add(panel3);
                groupPanel.Controls.Add(btnHazir);
                panel3.Controls.Add(panel1);
                panel3.Controls.Add(panel2);
                panel0.Controls.Add(baslik);
                panel0.Controls.Add(btnKapat);

                panel0.Dock = DockStyle.Top;
                panel3.Dock = DockStyle.Fill;
                panel2.Dock = DockStyle.Right;
                panel1.Dock = DockStyle.Left;
                btnHazir.Dock = DockStyle.Bottom;
                baslik.Dock = DockStyle.Fill;
                btnKapat.Dock = DockStyle.Right;


                baslik.AutoSize = false;
                baslik.Text = "Masa Adı: " + masaAdi + "  -  " + "Adisyon ID: " + id;
                baslik.TextAlign = ContentAlignment.MiddleCenter;
                baslik.Font = new Font("Segoe UI", this.Width / 100);



                btnKapat.Size = new Size(30, 30);
                btnKapat.BackgroundImage = Restoran.Properties.Resources.exit;
                btnKapat.BackgroundImageLayout = ImageLayout.Center;
                btnKapat.BackColor = Color.Gray;
                btnKapat.SendToBack();

                groupPanel.Name = "groupPanel_" + id.ToString();
                groupPanel.BackColor = Color.White;
                groupPanel.Location = new Point(450 + (sira * 40), 72 + (sira * 50));
                groupPanel.Text = "Adisyon Id=" + id;
                groupPanel.Size = new Size(this.Width / 40 * 10, this.Height / 27 * 10);

                btnHazir.Text = "Sipariş hazır";
                btnHazir.Name = "btnHazir_" + id;
                btnHazir.Font = new Font("Segoe UI", this.Width / 120);
                btnHazir.Enabled = false;
                btnHazir.BackColor = Color.LightGray;

                panel0.BackColor = Color.Gray;
                panel0.Size = new Size(groupPanel.Width, 30);
                btnHazir.Size = new Size(groupPanel.Width, groupPanel.Height / 100 * 13);
                panel3.Size = new Size(groupPanel.Width, groupPanel.Height - panel0.Height - btnHazir.Height);
                panel2.Size = new Size(panel3.Width / 10 * 2, panel3.Height);
                panel1.Size = new Size(panel3.Width - panel2.Width, panel3.Height);

                baslik.MouseDown += baslik_MouseDown;
                baslik.MouseUp += baslik_MouseUp;
                baslik.MouseMove += baslik_MouseMove;
                btnKapat.Click += BtnKapat_Click;
                btnHazir.Click += (sender, e) => BtnHazir_Click(sender, e, masaAdi, id);


                labelUret(panel1, panel2, dgv, id);
                this.Controls.Add(groupPanel);
                this.Controls.SetChildIndex(groupPanel, 0);
            }

            if (Garson.veriCek("select * from Siparis where AdisyonId=" + id + " and Durum=0", "Id").Count == 0)
            {
                this.Controls.Find("btnHazir_" + id.ToString(), true)[0].Enabled = true;
                this.Controls.Find("btnHazir_" + id.ToString(), true)[0].BackColor = Color.LightGreen;

            }
            else
            {
                this.Controls.Find("btnHazir_" + id.ToString(), true)[0].Enabled = false;
                this.Controls.Find("btnHazir_" + id.ToString(), true)[0].BackColor = Color.LightGray;

            }
        }



        public void labelUret(Panel panel1, Panel panel2, DataGridView dgv, int id)
        {
            List<List<string>> liste = new List<List<string>>();
            liste.Clear();
            liste.Add(Garson.veriCek("select Urunler.Ad as 'Ürün Adı',Siparis.Aciklama as 'Açıklama', Siparis.Adet,Siparis.Durum from Siparis inner join Urunler on(Siparis.UrunId=Urunler.Id) where AdisyonId=" + id + "", "Ürün Adı"));
            liste.Add(Garson.veriCek("select Urunler.Ad as 'Ürün Adı',Siparis.Aciklama as 'Açıklama', Siparis.Adet,Siparis.Durum from Siparis inner join Urunler on(Siparis.UrunId=Urunler.Id) where AdisyonId=" + id + "", "Açıklama"));
            liste.Add(Garson.veriCek("select Urunler.Ad as 'Ürün Adı',Siparis.Aciklama as 'Açıklama', Siparis.Adet,Siparis.Durum from Siparis inner join Urunler on(Siparis.UrunId=Urunler.Id) where AdisyonId=" + id + "", "Adet"));
            liste.Add(Garson.veriCek("select Urunler.Ad as 'Ürün Adı',Siparis.Aciklama as 'Açıklama', Siparis.Adet,Siparis.Durum from Siparis inner join Urunler on(Siparis.UrunId=Urunler.Id) where AdisyonId=" + id + "", "Durum"));
            liste.Add(Garson.veriCek("select Id from Siparis where AdisyonId=" + id + "", "Id"));

            for (int i = 0; i < liste[0].Count; i++)
            {
                Label lbl = new Label();
                CheckBox checkbox = new CheckBox();
                lbl.Text = (i + 1) + "-) " + liste[0][i] + " (" + liste[1][i] + ")" + "   X " + liste[2][i];
                lbl.Font = new Font("Segoe UI", this.Width / 120);
                lbl.AutoSize = true;
                lbl.Location = new Point(5, 40 + (30 * i));
                lbl.ForeColor = Color.Black;
                lbl.Name = "lbl_" + id + "_" + i;

                checkbox.Name = "checkbox_" + id + "_" + i;
                checkbox.Text = "Durum";
                checkbox.Font = new Font("Segoe UI", this.Width / 120);
                checkbox.Location = new Point(0, 40 + (30 * i));
                checkbox.Checked = Convert.ToBoolean(liste[3][i]);

                int SiparisId = Convert.ToInt32(liste[4][i]);
                checkbox.CheckedChanged += (sender, e) => Checkbox_CheckedChanged(sender, e, SiparisId, id);

                panel1.Controls.Add(lbl);
                panel2.Controls.Add(checkbox);
            }
        }

        private void Checkbox_CheckedChanged(object sender, EventArgs e, int id, int AdisyonId)
        {
            CheckBox cbx = sender as CheckBox;


            if (cbx.Checked)
            {
                Garson.sorguGonder("update Siparis Set Durum=1 where Id=" + id + "");
            }
            else
            {
                Garson.sorguGonder("update Siparis Set Durum=0 where Id=" + id + "");

            }


            if (Garson.veriCek("select * from Siparis where AdisyonId=" + AdisyonId + " and Durum=0", "Id").Count == 0)
            {
                this.Controls.Find("btnHazir_" + AdisyonId.ToString(), true)[0].Enabled = true;
                this.Controls.Find("btnHazir_" + AdisyonId.ToString(), true)[0].BackColor = Color.LightGreen;

            }
            else
            {
                this.Controls.Find("btnHazir_" + AdisyonId.ToString(), true)[0].Enabled = false;
                this.Controls.Find("btnHazir_" + AdisyonId.ToString(), true)[0].BackColor = Color.LightGray;


            }
        }

        private void BtnHazir_Click(object sender, EventArgs e, string masaAdi, int AdisyonId)
        {
            Button btnHazir = sender as Button;
            int index = this.Controls.IndexOf(btnHazir.Parent);
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Bütün siparişler hazır.Gönderilsin mi?", "Sipariş Hazır Onayı", MessageBoxButtons.YesNo);

            bool siparisDurum = Convert.ToBoolean((Garson.veriCek("select * from Adisyon where Id=" + AdisyonId + "", "Hazir"))[0].ToString());
            if (dialog == DialogResult.Yes)
            {
                if (siparisDurum==false)
                {
                    Garson.sorguGonder("update Adisyon set Hazir=1 where Id="+AdisyonId+"");
                    List<string> Ad = Garson.veriCek("select Personel.Ad as 'Ad',Personel.Soyad as 'Soyad' from Adisyon inner join Personel on(Adisyon.PersonelId=Personel.Id) where Adisyon.Id=" + AdisyonId + "", "Ad");
                    List<string> Soyad = Garson.veriCek("select Personel.Ad as 'Ad',Personel.Soyad as 'Soyad' from Adisyon inner join Personel on(Adisyon.PersonelId=Personel.Id) where Adisyon.Id=" + AdisyonId + "", "Soyad");

                    for (int i = 0; i < GarsonList.Count; i++)
                    {


                        if (GarsonList[i][1].ToString() == Ad[0].ToString() + " " + Soyad[0].ToString() + "(Garson)")
                        {
                            ClientIp = GarsonList[i][2].ToString();
                            ClientPort = Convert.ToInt32(GarsonList[i][3]);
                        }
                        else if (i == GarsonList.Count - 1)
                        {
                            ClientIp = GarsonList[0][2].ToString();
                            ClientPort = Convert.ToInt32(GarsonList[0][3]);
                        }
                    }

                    try
                    {
                        client.Connect(ClientIp, ClientPort);
                        client.WriteLine("1,Masa '" + masaAdi + "' Hazır!");
                        client.Disconnect();
                        this.Controls.RemoveAt(index);
                        MessageBox.Show("Siparişler gönderildi!");
                    }
                    catch
                    {
                        MessageBox.Show("Garson aktif değil!");
                    }
                }
                else
                {
                    MessageBox.Show("Bu sipariş çoktan gönderildi!");
                }
            }
        }


        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Button btnKapat = sender as Button;
            int index = this.Controls.IndexOf(btnKapat.Parent.Parent);
            this.Controls.RemoveAt(index);

        }

        private void baslik_MouseUp(object sender, MouseEventArgs e)
        {
            panelMove = false;

        }

        private void baslik_MouseDown(object sender, MouseEventArgs e)
        {
            panelMove = true;
            panelLocation = e.Location;
        }

        private void baslik_MouseMove(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            int index = this.Controls.IndexOf(label.Parent.Parent);
            if (panelMove == true)
            {
                this.Controls[index].Location = new Point(this.Controls[index].Location.X + (e.Location.X - panelLocation.X), this.Controls[index].Location.Y + (e.Location.Y - panelLocation.Y));
            }
        }

        public void GarsonDurum(List<List<string>> GarsonList)
        {

            durumPanel.Controls.Clear();
            if (GarsonList.Count > 0)
            {

                for (int i = 0; i < GarsonList.Count; i++)
                {
                    Panel panel = new Panel();
                    Label label = new Label();

                    panel.Size = new Size(22, 22);
                    panel.Name = "GarsonDurum_" + i;
                    panel.BackColor = Color.LightGreen;
                    panel.Location = new Point(10, (btnCikis.Height / 2 * 3) + (btnCikis.Height / 2 * 3) * i);
                    label.Name = "GarsonIsim_" + i;
                    label.Text = GarsonList[i][1];
                    label.Font = new Font("Segoe UI", this.Width / 120);
                    label.AutoSize = true;
                    label.TextAlign = ContentAlignment.MiddleLeft;
                    label.Location = new Point(45, (btnCikis.Height / 2 * 3) + (btnCikis.Height / 2 * 3) * i);


                    durumPanel.Controls.Add(label);
                    durumPanel.Controls.Add(panel);
                    durumPanel.AutoSize = true;
                    durumPanel.Size = new Size(this.Width / 20, this.Height / 5 * 3);
                    durumPanel.Location = new Point(this.Width - durumPanel.Width - 10, btnCikis.Height / 2 * 3);

                }

            }
            else
            {
                MessageBox.Show("Bağlı Client Yok!");
            }

        }

    }
}
