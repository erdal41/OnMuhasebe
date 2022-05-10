using DevExpress.DataAccess.ObjectBinding;
using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using Muhasebe.Model.Entities.Base;
using Muhasebe.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muhasebe.Model.Dto
{
    [NotMapped]
    public class FaturaSingle : Fatura
    {
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string TamAdres { get; set; }
    }

    public class FaturaList : BaseEntity
    {
        public FaturaTipi FaturaTipi { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public DateTime VadeTarihi { get; set; }
        public FaturaTuru FaturaTuru { get; set; }
        public string IrsaliyeNo { get; set; }
        public DateTime IrsaliyeTarihi { get; set; }
        public long? CariId { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string TamAdres { get; set; }
        public string Aciklama { get; set; }
        public decimal IlkTutar { get; set; }
        public decimal Iskonto { get; set; }
        public decimal NetTutar { get; set; }
        public decimal KdvTutari { get; set; }
        public decimal ToplamTutar { get; set; }
        public string ToplamTutarYazi { get; set; }
    }

    [HighlightedClass]
    public class IrsaliyeRapor : IBaseEntity
    {
        public long FaturaId { get; set; }
        public DateTime IrsaliyeTarihi { get; set; }
        public string CariAdi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string TamAdres { get; set; }
        public IEnumerable<StokBilgileriRapor> StokBilgileri { get; set; }
    }
}