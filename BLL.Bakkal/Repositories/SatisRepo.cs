using DAL.Bakkal.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Bakkal.Repositories
{
    public class SatisRepo
    {
        BCDContext ent = new BCDContext();
        public Urunler UrunBul(string UrunKod)
        {
            return ent.Urunlers.Where(u => u.UrunKodu == UrunKod).FirstOrDefault();
        }
    }
}
