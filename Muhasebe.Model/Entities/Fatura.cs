using Muhasebe.Common.Enums;
using Muhasebe.Model.Attributes;
using Muhasebe.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muhasebe.Model.Entities
{
    public class Fatura : BaseEntity
    {
        [Index("IX_Kod", IsUnique = false), Kod("Fatura No", "txtFaturaNo"), ZorunluAlan("Fatura No", "txtFaturaNo")]
        public override string Kod { get; set; }
        public FaturaTipi FaturaTipi { get; set; } = FaturaTipi.Satis;

        [Column(TypeName = "date")]
        public DateTime FaturaTarihi { get; set; } = DateTime.Now.Date;
        public DateTime VadeTarihi { get; set; } = DateTime.Now.Date;
        public FaturaTuru FaturaTuru { get; set; } = FaturaTuru.AcikFatura;

        [StringLength(30)]
        public string IrsaliyeNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime IrsaliyeTarihi { get; set; } = DateTime.Now.Date;
        public long? CariId { get; set; }

        [StringLength(1000)]
        public string Aciklama { get; set; }

        [Column(TypeName = "money")]
        public decimal IlkTutar { get; set; }

        [Column(TypeName = "money")]
        public decimal Iskonto { get; set; }

        [Column(TypeName = "money")]
        public decimal NetTutar { get; set; }

        [Column(TypeName = "money")]
        public decimal KdvTutari { get; set; }

        [Column(TypeName = "money")]
        public decimal ToplamTutar { get; set; }

        [StringLength(50)]
        public string ToplamTutarYazi { get; set; }


        public Cari Cari { get; set; }
        public ICollection<StokBilgileri> StokBilgileri { get; set; }
        public ICollection<CariHareketleri> CariHareketleri { get; set; }
    }
}