using DevExpress.XtraEditors;
using Muhasebe.UI.Win.Interfaces;
using System.ComponentModel;

namespace Muhasebe.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyFilterControl : FilterControl, IStatusBarAciklama
    {
        public MyFilterControl()
        {
            ShowGroupCommandsIcon = true;
        }

        public string StatusBarAciklama { get; set; } = "Filtre metni giriniz.";
    }
}