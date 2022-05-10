using DevExpress.LookAndFeel;
using Muhasebe.UI.Win.Forms.GeneralForms;
using Muhasebe.UI.Win.Functions;
using System;
using System.Configuration;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Muhasebe.UI.Win
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GeneralFunctions.EncryptConfigFile(AppDomain.CurrentDomain.SetupInformation.ApplicationName, "connectionStrings", "appSettings");

            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserLookAndFeel.Default.SetSkinStyle(ConfigurationManager.AppSettings["Skin"], ConfigurationManager.AppSettings["Palette"]);
            Application.Run(new GirisForm());
        }
    }
}