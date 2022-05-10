using Muhasebe.Bll.Base;
using Muhasebe.Bll.Interfaces;
using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using System.Windows.Forms;

namespace Muhasebe.Bll.General
{
    public class IlceBll : BaseGenelBll<Ilce>, IBaseCommonBll
    {
        public IlceBll() : base(KartTuru.Ilce) { }

        public IlceBll(Control ctrl) : base(ctrl, KartTuru.Ilce) { }
    }
}