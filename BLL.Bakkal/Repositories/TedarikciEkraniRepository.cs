﻿using DAL.Bakkal.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Bakkal.Repositories
{
  public  class TedarikciEkraniRepository
    {
        //hiç kullanılmamış
        BCDContext ent = new BCDContext();
        public Tedarikci TedarikciGetirByID(int ID)
        {
            Tedarikci degisen = (from t in ent.Tedarikci
                                   where t.Id == ID
                                   select t).FirstOrDefault();
            return degisen;
        }
         public Tedarikci TedarikciGetirByAdSoyad(string tedarikciAdiSoyadi)
        {
           Tedarikci adiSoyadi = (from t in ent.Tedarikci
                                   where t.TedarikciAdi == tedarikciAdiSoyadi
                                   select t).FirstOrDefault();
            return adiSoyadi;
        }
    }
}
