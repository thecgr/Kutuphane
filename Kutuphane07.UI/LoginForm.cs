using Kutuphane07.DATA.Class;
using MetroFramework.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane07.UI
{
    public partial class LoginForm : MetroForm
    {
        KullaniciYoneticisi kullaniciYoneticisi;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtParola.Text))
            {
                Kullanici girisYapanKullanici = kullaniciYoneticisi.GirisYap(txtKullaniciAdi.Text,txtParola.Text);
                if (girisYapanKullanici != null)
                {
                KutuphaneForm kutuphaneForm = new KutuphaneForm(girisYapanKullanici);
                kutuphaneForm.ShowDialog();
                }
                else 
                {
                    MessageBox.Show("Kullanıcı adı ya da parola hatalı!");
                }
            }
            else 
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifrenizi giriniz");
            }

        }

        private void linkLblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerform = new RegisterForm(kullaniciYoneticisi);
            registerform.ShowDialog();  
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(kullaniciYoneticisi);
            File.WriteAllText(KullaniciYoneticisi.path, json);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                string json = File.ReadAllText(KullaniciYoneticisi.path);
                kullaniciYoneticisi = JsonConvert.DeserializeObject<KullaniciYoneticisi>(json);
            }
            catch (Exception)
            {
                kullaniciYoneticisi = new KullaniciYoneticisi();
            }
        }
    }
}
