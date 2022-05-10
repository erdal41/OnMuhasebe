using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Muhasebe.UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace Muhasebe.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyLookUpEdit : LookUpEdit, IStatusBarKisaYol
    {
        public MyLookUpEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.PaleTurquoise;
            Properties.HeaderClickMode = HeaderClickMode.AutoSearch;
            Properties.ShowFooter = false;
        }

        //Entere basılınca diğer kontrole geçer
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarKisaYol { get; set; } = "F4 :";
        public string StatusBarKisaYolAciklama { get; set; } = "Seçim Yap";
        public string StatusBarAciklama { get; set; }
    }
}