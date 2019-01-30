using DAL.Bakkal.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Bakkal.Repositories
{
    public interface IUrunRepository
    {
        List<Urunler> UrunleriGetir();
        List<Urunler> UrunGetirByKategoriID(int ID);
        List<Urunler> UrunGetirByKategoriAdi(string kAdi);
        List<Urunler> UrunGetirByMarka(string UrunMarkasi);
        bool UrunKontrol(Urunler yeni);
        bool GuncellemeUrunKontrol(Urunler degisen);
        Urunler UrunGetirByID(int ID);
        bool UrunEkle(Urunler p);
        bool UrunGuncelle();
        bool UrunSil(Urunler silinen);
        List<Urunler> UrunSiralaByUrunAdi(string nece);
        List<Urunler> UrunSiralaByKategoriAdi(string nece);
        List<Urunler> UrunSiralaByMarka(string nece);
        List<Urunler> UrunSiralaBySatisFiyati(string nece);
        List<Urunler> UrunSiralaByAlisFiyati(string nece);
        List<Urunler> UrunSiralaByStok(string nece);
       

    }
}
