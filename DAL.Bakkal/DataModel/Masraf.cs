using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Bakkal.DataModel
{
    [Table("Masraf")]
   public class Masraf
    {
        private string _masrafAdi;
        public int Id { get; set; }
        public string MasrafAdi { get => _masrafAdi; set => _masrafAdi = value.Substring(0).ToUpper(); }
        public decimal Tutar { get; set; }
        public DateTime IslemTarihi { get; set; }

        public Masraf()
        {
            IslemTarihi = DateTime.Now;
        }

    }
}
