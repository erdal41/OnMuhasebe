using DevExpress.XtraBars;
using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using Muhasebe.Model.Entities.Base.Interfaces;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Functions;
using Muhasebe.UI.Win.UserControls.Controls;
using System;
using System.Drawing;

namespace Muhasebe.UI.Win.Forms.GeneralForms
{
    public partial class KullaniciParametreEditForm : BaseEditForm
    {
        #region Variables

        private readonly long _kullaniciId;
        private string Kod;

        #endregion

        public KullaniciParametreEditForm(params object[] prm)
        {
            InitializeComponent();

            _kullaniciId = (long)prm[0];
            DataLayoutControl = myDataLayoutControl;
            Bll = new KullaniciParametreBll();
            BaseKartTuru = KartTuru.KullaniciParametre;
            HideItems = new BarItem[] { btnYeni, btnSil };
            EventsLoad();
            txtVarsayilanNoktaVurusluYazici.Properties.Items.AddRange(GeneralFunctions.YazicilariListele());
        }

        #region Functions

        public override void Yukle()
        {
            //BaseIslemTuru = OldEntity.Id == 0 ? IslemTuru.EntityInsert : IslemTuru.EntityUpdate;
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new KullaniciParametre() : ((KullaniciParametreBll)Bll).Single(x => x.KullaniciId == _kullaniciId);
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Kod = ((KullaniciParametreBll)Bll).YeniKodVer();
            Id = BaseIslemTuru.IdOlustur(OldEntity);
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (KullaniciParametre)OldEntity;

            Id = entity.Id;
            txtVarsayilanNoktaVurusluYazici.Text = entity.DefaultNoktaVurusluYazici;
            txtTabloBasligiYaziRengi.Color = Color.FromArgb(entity.TableViewCaptionForeColor);
            txtTabloBasligiSutunYaziRengi.Color = Color.FromArgb(entity.TableColumnHeaderForeColor);
            txtTabloBandPanelYaziRengi.Color = Color.FromArgb(entity.TableBandPanelForeColor);
            imgArkaPlanResmi.EditValue = entity.ArkaPlanResmi;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new KullaniciParametre
            {
                Id = Id,
                Kod = Kod,
                KullaniciId = AnaForm.KullaniciId,
                DefaultNoktaVurusluYazici = txtVarsayilanNoktaVurusluYazici.Text,
                TableViewCaptionForeColor = txtTabloBasligiYaziRengi.Color.ToArgb(),
                TableColumnHeaderForeColor = txtTabloBasligiSutunYaziRengi.Color.ToArgb(),
                TableBandPanelForeColor = txtTabloBandPanelYaziRengi.Color.ToArgb(),
                ArkaPlanResmi = (byte[])imgArkaPlanResmi.EditValue,
            };
            ButtonEnabledDurumu();
        }

        protected internal override IBaseEntity ReturnEntity()
        {
            var entity = new KullaniciParametre
            {
                DefaultNoktaVurusluYazici = txtVarsayilanNoktaVurusluYazici.Text,
                TableViewCaptionForeColor = txtTabloBasligiYaziRengi.Color.ToArgb(),
                TableColumnHeaderForeColor = txtTabloBasligiSutunYaziRengi.Color.ToArgb(),
                TableBandPanelForeColor = txtTabloBandPanelYaziRengi.Color.ToArgb(),
                ArkaPlanResmi = (byte[])imgArkaPlanResmi.EditValue,
            };

            return entity;
        }

        protected override bool EntityInsert()
        {
            var result = base.EntityInsert();
            if (!result) return false;

            ReturnEntity();
            return true;
        }

        protected override bool EntityUpdate()
        {
            var result = base.EntityUpdate();
            if (!result) return false;

            ReturnEntity();
            return true;
        }

        #endregion

        #region Events

        protected override void Control_Enter(object sender, EventArgs e)
        {
            if (!(sender is MyPictureEdit resim)) return;
            resim.Sec(resimMenu);
        }

        #endregion
    }
}