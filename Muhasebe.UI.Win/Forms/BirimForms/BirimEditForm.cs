using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Functions;
using Muhasebe.Bll.General;

namespace Muhasebe.UI.Win.Forms.BirimForms
{
    public partial class BirimEditForm : BaseEditForm
    {
        public BirimEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new BirimBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Birim;
            EventsLoad();
        }

        #region Functions

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Birim() : ((BirimBll)Bll).Single(FilterFunctions.Filter<Birim>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((BirimBll)Bll).YeniKodVer();
            txtBirimAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Birim)OldEntity;
            txtKod.Text = entity.Kod;
            txtBirimAdi.Text = entity.BirimAdi;
            txtBirimKisaAdi.Text = entity.BirimKisaAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Birim
            {
                Id = Id,
                Kod = txtKod.Text,
                BirimAdi = txtBirimAdi.Text,
                BirimKisaAdi = txtBirimKisaAdi.Text,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        } 

        #endregion
    }
}