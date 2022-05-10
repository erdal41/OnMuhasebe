using Muhasebe.Model.Attributes;
using Muhasebe.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muhasebe.Model.Entities
{
    public class Stok : BaseEntityDurum
    {
        //IsUnique = false ise her donem veya subede aynı makbuzlar listelenir. true olursa her donem ve sube için yeniden makbuz tanımlanır
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(100), ZorunluAlan("Stok Adı", "txtStokAdi")]
        public string StokAdi { get; set; }
        public long? BirimId { get; set; }

        [Column(TypeName = "money")]
        public decimal? AlisFiyati { get; set; }
        public byte? AlisKdvOrani { get; set; }

        [Column(TypeName = "money")]
        public decimal? SatisFiyati { get; set; }
        public byte? SatisKdvOrani { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }


        public Birim Birim { get; set; }
    }
}