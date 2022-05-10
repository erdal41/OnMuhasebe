using Muhasebe.Bll.Base;
using Muhasebe.Bll.Interfaces;
using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using System.Windows.Forms;

namespace Muhasebe.Bll.General
{
    public class IlBll : BaseGenelBll<Il>, IBaseGenelBll, IBaseCommonBll
    {
        public IlBll() : base(KartTuru.Il) { }

        public IlBll(Control ctrl) : base(ctrl, KartTuru.Il) { }
    }
}