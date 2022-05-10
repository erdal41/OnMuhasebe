using DevExpress.XtraBars;
using Muhasebe.Bll.Functions;
using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.Common.Messages;
using Muhasebe.Model.Dto;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Forms.FaturaForms;
using Muhasebe.UI.Win.Functions;
using Muhasebe.UI.Win.Show;
using OgrenciTakip.UI.Win.Show;

namespace Muhasebe.UI.Win.Forms.CariForms
{
    public partial class CariListForm : BaseListForm
    {
        public CariListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new CariBll();
            ShowItems = new BarItem[] { btnFaturaOlustur };
            btnFaturaOlustur.Caption = "Fatura Oluştur";
            btnBagliKartlar.Caption = "Cari Hareketleri";
        }

        #region Functions

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Cari;
            FormShow = new ShowEditForms<CariEditForm>();
            Navigator = longNavigator.Navigator;

            if (IsMdiChild)
            {
                ShowItems = new BarItem[] { btnBagliKartlar };
            }
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((CariBll)Bll).List(FilterFunctions.Filter<Cari>(AktifKartlariGoster));
        }

        protected override void TahakkukYap()
        {
            var entity = tablo.GetRow<CariList>().EntityConvert<Cari>();

            using (var bll = new FaturaBll())
            {
                //Ogrenci ID ye göre tahakkuları getirir.
                var tahakkuk = bll.SingleSummary(x => x.CariId == entity.Id);

                if (tahakkuk != null)
                {
                    ShowEditForms<FaturaEditForm>.ShowDialogEditForm(KartTuru.Fatura, tahakkuk.Id, null);
                }
                else
                {
                    ShowEditForms<FaturaEditForm>.ShowDialogEditForm(KartTuru.Fatura, -1, entity);
                }
            }
        }

        protected override void BagliKartAc()
        {
            var entity = Tablo.GetRow<CariList>();
            if (entity == null) return;

            using (var bll = new CariHareketleriBll())
            {
                var cariHareketKontrol = bll.Single(x => x.CariId == entity.Id).EntityConvert<CariHareketleri>();

                if (cariHareketKontrol != null)
                {
                    ShowListForms<CariHareketleriListForm>.ShowDialogListForm(KartTuru.CariHareketleri, -1, cariHareketKontrol.CariId);
                }
                else
                {
                    Messages.HataMesaji("Seçilen carinin hesap hareketi bulunmamaktadır.");
                }
            }
        } 

        #endregion
    }
}