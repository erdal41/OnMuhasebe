using System.ComponentModel;

namespace Muhasebe.Common.Enums
{
    public enum BelgeTuru : byte
    {
        [Description("Dekont")]
        Dekont = 1,
        [Description("Makbuz")]
        Makbuz = 2,
        [Description("Fatura")]
        Fatura = 3,
    }
}