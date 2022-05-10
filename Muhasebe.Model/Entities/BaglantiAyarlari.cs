using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities.Base;
using System.Security;

namespace Muhasebe.Model.Entities
{
    public class BaglantiAyarlari : BaseEntity
    {
        public string Server { get; set; }
        public YetkilendirmeTuru YetkilendirmeTuru { get; set; }
        public SecureString KullaniciAdi { get; set; }
        public SecureString Sifre { get; set; }
    }
}