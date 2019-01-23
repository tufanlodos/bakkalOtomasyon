using DAL.Bakkal.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Bakkal.Repositories
{
    public class UrunRepository : IUrunRepository
    {
        BCDContext ent = new BCDContext();

        public List<Urunler> UrunleriGetir()
        {
            List<Urunler> liste = (from p in ent.Urunlers
                                        select new Urunler { Id = p.Id, UrunKodu=p.UrunKodu,UrunMarka=p.UrunMarka, SatisFiyat=p.SatisFiyat, UrunAdi = p.UrunAdi, AlisFiyat = p.AlisFiyat, KategoriId=p.KategoriId, StokMiktari=p.StokMiktari }).ToList();
            return liste;
        }
        public bool UrunKontrol(Urunler yeni)
        {
            int Sayisi = (from p in ent.Urunlers
                          where p.UrunAdi == yeni.UrunAdi && p.KategoriId == yeni.KategoriId
                          select p).Count();
            return Convert.ToBoolean(Sayisi);
        }
        public bool GuncellemeUrunKontrol(Urunler degisen)
        {
            var Urun = ent.Urunlers.Where(p => p.UrunAdi == degisen.UrunAdi && p.KategoriId == degisen.KategoriId && p.Id != degisen.Id).FirstOrDefault();
            if (Urun != null)
                return true;
            return false;
        }
        public Urunler UrunGetirByID(int ID)
        {
            Urunler degisen = ent.Urunlers.Where(p => p.Id == ID).FirstOrDefault();
            return degisen;
        }
        public bool UrunEkle(Urunler p)
        {
            bool Sonuc = false;
            //Önce arakatmana eklenir.
            ent.Urunlers.Add(p);
            try
            {
                ent.SaveChanges(); //Arakatmana göre veritabanı güncellenir.
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }
        public bool UrunGuncelle()
        {
            bool Sonuc = false;
            try
            {
                ent.SaveChanges(); //Arakatmana göre veritabanı güncellenir.
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }
        public bool UrunSil(Urunler silinen)
        {
            bool Sonuc = false;
            //Önce arakatmandan silinir.
            ent.Urunlers.Remove(silinen);
            try
            {
                ent.SaveChanges(); //Arakatmana göre veritabanı güncellenir.
                Sonuc = true;
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
            return Sonuc;
        }
    }
}
