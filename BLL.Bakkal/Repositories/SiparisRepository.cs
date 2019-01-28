using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Bakkal.DataModel;
using DAL.Bakkal.Models;

namespace BLL.Bakkal.Repositories
{
    public class SiparisRepository : ISiparisRepository
    {
        BCDContext ent = new BCDContext();

        public List<Kategoriler> KategorileriGetir()
        {
            return ent.Kategorilers.ToList();
        }
        public List<Urunler> UrunleriGetirByKategoriId(int KatId)
        {
            List<Urunler> liste = (from u in ent.Urunlers
                                   where u.KategoriId == KatId
                                   select u).ToList();
            return liste;
        }
        public List<Tedarikci> TedarikcileriGetir()
        {
            return ent.Tedarikci.ToList();
        }
        public decimal UrunFiyatiGetirById(int UrunId)
        {
            return Convert.ToDecimal(ent.Urunlers.Where(u => u.Id == UrunId).Select(u => u.AlisFiyat).FirstOrDefault());
        }
        public bool SiparisEkle(Siparis s)
        {
            bool Sonuc = false;
            ent.Siparis.Add(s);
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
        public List<SiparisModel> SiparisleriGetir ()
        {
            List<SiparisModel> liste = ent.Siparis.Select(s=> new SiparisModel {Id = s.Id, UrunAdi = s.Urun.UrunAdi, TedarikciAdi = s.Tedarikci.TedarikciAdi.ToString(), Miktar = s.Miktar, Tutar = s.Tutar, IslemTarihi = s.IslemTarihi}).ToList();
            return liste;
        }
        public bool SiparisGuncelle()
        {
            bool Sonuc = false;
            try
            {
                ent.SaveChanges();
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string mesaj = ex.Message;
            }
            return Sonuc;
        }

        public bool SiparisSil(int Id)
        {
            bool Sonuc = false;
            Siparis silinen = ent.Siparis.Where(s=>s.Id == Id).FirstOrDefault();
            ent.Siparis.Remove(silinen);
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


        public decimal ToplamTutarHesapla()
        {
            return ent.Siparis.Sum(s => s.Tutar);
        }
        public decimal YeniToplamTutarHesapla(int UrunId,int Adet)
        {
            decimal YeniTutar = 0, AlisFiyat=0;
            AlisFiyat = Convert.ToDecimal(ent.Urunlers.Where(u => u.Id == UrunId).Select(u => u.AlisFiyat).FirstOrDefault());
            YeniTutar = AlisFiyat * Adet;
            return YeniTutar;
        }
        public int UrunIdBul(string UrunAdi)
        {
            return Convert.ToInt32(ent.Urunlers.Where(u => u.UrunAdi == UrunAdi).Select(u => u.Id).FirstOrDefault());
        }
        public List<SiparisModel> TariheGoreSiparisSirala(string nece)
        {
            List<SiparisModel> liste = new List<SiparisModel>();
            if (nece == "asc")
            {
                liste = ent.Siparis.Select(s => new SiparisModel { Id = s.Id, UrunAdi = s.Urun.UrunAdi, TedarikciAdi = s.Tedarikci.TedarikciAdi.ToString(), Miktar = s.Miktar, Tutar = s.Tutar, IslemTarihi = s.IslemTarihi }).OrderBy(s => s.IslemTarihi).ToList();
            }
            if (nece == "desc")
            {
                liste = ent.Siparis.Select(s => new SiparisModel { Id = s.Id, UrunAdi = s.Urun.UrunAdi, TedarikciAdi = s.Tedarikci.TedarikciAdi.ToString(), Miktar = s.Miktar, Tutar = s.Tutar, IslemTarihi = s.IslemTarihi }).OrderByDescending(s => s.IslemTarihi).ToList();
            }
            return liste;
        }
        public List<SiparisModel> TutaraGoreSiparisSirala(string nece)
        {
            List<SiparisModel> liste = new List<SiparisModel>();
            if (nece == "asc")
            {
                liste = ent.Siparis.Select(s => new SiparisModel { Id = s.Id, UrunAdi = s.Urun.UrunAdi, TedarikciAdi = s.Tedarikci.TedarikciAdi.ToString(), Miktar = s.Miktar, Tutar = s.Tutar, IslemTarihi = s.IslemTarihi }).OrderBy(s => s.Tutar).ToList();
            }
            if (nece == "desc")
            {
                liste = ent.Siparis.Select(s => new SiparisModel { Id = s.Id, UrunAdi = s.Urun.UrunAdi, TedarikciAdi = s.Tedarikci.TedarikciAdi.ToString(), Miktar = s.Miktar, Tutar = s.Tutar, IslemTarihi = s.IslemTarihi }).OrderByDescending(s => s.Tutar).ToList();
            }
            return liste;
        }
        public List<SiparisModel> MiktaraGoreSiparisSirala(string nece)
        {
            List<SiparisModel> liste = new List<SiparisModel>();
            if (nece == "asc")
            {
                liste = ent.Siparis.Select(s => new SiparisModel { Id = s.Id, UrunAdi = s.Urun.UrunAdi, TedarikciAdi = s.Tedarikci.TedarikciAdi.ToString(), Miktar = s.Miktar, Tutar = s.Tutar, IslemTarihi = s.IslemTarihi }).OrderBy(s => s.Miktar).ToList();
            }
            if (nece == "desc")
            {
                liste = ent.Siparis.Select(s => new SiparisModel { Id = s.Id, UrunAdi = s.Urun.UrunAdi, TedarikciAdi = s.Tedarikci.TedarikciAdi.ToString(), Miktar = s.Miktar, Tutar = s.Tutar, IslemTarihi = s.IslemTarihi }).OrderByDescending(s => s.Miktar).ToList();
            }
            return liste;
        }
    }
}
