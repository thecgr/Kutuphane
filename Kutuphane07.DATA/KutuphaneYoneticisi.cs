using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane07.DATA.Class
{
    public class KutuphaneYoneticisi
    {
        public static readonly string path = Environment.CurrentDirectory.Replace("Kutuphane07.UI\\bin\\Debug", "") + "kutuphaneveri.json";
        public KutuphaneYoneticisi()
        {
            Kitaplar = new List<Kitap>();
        }
        public List<Kitap> Kitaplar { get; set; }
        public void KitapBagisYap(string ad, DateTime basimTarihi, KitapTurEnum kitapTur, string yazarAd, int sayfaSayisi, string aciklama)
        {
            Kitaplar.Add(new Kitap()
            {
                Ad = ad,
                Aciklama = aciklama,
                BasimTarihi = basimTarihi,
                KitapTur = kitapTur,
                SayfaSayisi = sayfaSayisi,
                YazarAd = yazarAd
            });
        }
        public void KitapImhaEt(Guid kitapId)
        {
            Kitap imhaEdilecekKitap = Kitaplar.FirstOrDefault(x => x.Id == kitapId);
            Kitaplar.Remove(imhaEdilecekKitap);
        }
        public void KitapOduncAl(Kullanici kullanici, Guid kitapId)
        {
            //kitabın oduncalinmatarihini set ederiz ve kullanıcının odunc alınan kitaplarına ekleriz.
            Kitap kitap = Kitaplar.FirstOrDefault(x => x.Id == kitapId);
            kitap.OduncAlinmaTarihi = DateTime.Now;
            kullanici.OduncAlinanKitaplar.Add(kitap);
        }
        public void KitapTeslimEt(Kullanici kullanici, Guid kitapId)
        {
            //kullanıcının odunc alınan kitaplarından silinir, odunc alinma tarihi null yapılır.
            Kitap kitap = Kitaplar.FirstOrDefault(x => x.Id == kitapId);
            kitap.OduncAlinmaTarihi = null;
            kullanici.OduncAlinanKitaplar.Remove(kitap);
        }
    }
}
