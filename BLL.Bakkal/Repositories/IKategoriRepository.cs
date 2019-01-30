using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Bakkal.DataModel;

namespace BLL.Bakkal.Repositories
{
    public interface IKategoriRepository
    {
        bool KategoriEkle(Kategoriler k);
        bool KategoriGuncelle();
        bool KategoriSil(Kategoriler k);
        bool KategoriSil(int ID);
        List<Kategoriler> KategoriListele();
        List<Kategoriler> KategoriGetirByArama(string Arama);


    }
}
