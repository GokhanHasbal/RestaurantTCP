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
    public partial class Form1 : Form
    {

        // public static Garson garson = new Garson();

        public Point moveForm = new Point(0, 0);
        public bool moveStatus = false;
        public int sayac = 0;
        public int durum = 0;
        public static string LocalHostIp = Garson.GetLocalIPAddress();


        static FormGarson formGarson = new FormGarson();
        static FormMudur formMudur = new FormMudur();
        static FormMutfak formMutfak = new FormMutfak();
        public bool ServerDurum = false;
        public string ServerUzakIp;



        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            picLoading.Location = new Point(grpBoxGirisEkrani.Location.X + grpBoxGirisEkrani.Width / 10 * 3, grpBoxGirisEkrani.Location.Y + grpBoxGirisEkrani.Height / 10 * 2);
            labelBaslik.Location = new Point((this.Width - labelBaslik.Width) / 2, labelBaslik.Location.Y);

            txtKullaniciAdi.Text = "ahmet";
            txtSifre.Text = "123";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            formGarson.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            moveStatus = true;
            moveForm = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            moveStatus = false;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveStatus == true)
            {
                this.Location = new Point(this.Location.X + (e.Location.X - moveForm.X), this.Location.Y + (e.Location.Y - moveForm.Y));
            }
        }

        public void btnGiris_Click(object sender, EventArgs e)
        {
            if (ServerDurum = true)
            {
                Garson.sqlAyarla(txtSqlip.Text);
            }
            else
            {
                Garson.sqlAyarla(LocalHostIp);

            }
            durum = 0;
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            try
            {
                Garson.db.Open();

                string sorgu = "select * from Personel where KullaniciAdi='" + kullaniciAdi + "' and Sifre='" + sifre + "'";
                SqlCommand cmd = new SqlCommand(sorgu, Garson.db);

                SqlDataReader veriOku = cmd.ExecuteReader();

                if (veriOku.Read())
                {
                    grpBoxGirisEkrani.Enabled = false;
                    picLoading.Visible = true;
                    timerGiris.Start();
                    if (Convert.ToInt32(veriOku["YetkiId"]) == 1)
                    {
                        formMudur.mudurKullanici = veriOku["Ad"].ToString() + " " + veriOku["Soyad"].ToString() + "(Müdür)";
                        formMudur.personel_id = Convert.ToInt32(veriOku["Id"]);
                        durum = 1;
                    }
                    else if (Convert.ToInt32(veriOku["YetkiId"]) == 2)
                    {
                        formMutfak.mutfakKullanici = veriOku["Ad"].ToString() + " " + veriOku["Soyad"].ToString() + "(Şef)";
                        formMutfak.personelId = Convert.ToInt32(veriOku["Id"]);
                        durum = 2;
                        FormMutfak.localHostIp = LocalHostIp;


                        //formMutfak.ServerIp = LocalHostIp;



                    }
                    else if (Convert.ToInt32(veriOku["YetkiId"]) == 3)
                    {
                        FormGarson.GarsonKullanici = veriOku["Ad"].ToString() + " " + veriOku["Soyad"].ToString() + "(Garson)";
                        FormGarson.personel_id = Convert.ToInt32(veriOku["Id"]);
                        FormGarson.localHostIp = LocalHostIp;
                        durum = 3;
                    }

                }
                else
                {
                    MessageBox.Show("Hatalı giriş! Lütfen bilgileri kontrol ediniz!");

                }

                Garson.db.Close();
            }
            catch
            {
                MessageBox.Show("Sql Server adresi Hatalı veya Server aktif değil!");
            }

        }

        private void timerGiris_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 1)
            {
                picLoading.Visible = false;
                grpBoxGirisEkrani.Enabled = true;
                timerGiris.Stop();
                this.Hide();

                if (durum == 1)
                {
                    formMudur.Show();

                }
                else if (durum == 2)
                {
                    formMutfak.Show();
                }
                else if (durum == 3)
                {
                    formGarson.Show();


                }


            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void labelSifreUnuttum_Click(object sender, EventArgs e)
        {
            FormSifremiUnuttum formSifremiUnuttum = new FormSifremiUnuttum();

            formSifremiUnuttum.ShowDialog();
        }

        private void btnSqlBaglan_Click(object sender, EventArgs e)
        {
            if (txtSqlip.Text != "")
            {
                MessageBox.Show("Bilgiler alındı!");
                ServerDurum = true;

            }
            else
            {
                MessageBox.Show("Lütfen Sql Server IP adresini giriniz!");
                ServerDurum = false;
            }
        }
    }
}
