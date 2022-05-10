using DevExpress.XtraEditors;
using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.Common.Functions;
using Muhasebe.Model.Dto;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Functions;
using System;

namespace Muhasebe.UI.Win.Forms.CariForms
{
    public partial class CariEditForm : BaseEditForm
    {
        public CariEditForm()
        {
            InitializeComponent();

            DataLayoutControl = myDataLayoutControl;
            Bll = new CariBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Cari;
            EnumFunctions.GetEnumDescriptionAndValueList<CariHesapTuru>(txtHesapTuru);
            EventsLoad();
        }

        #region Functions

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new CariSingle() : ((CariBll)Bll).Single(FilterFunctions.Filter<Cari>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((CariBll)Bll).YeniKodVer();
            txtCariAdi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (CariSingle)OldEntity;

            txtKod.Text = entity.Kod;
            txtCariAdi.Text = entity.CariAdi;
            txtHesapTuru.EditValue = (int)entity.CariHesapTuru;
            txtTcKimlikNo.Text = entity.TcKimlikNo;
            txtTelefon1.Text = entity.Telefon1;
            txtTelefon2.Text = entity.Telefon2;
            txtTelefon3.Text = entity.Telefon3;
            txtFax.Text = entity.Fax;
            txtWebsite.Text = entity.Website;
            txtEmail.Text = entity.Email;
            txtVergiDairesi.Text = entity.VergiDairesi;
            txtVergiNo.Text = entity.VergiNo;
            txtAdres.Text = entity.Adres;
            txtPostaKodu.Text = entity.PostaKodu;
            txtIlce.Id = entity.IlceId;
            txtIlce.Text = entity.IlceAdi;
            txtIl.Id = entity.IlId;
            txtIl.Text = entity.IlAdi;
            txtUlke.Id = entity.UlkeId;
            txtUlke.Text = entity.UlkeAdi;
            txtOzelKod1.Id = entity.OzelKod1Id;
            txtOzelKod1.Text = entity.OzelKod1Adi;
            txtOzelKod2.Id = entity.OzelKod2Id;
            txtOzelKod2.Text = entity.OzelKod2Adi;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Cari
            {
                Id = Id,
                Kod = txtKod.Text,
                CariAdi = txtCariAdi.Text,
                CariHesapTuru = txtHesapTuru.Text.GetEnum<CariHesapTuru>(),
                TcKimlikNo = txtTcKimlikNo.Text,
                Telefon1 = txtTelefon1.Text,
                Telefon2 = txtTelefon2.Text,
                Telefon3 = txtTelefon3.Text,
                Fax = txtFax.Text,
                Website = txtWebsite.Text,
                Email = txtEmail.Text,
                VergiDairesi = txtVergiDairesi.Text,
                VergiNo = txtVergiNo.Text,
                Adres = txtAdres.Text,
                PostaKodu = txtPostaKodu.Text,
                IlceId = txtIlce.Id,
                IlId = txtIl.Id,
                UlkeId = txtUlke.Id,
                OzelKod1Id = txtOzelKod1.Id,
                OzelKod2Id = txtOzelKod2.Id,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn,
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((CariBll)Bll).Insert(NewEntity, x => x.Kod == NewEntity.Kod);
        }

        protected override bool EntityUpdate()
        {
            return ((CariBll)Bll).Update(OldEntity, NewEntity, x => x.Kod == NewEntity.Kod);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtOzelKod1)
                {
                    sec.Sec(txtOzelKod1, KartTuru.Cari);
                }
                else if (sender == txtOzelKod2)
                {
                    sec.Sec(txtOzelKod2, KartTuru.Cari);
                }
                else if (sender == txtUlke)
                {
                    sec.Sec(txtUlke);
                }
                else if (sender == txtIl)
                {
                    sec.Sec(txtIl, txtUlke);
                }
                else if (sender == txtIlce)
                {
                    sec.Sec(txtIlce, txtIl);
                }
            }
        } 

        #endregion

        #region Events

        protected override void Control_EnabledChange(object sender, EventArgs e)
        {
            if (sender != txtUlke && sender != txtIl) return;
            if (sender == txtUlke)
            {
                txtUlke.ControlEnabledChange(txtIl);
            }
            else if (sender == txtIl)
            {
                txtIl.ControlEnabledChange(txtIlce);
            }
        } 

        #endregion
    }
}