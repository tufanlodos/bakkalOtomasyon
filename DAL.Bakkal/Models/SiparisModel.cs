using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Bakkal.Models
{
    public class SiparisModel
    {
        public int Id { get; set; }
        public string TedarikciAdi { get; set; }
        public string UrunAdi { get; set; }
        public int Miktar { get; set; }
        public decimal Tutar { get; set; }
        public DateTime IslemTarihi { get; set; }
    }
}
