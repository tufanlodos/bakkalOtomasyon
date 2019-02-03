using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Bakkal.DataModel;

namespace BLL.Bakkal.Repositories
{
    public class MasrafRepository : IMasrafRepository
    {
        BCDContext ent = new BCDContext();
        public bool MasrafEkle(Masraf masraf)
        {
            bool Sonuc = false;
            ent.Masraf.Add(masraf);
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

        public bool MasrafDegistir()
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

        public bool MasrafSil(int Id)
        {
            bool Sonuc = false;
            Masraf silinen = (from m in ent.Masraf
                                where m.Id == Id
                                select m).FirstOrDefault();
            ent.Masraf.Remove(silinen);
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
        public bool MasrafSil(string MasrafAd)
        {
            bool Sonuc = false;
            Masraf silinen = (from m in ent.Masraf
                                where m.MasrafAdi == MasrafAd
                                select m).FirstOrDefault();
            ent.Masraf.Remove(silinen);
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
        public bool MasrafKontrol(Masraf yeni)
        {
            return Convert.ToBoolean(ent.Masraf.Where(m => m.MasrafAdi.ToLower() == yeni.MasrafAdi.ToLower() && m.Tutar == yeni.Tutar).ToList().Count);
        }
        public List<Masraf> TariheGoreMasrafSirala(string nece)
        {
            List<Masraf> liste = new List<Masraf>();
            if (nece == "asc")
            {
                liste = ent.Masraf.OrderBy(m=>m.IslemTarihi).ToList();
            }
            if (nece == "desc")
            {
                liste = ent.Masraf.OrderByDescending(m=>m.IslemTarihi).ToList();
            }
            return liste;
        }
        public List<Masraf> TutaraGoreMasrafSirala(string nece)
        {
            List<Masraf> liste = new List<Masraf>();
            if (nece == "asc")
            {
                liste = ent.Masraf.OrderBy(m => m.Tutar).ToList();
            }
            if (nece == "desc")
            {
                liste = ent.Masraf.OrderByDescending(m => m.Tutar).ToList();
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
    }
}
