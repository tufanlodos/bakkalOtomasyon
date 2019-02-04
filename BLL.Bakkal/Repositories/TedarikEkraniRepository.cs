using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Bakkal.DataModel;
using System.Data.Entity;

namespace BLL.Bakkal.Repositories
{
    public class TedarikEkraniRepository : ITedarikEkraniRepository
    {
        BCDContext ent = new BCDContext();
        public bool Guncelle()
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

        public bool Kaydet()
        {
            throw new NotImplementedException();
        }

        public bool Sil(int ID)
        {
            bool Sonuc = false;
            Tedarikci silinen = (from c in ent.Tedarikci
                                   where c.Id == ID
                                   select c).FirstOrDefault();
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
        public Tedarikci TedarikciGetirbByID(int ID)
        {
            return ent.Tedarikci.Where(t => t.Id == ID && t.Silindi == false).FirstOrDefault();
        }

        public List<string> UrunleriGetirByTedarikciId(int Id)
        {
            List<string> liste = ent.TedarikDetay.Where(td => td.TedarikciId == Id).Select(td=>td.Urun.UrunAdi).ToList();
           
            return liste;
        }
        public List<string> DistinctUrunleriGetir()
        {
            List<string> liste = ent.Urunlers.Select(td => td.UrunAdi).Distinct().ToList();

            return liste;
        }
        public decimal BirimFiyatGetirByUrunAd(string uAdi)
        {
            return ent.Urunlers.Where(td => td.UrunAdi==uAdi).Select(td=>td.AlisFiyat).FirstOrDefault();
        }

      


        public List<Tedarikci> TedarikciSecin(string tedarikci)
        {
            return ent.Tedarikci.Where(k => k.Silindi == false).ToList();
        }

        public List<Tedarikci> TedarikciListele()
        {
            return ent.Tedarikci.Where(k => k.Silindi == false).ToList();
        }

        public List<Urunler> UrunSecin(string urun)
        {
            return ent.Urunlers.Where(k => k.Silindi == false).ToList();
        }
        public List<Urunler> UrunGetir()
        {
            return ent.Urunlers.Where(k => k.Silindi == false).ToList();
        }

        public int TedarikciIdGetirByTedarikciAdi(string tedarikciAdi)
        {
            Tedarikci td = ent.Tedarikci.Where(t => t.TedarikciAdi == tedarikciAdi).FirstOrDefault();
            return td.Id;
        }

        public int UrunIdGetirByUrunAdi(string urunAdi)
        {
            Urunler ur = ent.Urunlers.Where(u => u.UrunAdi == urunAdi).FirstOrDefault();
            return ur.Id;
        }
        public void UrunStokMiktariniArttir(int urunId,int adet)
        {
            Urunler ur = ent.Urunlers.Where(u => u.Id == urunId).FirstOrDefault();
            ur.StokMiktari += adet;
            try
            {
                ent.SaveChanges();
                
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }

        }

        public bool TedarikDetayEkle(TedarikDetay t)
        {
            bool Sonuc = false;
            ent.TedarikDetay.Add(t);
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
        public bool YeniTedarikciEkle(Tedarikci t)
        {
            bool Sonuc = false;
            ent.Tedarikci.Add(t);
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
        public bool TedarikciKontrolByKAdi(string yeni)
        {
            return Convert.ToBoolean(ent.Tedarikci.Where(k => k.TedarikciAdi.ToLower() == yeni.ToLower()).ToList().Count);
        }






    }
}
