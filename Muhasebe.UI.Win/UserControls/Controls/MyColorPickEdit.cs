using DevExpress.XtraEditors;
using Muhasebe.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace Muhasebe.UI.Win.UserControls.Controls
{
    public class MyColorPickEdit : ColorPickEdit, IStatusBarKisaYol
    {
        [ToolboxItem(true)]
        public MyColorPickEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.PaleTurquoise;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
        public string StatusBarKisaYol { get; set; } = "F4 : ";
        public string StatusBarKisaYolAciklama { get; set; }
    }
}