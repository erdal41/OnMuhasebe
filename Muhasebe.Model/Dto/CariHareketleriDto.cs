using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using Muhasebe.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muhasebe.Model.Dto
{
    [NotMapped]
    public class CariHareketleriSingle : CariHareketleri
    {
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
    }

    public class CariHareketleriList : BaseEntity
    {
        public long? FaturaId { get; set; }
        public string HesapKodu { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public DateTime? Tarih { get; set; }
        public TimeSpan Saat { get; set; }
        public string BelgeNo { get; set; }
        public BelgeTuru BelgeTuru { get; set; }
        public OdemeTipi OdemeTipi { get; set; }
        public string Aciklama { get; set; }
        public decimal? Borc { get; set; }
        public decimal? Alacak { get; set; }
        public decimal? Bakiye { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}