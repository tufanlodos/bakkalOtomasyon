using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Bakkal.DataModel
{
    [Table("Siparis")]
    public  class Siparis
    {
        public int Id { get; set; }
        public int TedarikciId { get; set; }

        public int UrunId { get; set; }
        public int Miktar { get; set; }
        public decimal Tutar { get; set; }
        public DateTime IslemTarihi { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        //relation
        [ForeignKey("TedarikciId")]

        public virtual Tedarikci Tedarikci { get; set; }
        [ForeignKey("UrunId")]
        public virtual Urunler Urun { get; set; }


    }
}
