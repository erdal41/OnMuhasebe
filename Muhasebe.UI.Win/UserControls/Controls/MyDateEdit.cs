using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using Muhasebe.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace Muhasebe.UI.Win.UserControls.Controls
{
    public class MyDateEdit : DateEdit, IStatusBarKisaYol
    {
        [ToolboxItem(true)]
        public MyDateEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.PaleTurquoise;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; } = "Tarih Seç";
        public string StatusBarAciklama { get; set; }
    }
}