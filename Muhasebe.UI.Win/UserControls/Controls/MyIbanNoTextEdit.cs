using DevExpress.XtraEditors.Mask;
using System.ComponentModel;

namespace Muhasebe.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyIbanNoTextEdit : MyTextEdit
    {
        public MyIbanNoTextEdit()
        {
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"TR\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?\d?\d? \d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarAciklama = "İban no giriniz.";
        }
    }
}