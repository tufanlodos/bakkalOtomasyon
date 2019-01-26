using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Bakkal.DataModel;

namespace BLL.Bakkal.Repositories
{
    public class SiparisRepository : ISiparisRepository
    {
        BCDContext ent = new BCDContext();

        public List<Kategoriler> KategorileriGetir()
        {
            return ent.Kategorilers.ToList();
        }
        public List<Urunler> UrunleriGetir()
        {
            return ent.Urunlers.ToList();
        }
        public List<Tedarikci> TedarikcileriGetir()
        {
            return ent.Tedarikci.ToList();
        }
        public decimal UrunFiyatiGetirById(int UrunId)
        {
            return Convert.ToDecimal(ent.Urunlers.Where(u => u.Id == UrunId).Select(u => u.AlisFiyat));
        }
        public bool SiparisEkle()
        {
            throw new NotImplementedException();
        }

        public bool SiparisGuncelle()
        {
            throw new NotImplementedException();
        }

        public bool SiparisSil()
        {
            throw new NotImplementedException();
        }


        public int ToplamTutarHesapla()
        {
            throw new NotImplementedException();
        }
    }
}
