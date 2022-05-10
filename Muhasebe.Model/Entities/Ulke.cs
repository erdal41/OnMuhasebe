using Muhasebe.Model.Attributes;
using Muhasebe.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muhasebe.Model.Entities
{
    public class Ulke : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Ülke Adı", "txtUlkeAdi")]
        public string UlkeAdi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        [InverseProperty("Ulke")]
        public ICollection<Il> Il { get; set; }
    }
}