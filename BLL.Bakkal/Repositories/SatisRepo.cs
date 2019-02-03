using DAL.Bakkal.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Bakkal.Repositories
{
    public class SatisRepo
    {
        BCDContext ent = new BCDContext();
        public Urunler UrunBul(string UrunKod)
        {
            return ent.Urunlers.Where(u => u.UrunKodu == UrunKod).FirstOrDefault();
        }
        public Urunler AdaGoreUrunBul(string UrunAd)
        {
            return ent.Urunlers.Where(u => u.UrunAdi == UrunAd).FirstOrDefault();
        }
        public List<Urunler> UrunleriGetir()
        {
            return ent.Urunlers.ToList();
        }
        public bool SatislaraEkle(Satis s)
        {
            bool Sonuc = false;
            ent.Satislar.Add(s);
            try
            {
                ent.SaveChanges();
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }
        public int SonSatisIdBul()
        {
            Satis sat = ent.Satislar.OrderByDescending(s => s.IslemTarihi).FirstOrDefault();
            return sat.Id;
        }
        public int UrunIdBul(string UrunAd)
        {
            Urunler urn = ent.Urunlers.Where(u => u.UrunAdi == UrunAd).FirstOrDefault();
            return urn.Id;
        }
        public string UrunAdBul(int UrunId)
        {
            Urunler urn = ent.Urunlers.Where(u => u.Id == UrunId).FirstOrDefault();
            return urn.UrunAdi;
        }
        public bool SatisDetayaEkle(SatisDetay sd)
        {
            bool Sonuc = false;
            ent.SatisDetay.Add(sd);
            try
            {
                ent.SaveChanges();
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }
        public List<Satis> SatislariGetir()
        {
            return ent.Satislar.Where(s=>s.Silindi == false).OrderByDescending(sa=>sa.IslemTarihi).ToList();
        }
        public List<SatisDetay> IdyeGoreSatisDetaylariGetir(int SatisId)
        {
            return ent.SatisDetay.Where(s => s.IslemId == SatisId).ToList();
        }
        
    }
}
