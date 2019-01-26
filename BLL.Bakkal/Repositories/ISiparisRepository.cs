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
        List<Kategoriler> KategorileriGetir();
        List<Urunler> UrunleriGetirByKategoriId(int KatId);
        List<Tedarikci> TedarikcileriGetir();
        decimal UrunFiyatiGetirById(int UrunId);
        int ToplamTutarHesapla();
        bool SiparisEkle();
        bool SiparisGuncelle();
        bool SiparisSil();
    }
}
