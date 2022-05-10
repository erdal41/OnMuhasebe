using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using Muhasebe.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muhasebe.Model.Dto
{
    [NotMapped]
    public class CariSingle : Cari
    {
        public string IlceAdi { get; set; }
        public string IlAdi { get; set; }
        public string UlkeAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }

    public class CariList : BaseEntity
    {
        public string CariAdi { get; set; }
        public CariHesapTuru CariHesapTuru { get; set; }
        public string TcKimlikNo { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Telefon3 { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string Adres { get; set; }
        public string PostaKodu { get; set; }
        public string IlceAdi { get; set; }
        public string IlAdi { get; set; }
        public string UlkeAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string Aciklama { get; set; }
    }
}