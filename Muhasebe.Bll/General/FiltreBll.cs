using Muhasebe.Bll.Base;
using Muhasebe.Bll.Interfaces;
using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using System.Windows.Forms;

namespace Muhasebe.Bll.General
{
    public class FiltreBll : BaseGenelBll<Filtre>, IBaseGenelBll, IBaseCommonBll
    {
        public FiltreBll() : base(KartTuru.Birim) { }

        public FiltreBll(Control ctrl) : base(ctrl, KartTuru.Birim) { }
    }
}