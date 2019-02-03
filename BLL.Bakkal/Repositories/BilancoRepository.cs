using DAL.Bakkal.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Bakkal.Repositories
{
    public class BilancoRepository : IBilancoRepository
    {
        BCDContext ent = new BCDContext();
        public decimal MasrafTutar(int x)
        {
            if (x == 0 && ent.Masraf.Where(m => m.IslemTarihi.Day == DateTime.Now.Day).FirstOrDefault() != null) // Son gün
            {
                return ent.Masraf.Where(m => m.IslemTarihi.Day == DateTime.Now.Day).Sum(m => m.Tutar);
            }
            else if (x == 1)
                return ent.Masraf.Where(m => m.IslemTarihi.Day >= DateTime.Now.Day - 7).Sum(m => m.Tutar);
            else if (x == 2)
                return ent.Masraf.Where(m => m.IslemTarihi.Day >= DateTime.Now.Day - 30).Sum(m => m.Tutar);
            else
                return 0;
        }
        

        public decimal SatisTutar(int x)
        {
            if (x == 0 && ent.Satislar.Where(m => m.IslemTarihi.Day == DateTime.Now.Day).FirstOrDefault() != null)     // Son gün
               return ent.Satislar.Where(m => m.IslemTarihi.Day == DateTime.Now.Day).Sum(m => m.ToplamTutar);
            else if (x == 1)
                return ent.Satislar.Where(m => m.IslemTarihi.Day >= DateTime.Now.Day - 7).Sum(m => m.ToplamTutar);
            else if (x == 2)
                return ent.Satislar.Where(m => m.IslemTarihi.Day >= DateTime.Now.Day - 30).Sum(m => m.ToplamTutar);
            else return 0;
        }

        public decimal TedarikTutar(int x)
        {
            if (x == 0 && ent.TedarikDetay.Where(m => m.IslemTarihi.Day == DateTime.Now.Day).FirstOrDefault() != null)     // Son gün
                return ent.TedarikDetay.Where(m => m.IslemTarihi.Day == DateTime.Now.Day).Sum(m => m.ToplamTutar);
            else if (x == 1)
                return ent.TedarikDetay.Where(m => m.IslemTarihi.Day >= DateTime.Now.Day - 7).Sum(m => m.ToplamTutar);
            else if (x == 2)
                return ent.TedarikDetay.Where(m => m.IslemTarihi.Day >= DateTime.Now.Day - 30).Sum(m => m.ToplamTutar);
            else return 0;
        }
    }
}
