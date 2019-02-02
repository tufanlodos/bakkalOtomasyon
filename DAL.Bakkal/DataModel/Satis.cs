using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Bakkal.DataModel
{
    [Table("Satislar")]
    public class Satis
    {
        
        public int Id { get; set; }
       
        public string OdemeTipi { get; set; }
        [DefaultValue(false)]
        public bool Silindi { get; set; }
      
        public decimal ToplamTutar { get; set; }
        public DateTime IslemTarihi { get; set; }
        
        
        //Relation
        public virtual List<SatisDetay> SatisDetay { get; set; }

        public Satis()
        {
            Silindi = false;
            IslemTarihi = DateTime.Now;
        }


    }
}
