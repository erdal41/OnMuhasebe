using DevExpress.XtraEditors;
using Muhasebe.UI.Win.Interfaces;
using System.ComponentModel;
using System.Windows.Forms;

namespace Muhasebe.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyHyperlinkLabelControl : HyperlinkLabelControl, IStatusBarAciklama
    {
        public MyHyperlinkLabelControl()
        {
            Cursor = Cursors.Hand;
            LinkBehavior = LinkBehavior.NeverUnderline;
        }

        public string StatusBarAciklama { get; set; }
    }
}