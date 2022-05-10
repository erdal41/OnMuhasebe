using Muhasebe.Bll.Base;
using Muhasebe.Bll.Interfaces;
using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using System.Windows.Forms;

namespace Muhasebe.Bll.General
{
    public class KullaniciParametreBll : BaseGenelBll<KullaniciParametre>, IBaseGenelBll, IBaseCommonBll
    {
        public KullaniciParametreBll() : base(KartTuru.KullaniciParametre) { }

        public KullaniciParametreBll(Control ctrl) : base(ctrl, KartTuru.KullaniciParametre) { }
    }
}