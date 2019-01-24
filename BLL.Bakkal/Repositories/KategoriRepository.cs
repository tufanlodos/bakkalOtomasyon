using DAL.Bakkal.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Bakkal.Repositories
{
   public class KategoriRepository : IKategoriRepository
    {
        BCDContext ent = new BCDContext();

        public bool KategoriEkle(Kategoriler k)
        {
            bool Sonuc = false;
            ent.Kategorilers.Add(k);
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

        public Kategoriler KategoriGetirByID(int ID)
        {
            Kategoriler degisen = (from c in ent.Kategorilers
                                where c.Id == ID
                                select c).FirstOrDefault();
            return degisen;
        }
        public bool KategoriKontrol(Kategoriler yeni)
        {
            return Convert.ToBoolean(ent.Kategorilers.Where(k => k.KategoriAdi == yeni.KategoriAdi).ToList().Count);
        }
        public bool KategoriKontrolFromDegistir(Kategoriler yeni)
        {
            return Convert.ToBoolean(ent.Kategorilers.Where(k => k.KategoriAdi == yeni.KategoriAdi && k.Id != yeni.Id).ToList().Count);
        }
        public bool KategoriGuncelle()
        {
            bool Sonuc = false;
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

        //public List<Kategoriler> KategoriListele()
        //{
        //    //return ent.Kategorilers.Where(k => k.Silindi == false).ToList();
        //}

        public bool KategoriSil(Kategoriler k)
        {
            bool Sonuc = false;
            ent.Kategorilers.Remove(k);
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

        public bool KategoriSil(int ID)
        {
            bool Sonuc = false;
            Kategoriler silinen = (from c in ent.Kategorilers
                                where c.Id == ID
                                select c).FirstOrDefault();
            //silinen.Silindi = true;
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

        public List<Kategoriler> KategoriListele()
        {
            return ent.Kategorilers.Where(k => k.Silindi == false).ToList();
        }
    }
}
