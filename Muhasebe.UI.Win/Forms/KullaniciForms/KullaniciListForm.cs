using DevExpress.XtraBars;
using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Functions;
using Muhasebe.UI.Win.Show;

namespace Muhasebe.UI.Win.Forms.KullaniciForms
{
    public partial class KullaniciListForm : BaseListForm
    {
        public KullaniciListForm()
        {
            InitializeComponent();
            Bll = new KullaniciBll();
            HideItems = new BarItem[] { btnSec };
        }

        #region Functions
        
        protected override void DegiskenleriDoldur()
        {
            Tablo = view;

            //filtreleme için kullandık
            BaseKartTuru = KartTuru.Kullanici;
            FormShow = new ShowEditForms<KullaniciEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((KullaniciBll)Bll).List(FilterFunctions.Filter<Kullanici>(AktifKartlariGoster));
        } 

        #endregion
    }
}