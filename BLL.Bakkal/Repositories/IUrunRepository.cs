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
        bool UrunKontrol(Urunler yeni);
        bool GuncellemeUrunKontrol(Urunler degisen);
        Urunler UrunGetirByID(int ID);
        bool UrunEkle(Urunler p);
        bool UrunGuncelle();
        bool UrunSil(Urunler silinen);
       
    }
}
