using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraPrinting;

namespace Muhasebe.UI.Win.Forms.GeneralForms
{
    public partial class RaporOnizleme : RibbonForm
    {
        public RaporOnizleme(params object[] prm)
        {
            InitializeComponent();

            RaporGosterici.PrintingSystem = (PrintingSystemBase)prm[0];
            Text = $"{Text} ( {prm[1]} )";
        }
    }
}