﻿using DAL.Bakkal.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Bakkal.Repositories
{
    public interface IStokRepository
    {
        List<Kategoriler> KategoriGetir();
        
        List<Urunler> UrunGetirByKategoriID(int ID);
        List<Urunler> UrunleriGetir();
        List<Urunler> UrunGetirByUrunID(int ID);
        bool KritikVarMi();


    }
}
