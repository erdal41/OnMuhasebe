using DevExpress.XtraEditors;
using Muhasebe.Common.Enums;
using System;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Show
{
    public class ShowXtraForms<TForm> where TForm : XtraForm
    {
        public static void ShowForm(bool dialog, params object[] prm)
        {
            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);

            if (dialog)
            {
                using (frm)
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                frm.Show();
            }
        }

        public static long ShowDialogForm(params object[] prm)
        {
            //if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return 0;

            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);

            using (frm)
            {
                frm.ShowDialog();
                return frm.DialogResult == DialogResult.OK ? (long)frm.Tag : 0;
            }
        }
    }
}
