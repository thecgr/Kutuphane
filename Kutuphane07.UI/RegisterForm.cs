using Kutuphane07.DATA.Class;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane07.UI
{
    public partial class RegisterForm : MetroForm
    {
        private readonly KullaniciYoneticisi kullaniciYoneticisi;

        public RegisterForm(KullaniciYoneticisi kullaniciYoneticisi)
        {
            InitializeComponent();
            this.kullaniciYoneticisi = kullaniciYoneticisi;
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            bool kullaniciAdi = KullaniciAdiKontrol();
            bool parola = ParolaKontrol();
            bool adSoyad = AdSoyadKontrol();
            if (kullaniciAdi && parola && adSoyad)
            {
                btnKayitOl.Enabled = true;
            }
            else
            {
                btnKayitOl.Enabled = false;
            }
        }

        private bool AdSoyadKontrol()
        {
            if (!string.IsNullOrEmpty(txtAdSoyad.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool KullaniciAdiKontrol()
        {
            bool KullaniciVarmi = kullaniciYoneticisi.KullaniciVarMi(txtKullaniciAdi.Text);
            if (KullaniciVarmi || string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                lblKullaniciAdi.ForeColor = Color.Red;
                lblKullaniciAdi.Text = "Kullanıcı Adı Geçersiz!";
                return false;
            }
            else
            {
                lblKullaniciAdi.ForeColor = Color.Green;
                lblKullaniciAdi.Text = "Kullanıcı Adı Uygun!";
                return true;
            }
        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {
            bool kullaniciAdi = KullaniciAdiKontrol();
            bool parola = ParolaKontrol();
            bool adSoyad = AdSoyadKontrol();
            if (kullaniciAdi && parola && adSoyad)
            {
                btnKayitOl.Enabled = true;
            }
            else
            {
                btnKayitOl.Enabled = false;
            }
        }

        private bool ParolaKontrol()
        {
            if (txtParola.Text != txtParolaTekrar.Text || string.IsNullOrEmpty(txtParola.Text) || string.IsNullOrEmpty(txtParolaTekrar.Text))
            {
                lblParola.ForeColor = Color.Red;
                lblParola.Text = "Parola Geçersiz!";
                return false;
            }
            else
            {
                lblParola.ForeColor = Color.Green;
                lblParola.Text = "Parola Uygun!";
                return true;
            }
        }
        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            bool kullaniciAdi = KullaniciAdiKontrol();
            bool parola = ParolaKontrol();
            bool adSoyad = AdSoyadKontrol();
            if (kullaniciAdi && parola && adSoyad)
            {
                btnKayitOl.Enabled = true;
            }
            else
            {
                btnKayitOl.Enabled = false;
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            bool basariliMi = kullaniciYoneticisi.KayitOl(txtAdSoyad.Text, txtKullaniciAdi.Text, txtParola.Text, txtParolaTekrar.Text);
            if (basariliMi)
            {
                MetroMessageBox.Show(this, "Başarıyla kayıt oldunuz!", "BAŞARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MetroMessageBox.Show(this, "Kayıt işlemi başarısız. Lütfen tekrar deneyiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
