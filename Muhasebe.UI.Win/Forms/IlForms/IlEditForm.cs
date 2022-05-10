using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Functions;

namespace Muhasebe.UI.Win.Forms.IlForms
{
    public partial class IlEditForm : BaseEditForm
    {
        #region Variables

        private readonly long _ulkeId;
        private readonly string _ulkeAdi; 

        #endregion

        public IlEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IlBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Il;
            EventsLoad();

            _ulkeId = (long)prm[0];
            _ulkeAdi = prm[1].ToString();
        }

        #region Functions

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Il() : ((IlBll)Bll).Single(FilterFunctions.Filter<Il>(Id));
            NesneyiKontrollereBagla();

            Text += $" - ( {_ulkeAdi} )";

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IlBll)Bll).YeniKodVer(x => x.UlkeId == _ulkeId);
            txtIlAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Il)OldEntity;
            txtKod.Text = entity.Kod;
            txtIlAdi.Text = entity.IlAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Il
            {
                Id = Id,
                Kod = txtKod.Text,
                IlAdi = txtIlAdi.Text,
                UlkeId = _ulkeId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((IlBll)Bll).Insert(NewEntity, x => x.Kod == NewEntity.Kod && x.UlkeId == _ulkeId);
        }

        protected override bool EntityUpdate()
        {
            return ((IlBll)Bll).Update(OldEntity, NewEntity, x => x.Kod == NewEntity.Kod && x.UlkeId == _ulkeId);
        } 

        #endregion
    }
}