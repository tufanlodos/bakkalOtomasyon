using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Bakkal.DataModel
{
    [Table("TedarikDetay")]
   public class TedarikDetay
    {

        public int Id { get; set; }
        public int TedarikciId { get; set; }

        public int UrunId { get; set; }

        public int Adet { get; set; }

        public decimal BirimTutar { get; set; }

        public decimal ToplamTutar { get; set; }
        public DateTime IslemTarihi { get; set; }

        //relation
        [ForeignKey("TedarikciId")]

        public virtual Tedarikci Tedarikci { get; set; }
        [ForeignKey("UrunId")]
        public virtual Urunler Urun { get; set; }

    }
}
