using Muhasebe.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muhasebe.Model.Entities
{
    public class StokBilgileri : BaseHareketEntity
    {
        public long FaturaId { get; set; }
        public long StokId { get; set; }
        public long Miktar { get; set; }

        [Column(TypeName = "money")]
        public decimal? BirimFiyati { get; set; }

        [Column(TypeName = "money")]
        public byte? IskontoOrani { get; set; }
        public byte? KdvOrani { get; set; }


        public Fatura Fatura { get; set; }
        public Stok Stok { get; set; }
    }
}