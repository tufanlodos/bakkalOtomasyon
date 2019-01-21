using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakkalOtomasyon.DataModel
{
    [Table("Urunler")]
    public class Urunler
    {
        public int Id { get; set; }
        public string UrunKodu { get; set; }
        public string UrunMarka { get; set; }
        public string UrunAdi { get; set; }
        public decimal SatisFiyat { get; set; }
        public int KategoriId { get; set; }
        public int StokMiktari { get; set; }

        [DefaultValue(false)]
        public bool Silindi { get; set; }


        //Relations
        [ForeignKey("KategoriId")]
        public virtual Kategoriler Kategori { get; set; }

        public virtual List<SatisDetay> SatisDetaylari { get; set; }

        public virtual List<Siparis> Siparis { get; set; }
        public virtual List<TedarikDetay> TedarikDetaylari { get; set; }


    }
}
