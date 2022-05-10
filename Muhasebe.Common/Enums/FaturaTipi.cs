using System.ComponentModel;

namespace Muhasebe.Common.Enums
{
    public enum FaturaTipi : byte
    {
        [Description("Alış Faturası")]
        Alis = 1,
        [Description("Satış Faturası")]
        Satis = 2,
    }
}