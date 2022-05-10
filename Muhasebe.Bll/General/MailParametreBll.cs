using Muhasebe.Bll.Base;
using Muhasebe.Bll.Interfaces;
using Muhasebe.Model.Entities;
using System.Windows.Forms;

namespace Muhasebe.Bll.General
{
    public class MailParametreBll : BaseGenelBll<MailParametre>, IBaseGenelBll, IBaseCommonBll
    {
        public MailParametreBll() : base() { }

        public MailParametreBll(Control ctrl) : base(ctrl) { }
    }
}