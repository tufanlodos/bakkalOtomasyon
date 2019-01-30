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
        private string _kategoriAdi;
        public int Id { get; set; }
        public string KategoriAdi { get => _kategoriAdi; set => _kategoriAdi = value.Substring(0,1).ToUpper() + value.Substring(1).ToLower(); }
        public string Aciklama { get; set; }
        public bool Silindi { get; set; }
        //Relations
        public virtual List<Urunler> Urunler { get; set; }

        public override string ToString()
        {
            return KategoriAdi;
        }
    }
}
