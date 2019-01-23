using DAL.Bakkal.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Bakkal.Repositories
{
    public interface IMasrafRepository
    {
        List<Masraf> MasraflariGetir();
        bool MasrafEkle(Masraf masraf);
        bool MasrafDegistir(int Id);
        bool MasrafSil(int Id);
    }
}
