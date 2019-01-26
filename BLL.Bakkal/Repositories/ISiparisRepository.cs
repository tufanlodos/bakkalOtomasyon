using DAL.Bakkal.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Bakkal.Repositories
{
    public interface ISiparisRepository
    {
        List<Urunler> UrunleriGetir();
        List<Urunler> UrunleriGetirByKategoriId(int KategoriId);
        List<Kategoriler> KategorileriGetir();
        List<Kategoriler> KategorileriGetirByUrunId(int UrunId);
        List<Tedarikci> TedarikcileriGetir();
        int UrunFiyatiGetirById(int UrunId);
        int ToplamTutarHesapla();
        bool SiparisEkle();
        bool SiparisGuncelle();
        bool SiparisSil();
    }
}
