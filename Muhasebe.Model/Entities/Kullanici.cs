using Muhasebe.Model.Attributes;
using Muhasebe.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muhasebe.Model.Entities
{
    public class Kullanici : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = false), Kod("Kullanıcı Adı", "txtKullaniciAdi"), ZorunluAlan("Kullanıcı Adı", "txtKullaniciAdi")]
        public override string Kod { get; set; }

        [Required, StringLength(30), ZorunluAlan("Adı", "txtAdi")]
        public string Adi { get; set; }

        [Required, StringLength(30), ZorunluAlan("Soyadı", "txtSoyadi")]
        public string Soyadi { get; set; }

        [Required, StringLength(50), ZorunluAlan("E-Mail", "txtEmail")]
        public string Email { get; set; }

        [StringLength(32)]
        public string Sifre { get; set; }

        [StringLength(32)]
        public string GizliKelime { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}