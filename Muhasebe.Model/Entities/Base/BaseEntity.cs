using Muhasebe.Model.Attributes;
using Muhasebe.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muhasebe.Model.Entities.Base
{
    public class BaseEntity : IBaseEntity
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Column(Order = 1), Required, StringLength(50), Kod("Kod", "txtKod"), ZorunluAlan("Kod", "txtKod")]
        public virtual string Kod { get; set; }
    }
}