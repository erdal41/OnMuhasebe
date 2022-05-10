using DevExpress.Utils;
using System.ComponentModel;
using System.Drawing;

namespace Muhasebe.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyKodTextEdit : MyTextEdit
    {
        public MyKodTextEdit()
        {
            Properties.Appearance.BackColor = Color.PeachPuff;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.MaxLength = 20;
            StatusBarAciklama = "Kod giriniz.";
        }
    }
}