using Muhasebe.Bll.Base;
using Muhasebe.Bll.Interfaces;
using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using System.Windows.Forms;

namespace Muhasebe.Bll.General
{
    public class OzelKodBll : BaseGenelBll<OzelKod>, IBaseCommonBll
    {
        public OzelKodBll() : base(KartTuru.OzelKod) { }

        public OzelKodBll(Control ctrl) : base(ctrl, KartTuru.OzelKod) { }
    }
}