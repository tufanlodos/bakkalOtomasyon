using DAL.Bakkal.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Bakkal.Repositories
{
    public class StokRepository : IStokRepository
    {
        BCDContext ent = new BCDContext();

        public List<Kategoriler> KategoriGetir()
        {
            return ent.Kategorilers.ToList();
        }
        public List<Urunler> UrunGetirByKategoriID(int ID)
        {
           List<Urunler> liste = (from p in ent.Urunlers
                                  where p.KategoriId==ID
                                        select p).ToList();
            return liste;
        }
        public List<Urunler> UrunleriGetir()
        {
            List<Urunler> liste = (from p in ent.Urunlers
                                        select p ).ToList();
            return liste;
        }
        public List<Urunler> UrunGetirByUrunID(int ID)
        {
            List<Urunler> liste = (from p in ent.Urunlers
                                   where p.Id == ID
                                   select p).ToList();
            return liste;
        }

        
    }
}
using DAL.Bakkal.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Bakkal.Repositories
{
    public class StokRepository : IStokRepository
    {
        BCDContext ent = new BCDContext();

       

    }
}
