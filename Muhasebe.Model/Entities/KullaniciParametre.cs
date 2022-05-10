using Muhasebe.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Muhasebe.Model.Entities
{
    public class KullaniciParametre : BaseEntity
    {
        [Index("IX_Kod", IsUnique = false)]
        public override string Kod { get; set; }
        public long KullaniciId { get; set; }

        [StringLength(100)]
        public string DefaultNoktaVurusluYazici { get; set; }
        public int TableViewCaptionForeColor { get; set; } = Color.Maroon.ToArgb();
        public int TableColumnHeaderForeColor { get; set; } = Color.Maroon.ToArgb();
        public int TableBandPanelForeColor { get; set; } = Color.DarkBlue.ToArgb();
        [Column(TypeName = "image")] public byte[] ArkaPlanResmi { get; set; }


        public Kullanici Kullanici { get; set; }
    }
}