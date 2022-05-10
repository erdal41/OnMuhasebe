using DevExpress.XtraBars;
using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Functions;
using Muhasebe.UI.Win.Show;
using OgrenciTakip.UI.Win.Show;

namespace Muhasebe.UI.Win.Forms.IlForms
{
    public partial class IlListForm : BaseListForm
    {
        #region Variables

        private readonly long _ulkeId;
        private readonly string _ulkeAdi;

        #endregion

        public IlListForm(params object[] prm)
        {
            InitializeComponent();

            Bll = new IlBll();
            btnBagliKartlar.Caption = "İlçe Kartları";

            _ulkeId = (long)prm[0];
            _ulkeAdi = prm[1].ToString();
        }

        #region Functions

        protected override void DegiskenleriDoldur()
        {
            Tablo = view;
            BaseKartTuru = KartTuru.Il;
            Navigator = longNavigator.Navigator;
            Text += $" - ( { _ulkeAdi } )";

            if (IsMdiChild)
            {
                ShowItems = new BarItem[] { btnBagliKartlar };
            }
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IlBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.UlkeId == _ulkeId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<IlEditForm>.ShowDialogEditForm(KartTuru.Il, id, _ulkeId, _ulkeAdi);
            ShowEditFormDefault(result);
        }

        protected override void BagliKartAc()
        {
            var entity = Tablo.GetRow<Il>();

            if (entity == null) return;

            ShowListForms<IlListForm>.ShowListForm(KartTuru.Ilce, entity.Id, entity.IlAdi);
        } 

        #endregion
    }
}