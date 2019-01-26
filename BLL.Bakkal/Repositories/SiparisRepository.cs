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
            throw new NotImplementedException();
        }

        public List<Kategoriler> KategorileriGetirByUrunId(int UrunId)
        {
            throw new NotImplementedException();
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

        public List<Tedarikci> TedarikcileriGetir()
        {
            throw new NotImplementedException();
        }

        public int ToplamTutarHesapla()
        {
            throw new NotImplementedException();
        }

        public int UrunFiyatiGetirById(int UrunId)
        {
            throw new NotImplementedException();
        }

        public List<Urunler> UrunleriGetir()
        {
            throw new NotImplementedException();
        }

        public List<Urunler> UrunleriGetirByKategoriId(int KategoriId)
        {
            throw new NotImplementedException();
        }
    }
}
