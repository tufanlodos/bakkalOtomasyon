﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Bakkal.Repositories
{
    public interface IBilancoRepository
    {
        decimal MasrafTutar(int x);
        decimal TedarikTutar(int x);
        decimal SatisTutar(int x);
    }
}
