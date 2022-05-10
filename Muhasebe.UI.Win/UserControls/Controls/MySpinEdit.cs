using DevExpress.Utils;
using DevExpress.XtraEditors;
using Muhasebe.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace Muhasebe.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MySpinEdit : SpinEdit, IStatusBarAciklama
    {
        public MySpinEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.PaleTurquoise;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "d";
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
    }
}