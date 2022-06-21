using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class FormSifremiUnuttum : Form
    {
        Form1 form1 = new Form1();
        Garson garson = new Garson();
        public FormSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnSifreUnuttum_Click(object sender, EventArgs e)
        {

            List<string> KullaniciListesi = new List<string>();
            labelSifreUnuttum.Text = "";
            if (txtSifreUnuttum.Text != "")
            {
                KullaniciListesi.Clear();
                KullaniciListesi = garson.veriCek("select * from Personel where KullaniciAdi='" + txtSifreUnuttum.Text + "'", "Sifre");

                if (KullaniciListesi.Count > 0)
                {
                    labelSifreUnuttum.Text = "Şifreniz " + KullaniciListesi[0].Length.ToString() + " karakterlidir.İpucu yetersiz ise Müdüre başvurunuz!";

                }
                else
                {

                    labelSifreUnuttum.Text = "Böyle bir kullanıcı adı yok!Lütfen tekrar deneyiniz!";

                }




            }
            else
            {
                labelSifreUnuttum.Text = "Lütfen Kullanıcı Adını giriniz!";
            }
            btnExit.Location = new Point(this.Width - 29, -1);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
