using Muhasebe.Common.Enums;
using Muhasebe.Model.Attributes;
using Muhasebe.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muhasebe.Model.Entities
{
    public class Cari : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Cari Adı", "txtCariAdi")]
        public string CariAdi { get; set; }
        public CariHesapTuru CariHesapTuru { get; set; } = CariHesapTuru.Alici;

        [StringLength(14)]
        public string TcKimlikNo { get; set; }

        [StringLength(17)]
        public string Telefon1 { get; set; }

        [StringLength(17)]
        public string Telefon2 { get; set; }

        [StringLength(17)]
        public string Telefon3 { get; set; }

        [StringLength(17)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Website { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string VergiDairesi { get; set; }

        [StringLength(20)]
        public string VergiNo { get; set; }

        [StringLength(300)]
        public string Adres { get; set; }

        [StringLength(20)]
        public string PostaKodu { get; set; }
        public long? IlceId { get; set; }
        public long? IlId { get; set; }
        public long? UlkeId { get; set; }
        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }


        public Ilce Ilce { get; set; }
        public Il Il { get; set; }
        public Ulke Ulke { get; set; }
        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }
        public virtual ICollection<CariHareketleri> CariHareketleri { get; set; }
    }
}
