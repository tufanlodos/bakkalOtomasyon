using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakkalOtomasyon.DataModel
{
    [Table("Tedarikci")]
    public  class Tedarikci
    {
        public int Id { get; set; }
        public string TedarikciAdi { get; set; }
        public string IletisimNo { get; set; }
        public string Adres { get; set; }

        [DefaultValue(false)]
        public bool Silindi { get; set; }

        public virtual List<TedarikDetay> TedarikDetaylar { get; set; }
        public virtual List<Siparis> Siparisler { get; set; }


    }
}
