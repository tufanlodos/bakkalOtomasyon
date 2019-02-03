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
        public void UrunSatisStokDusur(int UrunId,int Adet)
        {
            Urunler urn = ent.Urunlers.Where(u => u.Id == UrunId).FirstOrDefault();
            urn.StokMiktari -= Adet;
        }
        public void UrunIadeStokArtir(int UrunId, int Adet)
        {
            Urunler urn = ent.Urunlers.Where(u => u.Id == UrunId).FirstOrDefault();
            urn.StokMiktari += Adet;
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
        public bool SatisDetaySil(int Id)
        {
            bool Sonuc = false;
            SatisDetay silinen = ent.SatisDetay.Where(s => s.Id == Id).FirstOrDefault();
            ent.SatisDetay.Remove(silinen);
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
        public bool SatisKaldiMi(int SatisId)
        {
            bool Sonuc = true;
            bool Var = Convert.ToBoolean(ent.SatisDetay.Count(sd => sd.IslemId == SatisId));
            if (Var == false)
            {
                Sonuc = false;
            }
            return Sonuc;
        }
        public bool SatisSil(int Id)
        {
            bool Sonuc = false;
            Satis silinen = ent.Satislar.Where(s => s.Id == Id).FirstOrDefault();
            silinen.Silindi = true;
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
        public decimal SatisToplamTutarHesaplat(int SatisId)
        {
            return ent.SatisDetay.Where(sd => sd.IslemId == SatisId).Sum(sde => sde.ToplamTutar);
        }
        public void SatisToplamTutarGuncelle(int SatisId,decimal YeniTutar)
        {
            Satis s = ent.Satislar.Where(sa => sa.Id == SatisId).FirstOrDefault();
            s.ToplamTutar = YeniTutar;
        }
    }
}
