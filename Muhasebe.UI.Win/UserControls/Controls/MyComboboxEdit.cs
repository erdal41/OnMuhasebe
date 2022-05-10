using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Muhasebe.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace Muhasebe.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyComboboxEdit : ComboBoxEdit, IStatusBarKisaYol
    {
        public MyComboboxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.PaleTurquoise;
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
    }
}