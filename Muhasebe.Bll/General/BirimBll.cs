using Muhasebe.Bll.Base;
using Muhasebe.Bll.Interfaces;
using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using System.Windows.Forms;

namespace Muhasebe.Bll.General
{
    public class BirimBll : BaseGenelBll<Birim>, IBaseGenelBll, IBaseCommonBll
    {
        public BirimBll() : base(KartTuru.Birim) { }

        public BirimBll(Control ctrl) : base(ctrl, KartTuru.Birim) { }
    }
}