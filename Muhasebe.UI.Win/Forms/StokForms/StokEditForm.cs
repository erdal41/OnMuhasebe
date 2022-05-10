using DevExpress.XtraEditors;
using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.Model.Dto;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Functions;

namespace Muhasebe.UI.Win.Forms.StokForms
{
    public partial class StokEditForm : BaseEditForm
    {
        public StokEditForm()
        {
            InitializeComponent();

            Bll = new StokBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Stok;
            DataLayoutControl = myDataLayoutControl;
            EventsLoad();
        }

        #region Functions

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new StokSingle() : ((StokBll)Bll).Single(FilterFunctions.Filter<Stok>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((StokBll)Bll).YeniKodVer();
            txtStokAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (StokSingle)OldEntity;

            txtKod.Text = entity.Kod;
            txtStokAdi.Text = entity.StokAdi;
            txtBirim.Id = entity.BirimId;
            txtBirim.Text = entity.BirimAdi;
            txtAlisFiyati.EditValue = entity.AlisFiyati;
            txtAlisKdvOrani.EditValue = entity.AlisKdvOrani;
            txtSatisFiyati.EditValue = entity.SatisFiyati;
            txtSatisKdvOrani.EditValue = entity.SatisKdvOrani;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Stok
            {
                Id = Id,
                Kod = txtKod.Text,
                StokAdi = txtStokAdi.Text,
                BirimId = txtBirim.Id,
                AlisFiyati = txtAlisFiyati.Value,
                AlisKdvOrani = (byte?)txtAlisKdvOrani.Value,
                SatisFiyati = txtSatisFiyati.Value,
                SatisKdvOrani = (byte?)txtSatisKdvOrani.Value,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((StokBll)Bll).Insert(NewEntity, x => x.Kod == NewEntity.Kod);
        }

        protected override bool EntityUpdate()
        {
            return ((StokBll)Bll).Update(OldEntity, NewEntity, x => x.Kod == NewEntity.Kod);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtBirim)
                {
                    sec.Sec(txtBirim);
                }
            }
        } 

        #endregion
    }
}