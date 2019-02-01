using DAL.Bakkal.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Bakkal.Repositories
{
    public interface ITedarikEkraniRepository
    {
        bool Guncelle();
        bool Sil(int Id);
        bool Kaydet();
        Tedarikci TedarikciGetirbByID(int ID);
        List<string> UrunleriGetirByTedarikciId(int Id);
        List<Tedarikci> TedarikciSecin(string tedarikci);
        List<Urunler> UrunSecin(string urun);
        List<Tedarikci> TedarikciListele();
        decimal BirimFiyatGetirByUrunAd(string uAdi,int tId);


    }
}
