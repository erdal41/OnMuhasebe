using Muhasebe.Model.Attributes;
using Muhasebe.Model.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muhasebe.Model.Entities
{
    public class Il : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("İl Adı", "txtIlAdi")]
        public string IlAdi { get; set; }
        public long UlkeId { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }


        public Ulke Ulke { get; set; }

        [InverseProperty("Il")]
        public ICollection<Ilce> Ilce { get; set; }
    }
}