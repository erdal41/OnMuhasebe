using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Functions;

namespace Muhasebe.UI.Win.Forms.IlceForms
{
    public partial class IlceEditForm : BaseEditForm
    {
        #region Variables

        private readonly long _ilId;
        private readonly string _ilAdi; 

        #endregion

        public IlceEditForm(params object[] prm)
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new IlceBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Ilce;
            EventsLoad();

            _ilId = (long)prm[0];
            _ilAdi = prm[1].ToString();
        }

        #region Functions

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Ilce() : ((IlceBll)Bll).Single(FilterFunctions.Filter<Ilce>(Id));
            NesneyiKontrollereBagla();

            Text += $" - ( {_ilAdi} )";

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((IlceBll)Bll).YeniKodVer(x => x.IlId == _ilId);
            txtIlceAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Ilce)OldEntity;
            txtKod.Text = entity.Kod;
            txtIlceAdi.Text = entity.IlceAdi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Ilce
            {
                Id = Id,
                Kod = txtKod.Text,
                IlceAdi = txtIlceAdi.Text,
                IlId = _ilId,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((IlceBll)Bll).Insert(NewEntity, x => x.Kod == NewEntity.Kod && x.IlId == _ilId);
        }

        protected override bool EntityUpdate()
        {
            return ((IlceBll)Bll).Update(OldEntity, NewEntity, x => x.Kod == NewEntity.Kod && x.IlId == _ilId);
        } 

        #endregion
    }
}