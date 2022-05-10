using DevExpress.XtraSplashScreen;
using System;
using System.Reflection;

namespace Muhasebe.UI.Win.Forms.GeneralForms
{
    public partial class Baslatiliyor : SplashScreen
    {
        public Baslatiliyor()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 2020 - " + DateTime.Now.Year.ToString() + " | Rafgrup";
            lblVersion.Text = $"Versiyon : {Assembly.GetExecutingAssembly().GetName().Version}";

        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand { }
    }
}