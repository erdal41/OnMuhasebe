using System.ComponentModel;

namespace Muhasebe.Common.Enums
{
    public enum OdemeTipi : byte
    {
        [Description("Açık")]
        Acik = 1,
        [Description("Çek")]
        Cek = 2,
        [Description("Epos")]
        Epos = 3,
        [Description("Nakit")]
        Nakit = 4,
        [Description("Ots")]
        Ots = 5,
        [Description("Pos")]
        Pos = 6,
        [Description("Senet")]
        Senet = 7,
    }
}