using Muhasebe.Model.Entities.Base;

namespace Muhasebe.Model.Dto
{
    public class KullaniciList : BaseEntity
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string Aciklama { get; set; }
    }
}