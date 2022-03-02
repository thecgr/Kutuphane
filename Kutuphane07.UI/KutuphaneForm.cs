using Kutuphane07.DATA.Class;
using MetroFramework;
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
    public partial class KutuphaneForm : MetroForm
    {
        private readonly Kullanici girisYapan;
        KutuphaneYoneticisi kutuphaneYoneticisi;
        public KutuphaneForm(Kullanici girisYapan)
        {
            InitializeComponent();
            this.girisYapan = girisYapan;
        }

        private void TurleriYukle()
        {
            cmbTurler.Items.Add("Hepsi");
            cmbTurler.Items.AddRange(Enum.GetValues(typeof(KitapTurEnum)).Cast<object>().ToArray());
            cmbTurler.SelectedIndex = 0;
        }

        private void KutuphaneForm_Load(object sender, EventArgs e)
        {
            try
            {
                VerileriOku();
            }
            catch (Exception)
            {
                kutuphaneYoneticisi = new KutuphaneYoneticisi();
            }
            TurleriYukle();
            Listele();
        }

        private void VerileriOku()
        {
            string json = File.ReadAllText(KutuphaneYoneticisi.path);
            kutuphaneYoneticisi = JsonConvert.DeserializeObject<KutuphaneYoneticisi>(json);
        }
        private void VerileriKaydet()
        {
            string json = JsonConvert.SerializeObject(kutuphaneYoneticisi);
            File.WriteAllText(KutuphaneYoneticisi.path, json);
        }

        private void Listele()
        {
            dgvKitaplar.DataSource = null;
            if (!string.IsNullOrEmpty(txtArama.Text) && cmbTurler.SelectedIndex != 0)
            {
                //iki kriter geçerli
                dgvKitaplar.DataSource = kutuphaneYoneticisi.Kitaplar
                    .Where(x => x.Ad
                    .ToLower()
                    .Contains(txtArama.Text.ToLower())
                    &&
                    x.KitapTur == (KitapTurEnum)cmbTurler.SelectedItem)
                    .ToList();
            }
            else if (!string.IsNullOrEmpty(txtArama.Text) && cmbTurler.SelectedIndex == 0)
            {
                //hepsi içerisinde arama geçerli
                dgvKitaplar.DataSource = kutuphaneYoneticisi.Kitaplar
                    .Where(x => x.Ad
                    .ToLower()
                    .Contains(txtArama.Text.ToLower()))
                    .ToList();
            }
            else if (cmbTurler.SelectedIndex != 0)
            {
                //tür kriteri geçerli
                dgvKitaplar.DataSource = kutuphaneYoneticisi.Kitaplar
                    .Where(x => x.KitapTur == (KitapTurEnum)cmbTurler.SelectedItem)
                    .ToList();
            }
            else
            {
                dgvKitaplar.DataSource = kutuphaneYoneticisi.Kitaplar.ToList();
            }
            dgvKitaplar.Columns[0].Visible = false;//Id kolonunu gizledik.
            dgvKitaplar.Columns[1].HeaderText = "Kitap Adı";
            dgvKitaplar.Columns[2].HeaderText = "Basım Tarihi";
            dgvKitaplar.Columns[3].HeaderText = "Kitap Türü";
            dgvKitaplar.Columns[4].HeaderText = "Yazar Ad";
            dgvKitaplar.Columns[5].HeaderText = "Sayfa Sayısı";
            dgvKitaplar.Columns[6].HeaderText = "Açıklama";
            dgvKitaplar.Columns[7].Visible = true;//Oduncalinmatarihini gizledik.
        }
        private void dgvKitaplar_MouseClick_1(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                int position = dgvKitaplar.HitTest(e.X, e.Y).RowIndex;
                if (position >= 0)
                {
                    if (girisYapan.KullaniciAdi != "admin")
                    {
                        contextMenuStrip1.Items[1].Visible = false;
                        //adı admin olmayan kullanıcılar imha et butonunu göremeyecek.
                    }
                    contextMenuStrip1.Show(dgvKitaplar, new Point(e.X, e.Y));
                    dgvKitaplar.Rows[position].Selected = true;//sağ click yaptığım satırı seç
                }
            }
        }

        private void tsmiCikisYap_Click_1(object sender, EventArgs e)
        {
            VerileriKaydet();
            Close();
        }

        private void tsmiBagisYap_Click_1(object sender, EventArgs e)
        {
            BagisForm bagisForm = new BagisForm(kutuphaneYoneticisi);
            DialogResult dr = bagisForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Listele();
            }
        }
        private void tsmiHesabim_Click_1(object sender, EventArgs e)
        {
            HesabimForm hesabimForm = new HesabimForm(girisYapan, kutuphaneYoneticisi);
            hesabimForm.ShowDialog();
            Listele();

        }
        private void tsmiKitapOduncAl_Click_1(object sender, EventArgs e)
        {
            if (((Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem).OduncAlinmaTarihi != null)
            {
                MetroMessageBox.Show(this, "Kitap kullanımda!", "Bilgilendirme");
                return;
            }
            Guid kitapId = ((Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem).Id;
            kutuphaneYoneticisi.KitapOduncAl(girisYapan, kitapId);
            Listele();
        }
        private void tsmiKitapImhaEt_Click_1(object sender, EventArgs e)
        {
            Guid imhaEdilecekKitapId = ((Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem).Id;
            string kitapAd = ((Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem).Ad;
            DialogResult dr = MetroMessageBox.Show(this, $"{kitapAd} silinecek onaylıyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                kutuphaneYoneticisi.KitapImhaEt(imhaEdilecekKitapId);
                Listele();
            }
        }
        private void KutuphaneForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }

        private void cmbTurler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }

    }
}
