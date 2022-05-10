using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.Common.Enums;
using Muhasebe.UI.Win.Show;
using Muhasebe.UI.Win.Functions;
using Muhasebe.Model.Entities;
using Muhasebe.Bll.General;

namespace Muhasebe.UI.Win.Forms.BirimForms
{
    public partial class BirimListForm : BaseListForm
    {
        public BirimListForm()
        {
            InitializeComponent();
            Bll = new BirimBll();
        }

        #region Functions

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Birim;
            FormShow = new ShowEditForms<BirimEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((BirimBll)Bll).List(FilterFunctions.Filter<Birim>(AktifKartlariGoster));
        } 

        #endregion
    }
}