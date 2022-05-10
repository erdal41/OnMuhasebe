using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.Common.Functions;
using Muhasebe.Common.Messages;
using Muhasebe.Model.Dto;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Forms.GeneralForms;
using Muhasebe.UI.Win.Functions;
using System.Windows.Forms;
using System;

namespace Muhasebe.UI.Win.Forms.CariForms
{
    public partial class CariHareketFisiEditForm : BaseEditForm
    {
        public CariHareketFisiEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new CariHareketleriBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.CariHareketFisi;
            EventsLoad();

            HideItems = new BarItem[] { btnYeni };
            ShowItems = new BarItem[] { btnYazdir };

            txtOdemeTipi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<OdemeTipi>());
            txtBelgeTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<BelgeTuru>());
            //FarkliDonemIslemi = prm.Length > 2 && (bool)prm[2];      
        }

        #region Functions

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new CariHareketleriSingle() : ((CariHareketleriBll)Bll).Single(FilterFunctions.Filter<CariHareketleri>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((CariHareketleriBll)Bll).YeniKodVer();
            txtHesapKodu.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (CariHareketleriSingle)OldEntity;

            txtKod.Text = entity.Kod;
            txtHesapKodu.Text = entity.HesapKodu;
            txtHesapKodu.Id = entity.CariId;
            txtCariAdi.Text = entity.CariAdi;
            txtBelgeTuru.SelectedItem = entity.BelgeTuru.ToName();
            txtBelgeNo.Text = entity.BelgeNo;
            txtTarih.DateTime = entity.Tarih;
            txtOdemeTipi.SelectedItem = entity.OdemeTipi.ToName();
            txtBorc.EditValue = entity.Borc;
            txtAlacak.EditValue = entity.Alacak;
            txtAciklama.Text = entity.Aciklama;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new CariHareketleri
            {
                Id = Id,
                Kod = txtKod.Text,
                HesapKodu = txtHesapKodu.Text,
                CariId = txtHesapKodu.Id,
                BelgeNo = txtBelgeNo.Text,
                BelgeTuru = txtBelgeTuru.Text.GetEnum<BelgeTuru>(),
                Tarih = txtTarih.DateTime.Date,
                OdemeTipi = txtOdemeTipi.Text.GetEnum<OdemeTipi>(),
                Borc = txtBorc.Value,
                Alacak = txtAlacak.Value,
                Aciklama = txtAciklama.Text,

            };
            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            GuncelNesneOlustur();
            //if (HataliGiris()) return false;

            return ((CariHareketleriBll)Bll).Insert(NewEntity, x => x.Id == NewEntity.Id);
        }

        protected override bool EntityUpdate()
        {
            GuncelNesneOlustur();
            //if (HataliGiris()) return false;
            return ((CariHareketleriBll)Bll).Update(OldEntity, NewEntity, x => x.Id == Id);
        }

        protected internal bool HataliGiris()
        {
            if (txtTarih.EditValue == null)
            {
                Messages.SecimHataMesaji("Tarih");
                txtTarih.Focus();
                return false;
            }
            else if (txtOdemeTipi.SelectedItem == null)
            {
                Messages.SecimHataMesaji("Ödeme Tipi");
                txtOdemeTipi.Focus();
                return false;
            }
            else if (txtBorc.Value == 0 && txtAlacak.Value == 0)
            {
                Messages.BosGecilemez("Borç veya Alacak");
                txtOdemeTipi.Focus();
                return false;
            }
            return true;
        }

        protected internal override void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;
            Functions.GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, NewEntity);

            //if (FarkliDonemIslemi)
            //{
            //    GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil);
            //}
            //else
            //{
            //    GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, IDOldEntity, IDNewEntity);
            //}
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtHesapKodu)
                {
                    sec.Sec(txtHesapKodu, txtCariAdi);
                }
            }
        } 

        #endregion

        #region Events

        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
        } 

        #endregion
    }
}