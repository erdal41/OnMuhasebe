using Muhasebe.Bll.Base;
using Muhasebe.Bll.Interfaces;
using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using System.Windows.Forms;

namespace Muhasebe.Bll.General
{
    public class UlkeBll : BaseGenelBll<Ulke>, IBaseGenelBll, IBaseCommonBll
    {
        public UlkeBll() : base(KartTuru.Ulke) { }

        public UlkeBll(Control ctrl) : base(ctrl, KartTuru.Ulke) { }
    }
}