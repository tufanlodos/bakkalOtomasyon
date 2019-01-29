﻿using DAL.Bakkal.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Bakkal.Repositories
{
    public interface IMasrafRepository
    {
        bool MasrafEkle(Masraf masraf);
        bool MasrafDegistir();
        bool MasrafSil(int Id);
    }
}
