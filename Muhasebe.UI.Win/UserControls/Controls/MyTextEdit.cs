using DevExpress.XtraEditors;
using Muhasebe.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace Muhasebe.UI.Win.UserControls.Controls
{
    public class MyTextEdit : TextEdit, IStatusBarAciklama
    {
        [ToolboxItem(true)]
        public MyTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.PaleTurquoise;
            Properties.MaxLength = 50;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
    }
}