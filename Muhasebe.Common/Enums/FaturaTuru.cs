using System.ComponentModel;

namespace Muhasebe.Common.Enums
{
    public enum FaturaTuru : byte
    {
        [Description("Açık Fatura")]
        AcikFatura = 1,
        [Description("Kapalı Fatura")]
        KapaliFatura = 2,
    }
}