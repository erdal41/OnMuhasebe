using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Show;

namespace Muhasebe.UI.Win.Forms.IlceForms
{
    public partial class IlceListForm : BaseListForm
    {
        #region Variables

        private readonly long _ilId;
        private readonly string _ilAdi; 

        #endregion

        public IlceListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new IlceBll();

            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();
        }

        #region Functions

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Ilce;
            Navigator = longNavigator.Navigator;
            Text += $" - ( {_ilAdi} )";
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((IlceBll)Bll).List(x => x.Durum == AktifKartlariGoster && x.IlId == _ilId);
        }

        protected override void ShowEditForm(long id)
        {
            var result = ShowEditForms<IlceEditForm>.ShowDialogEditForm(KartTuru.Ilce, id, _ilId, _ilAdi);
            ShowEditFormDefault(result);
        } 

        #endregion
    }
}