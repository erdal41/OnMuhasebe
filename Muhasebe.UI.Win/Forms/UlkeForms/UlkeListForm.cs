using DevExpress.XtraBars;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.Common.Enums;
using Muhasebe.UI.Win.Show;
using Muhasebe.UI.Win.Functions;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.IlForms;
using OgrenciTakip.UI.Win.Show;
using Muhasebe.Bll.General;

namespace Muhasebe.UI.Win.Forms.UlkeForms
{
    public partial class UlkeListForm : BaseListForm
    {
        public UlkeListForm()
        {
            InitializeComponent();

            Bll = new UlkeBll();
            btnBagliKartlar.Caption = "İl Kartları";
        }

        #region Functions

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Ulke;
            FormShow = new ShowEditForms<UlkeEditForm>();
            Navigator = longNavigator.Navigator;

            if (IsMdiChild)
            {
                ShowItems = new BarItem[] { btnBagliKartlar };
            }
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((UlkeBll)Bll).List(FilterFunctions.Filter<Ulke>(AktifKartlariGoster));
        }

        protected override void BagliKartAc()
        {
            var entity = Tablo.GetRow<Ulke>();

            if (entity == null) return;

            ShowListForms<IlListForm>.ShowListForm(KartTuru.Il, entity.Id, entity.UlkeAdi);
        } 

        #endregion
    }
}