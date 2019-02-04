using DAL.Bakkal.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            return ent.Urunlers.Where(u=>u.Silindi==false).ToList();
        }
        public bool UrunKontrol(Urunler yeni)
        {
            int Sayisi = (from p in ent.Urunlers
                          where p.UrunAdi == yeni.UrunAdi && p.KategoriId == yeni.KategoriId
                          select p).Count();
            return Convert.ToBoolean(Sayisi);
        }

        public Urunler UrunGetirByID(int ID)
        {
            Urunler degisen = ent.Urunlers.Where(p => p.Id == ID && p.Silindi == false).FirstOrDefault();
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
        public bool UrunSil(int Id)
        {
            bool Sonuc = false;
            Urunler silinen = (from u in ent.Urunlers
                              where u.Id == Id
                              select u).FirstOrDefault();
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

        public List<Urunler> UrunGetirByKategoriID(int ID)
        {
            return ent.Urunlers.Where(u => u.KategoriId == ID && u.Silindi == false).ToList();
        }

        public List<Urunler> UrunGetirByMarka(string UrunMarkasi)
        {
            return ent.Urunlers.Where(u => u.UrunMarka==UrunMarkasi && u.Silindi == false).ToList();
        }

        public List<Urunler> UrunGetirByKategoriAdi(string kAdi)
        {
            return ent.Urunlers.Where(u => u.Kategori.KategoriAdi.StartsWith(kAdi) && u.Silindi == false).ToList();
        }

        public List<Urunler> UrunGetirByUrunAdi(string urunAdi)
        {
            return ent.Urunlers.Where(u => u.UrunAdi.Contains(urunAdi) && u.Silindi == false).ToList();
        }

        public List<Urunler> UrunSiralaByUrunAdi(string nece, int KategoriID)
        {
            List<Urunler> liste = new List<Urunler>();
            if (nece == "asc")
            {
                if(KategoriID==0)
                    liste = ent.Urunlers.Where(u => u.Silindi == false).OrderBy(u => u.UrunAdi).ToList();
                else
                    liste = ent.Urunlers.Where(u => u.Silindi == false &&u.KategoriId==KategoriID).OrderBy(u => u.UrunAdi).ToList();

            }
            if (nece == "desc")
            {
                if (KategoriID == 0)
                    liste = ent.Urunlers.Where(u => u.Silindi == false).OrderByDescending(u => u.UrunAdi).ToList();
                else
                    liste = ent.Urunlers.Where(u => u.Silindi == false && u.KategoriId == KategoriID).OrderByDescending(u => u.UrunAdi).ToList();
            }
            return liste;
        }
        public List<Urunler> UrunSiralaByKategoriAdi(string nece, int KategoriID)
        {
            List<Urunler> liste = new List<Urunler>();
            if (nece == "asc")
            {
                if(KategoriID==0)
                liste = ent.Urunlers.Where(u => u.Silindi == false).OrderBy(u => u.Kategori.KategoriAdi).ToList();
                else
                liste = ent.Urunlers.Where(u => u.Silindi == false && u.KategoriId == KategoriID).OrderBy(u => u.Kategori.KategoriAdi).ToList();
            }
            if (nece == "desc")
            {
                if(KategoriID==0)
                liste = ent.Urunlers.Where(u => u.Silindi == false).OrderByDescending(u => u.Kategori.KategoriAdi).ToList();
                else
                liste = ent.Urunlers.Where(u => u.Silindi == false && u.KategoriId == KategoriID).OrderByDescending(u => u.Kategori.KategoriAdi).ToList();
            }
            return liste;
        }
        public List<Urunler> UrunSiralaByStok(string nece, int KategoriID)
        {
            List<Urunler> liste = new List<Urunler>();
            if (nece == "asc")
            {
                if(KategoriID==0)
                    liste = ent.Urunlers.Where(u => u.Silindi == false).OrderBy(u => u.StokMiktari).ToList();
                else 
                    liste = ent.Urunlers.Where(u => u.Silindi == false && u.KategoriId == KategoriID).OrderBy(u => u.StokMiktari).ToList();
            }
            if (nece == "desc")
            {
                if(KategoriID==0)
                liste = ent.Urunlers.Where(u => u.Silindi == false).OrderByDescending(u => u.StokMiktari).ToList();
                else
                    liste = ent.Urunlers.Where(u => u.Silindi == false && u.KategoriId == KategoriID).OrderByDescending(u => u.StokMiktari).ToList();
            }
            return liste;
        }

        public void ContextteBekleyenleriTemizle()
        {
            var ContextteBekleyenler = ent.ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added ||
                            e.State == EntityState.Modified ||
                            e.State == EntityState.Deleted)
                .ToList();

            foreach (var entry in ContextteBekleyenler)
                entry.State = EntityState.Detached;
        }
        
        //public List<Urunler> UrunSiralaByMarka(string nece)
        //{
        //    List<Urunler> liste = new List<Urunler>();
        //    if (nece == "asc")
        //    {
        //        liste = ent.Urunlers.OrderBy(u => u.UrunMarka).ToList();
        //    }
        //    if (nece == "desc")
        //    {
        //        liste = ent.Urunlers.OrderByDescending(u => u.UrunMarka).ToList();
        //    }
        //    return liste;
        //}
        //public List<Urunler> UrunSiralaBySatisFiyati(string nece)
        //{
        //    List<Urunler> liste = new List<Urunler>();
        //    if (nece == "asc")
        //    {
        //        liste = ent.Urunlers.OrderBy(u => u.SatisFiyat).ToList();
        //    }
        //    if (nece == "desc")
        //    {
        //        liste = ent.Urunlers.OrderByDescending(u => u.SatisFiyat).ToList();
        //    }
        //    return liste;
        //}
        //public List<Urunler> UrunSiralaByAlisFiyati(string nece)
        //{
        //    List<Urunler> liste = new List<Urunler>();
        //    if (nece == "asc")
        //    {
        //        liste = ent.Urunlers.OrderBy(u => u.AlisFiyat).ToList();
        //    }
        //    if (nece == "desc")
        //    {
        //        liste = ent.Urunlers.OrderByDescending(u => u.AlisFiyat).ToList();
        //    }
        //    return liste;
        //}
        public List<string> UrunIdGetirByTeraikciID(int id)
        {
            TedarikDetay tedd= ent.TedarikDetay.Where(td => td.TedarikciId == id).FirstOrDefault();
            int uid = tedd.UrunId;
            List<string> liste = (from u in ent.Urunlers
                                  where u.Id == uid
                                  select u.UrunAdi).ToList();
            return liste;
        }

        public bool KritikVarMi()
        {
            return Convert.ToBoolean(ent.Urunlers.Where(u => u.StokMiktari < 20).Count());
        }
        public List<Urunler> KritikUrunleriGetir()
        {
            return ent.Urunlers.Where(u => u.StokMiktari < 20 && u.Silindi == false).ToList();
        }
    }
}
