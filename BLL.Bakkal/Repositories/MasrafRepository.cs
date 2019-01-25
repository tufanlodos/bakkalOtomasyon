using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Bakkal.DataModel;

namespace BLL.Bakkal.Repositories
{
    public class MasrafRepository : IMasrafRepository
    {
        BCDContext ent = new BCDContext();
        public List<Masraf> MasraflariGetir()
        {
            return ent.Masraf.ToList();
        }

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
    }
}
