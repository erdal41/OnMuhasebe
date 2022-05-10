using DevExpress.DataAccess.ObjectBinding;
using Muhasebe.Model.Entities;
using Muhasebe.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muhasebe.Model.Dto
{
    [NotMapped]
    public class StokBilgileriList : StokBilgileri, IBaseHareketEntity
    {
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string BirimAdi { get; set; }
        public decimal MiktarTutari { get; set; }
        public decimal IskontoTutari { get; set; }
        public decimal KdvHaricTutar { get; set; }
        public decimal KdvTutari { get; set; }
        public decimal Tutar { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }

    [HighlightedClass]
    public class StokBilgileriRapor
    {
        public long FaturaId { get; set; }
        public string MiktarBirim { get; set; }
        public string StokAdi { get; set; }
        public StokBilgileriRapor StokBilgileri { get; set; }
    }
}