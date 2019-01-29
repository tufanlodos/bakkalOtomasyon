using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Bakkal.DataModel
{
    [Table("Kategoriler")]
    public class Kategoriler
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        public bool Silindi { get; set; }
        //Relations
        public virtual List<Urunler> Urunler { get; set; }
        
    }
}
