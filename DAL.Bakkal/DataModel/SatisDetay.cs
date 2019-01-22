using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Bakkal.DataModel
{
    [Table("SatisDetay")]
    public  class SatisDetay
    {
        public int Id { get; set; }
        public int IslemId { get; set; }
        public int UrunId { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
        public decimal BirimFiyat { get; set; }

        //Relations
        [ForeignKey("UrunId")]
        public virtual Urunler Urunler { get; set; }
        [ForeignKey("IslemId")]
        public virtual Satis Satislar { get; set; }
     

    }
}
