using Muhasebe.Model.Attributes;
using Muhasebe.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muhasebe.Model.Entities
{
    public class Birim : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }

        [Required, StringLength(25), ZorunluAlan("Birim Adı", "txtBirimAdi")]
        public string BirimAdi { get; set; }

        [Required, StringLength(5), ZorunluAlan("Birim Kısa Adı", "txtBirimKisaAdi")]
        public string BirimKisaAdi { get; set; }

        [StringLength(250)]
        public string Aciklama { get; set; }
    }
}