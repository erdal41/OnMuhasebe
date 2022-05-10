using System.ComponentModel;

namespace Muhasebe.Common.Enums
{
    public enum CariHesapTuru : int
    {
        [Description("Alıcı")]
        Alici = 120,
        [Description("Satıcı")]
        Satici = 320,        
    }
}