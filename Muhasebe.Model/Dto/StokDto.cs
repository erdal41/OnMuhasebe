using Muhasebe.Model.Entities;
using Muhasebe.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muhasebe.Model.Dto
{
    [NotMapped]
    public class StokSingle : Stok
    {
        public string BirimAdi { get; set; }        
    }

    public class StokList : BaseEntity
    {
        public string StokAdi { get; set; }
        public string BirimAdi { get; set; }
        public decimal? AlisFiyati { get; set; }
        public byte? AlisKdvOrani { get; set; }
        public decimal? SatisFiyati { get; set; }
        public byte? SatisKdvOrani { get; set; }
        public string Aciklama { get; set; }
    }
}