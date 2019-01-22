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
        public int Id { get; set; }
        public string MasrafAdi { get; set; }
        public decimal Tutar { get; set; }
        public DateTime IslemTarihi { get; set; }

    }
}
