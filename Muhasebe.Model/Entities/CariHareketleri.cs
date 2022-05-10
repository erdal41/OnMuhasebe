using Muhasebe.Common.Enums;
using Muhasebe.Model.Attributes;
using Muhasebe.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muhasebe.Model.Entities
{
    public class CariHareketleri : BaseEntity
    {
        [Index("IX_Kod", IsUnique = false), ZorunluAlan("Hareket Fişi Kodu", "txtKod")]
        public override string Kod { get; set; }

        [ZorunluAlan("Hesap Kodu", "txtHesapKodu")]
        public string HesapKodu { get; set; }
        public long? FaturaId { get; set; }
        public long? CariId { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now.Date;

        [StringLength(50)]
        public string BelgeNo { get; set; }
        public BelgeTuru BelgeTuru { get; set; } = BelgeTuru.Dekont;
        public OdemeTipi OdemeTipi { get; set; } = OdemeTipi.Nakit;

        [StringLength(500)]
        public string Aciklama { get; set; }

        [Column(TypeName = "money")]
        public decimal? Borc { get; set; }

        [Column(TypeName = "money")]
        public decimal? Alacak { get; set; }


        public Fatura Fatura { get; set; }
        public Cari Cari { get; set; }
    }
}
