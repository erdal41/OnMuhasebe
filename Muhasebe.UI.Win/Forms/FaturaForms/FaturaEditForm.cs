using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraReports;
using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.Common.Functions;
using Muhasebe.Common.Messages;
using Muhasebe.Model.Dto;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Forms.GeneralForms;
using Muhasebe.UI.Win.Functions;
using Muhasebe.UI.Win.Reports.XtraReports.Fatura;
using Muhasebe.UI.Win.UserControls.Controls;
using OgrenciTakip.UI.Win.Show;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraReports.UI;
using Muhasebe.Model.Entities.Base;
using Muhasebe.Bll.Interfaces;
using System;

namespace Muhasebe.UI.Win.Forms.FaturaForms
{
    public partial class FaturaEditForm : BaseEditForm
    {
        #region Variables

        private BaseEntity CariHareketOldEntity;
        private BaseEntity CariHareketNewEntity;
        private readonly IBaseBll CariHareketBll;
        private long CariHareketId;
        private string CariHareketKod;

        #endregion

        public FaturaEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new FaturaBll(myDataLayoutControl);
            CariHareketBll = new CariHareketleriBll();
            BaseKartTuru = KartTuru.Fatura;
            EventsLoad();

            ShowItems = new BarItem[] { btnYazdir, btnBaskiOnizleme };

            txtFaturaTipi.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<FaturaTipi>());
            txtFaturaTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<FaturaTuru>());

            KayitSonrasiFormuKapat = false;
        }

        #region Functions

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new FaturaSingle() : ((FaturaBll)Bll).Single(FilterFunctions.Filter<Fatura>(Id));
            CariHareketOldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new CariHareketleriSingle() : ((CariHareketleriBll)CariHareketBll).Single(FilterFunctions.Filter<CariHareketleri>(Id));

            NesneyiKontrollereBagla();
            TabloYukle();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            CariHareketId = BaseIslemTuru.IdOlustur(CariHareketOldEntity);
            txtFaturaNo.Text = ((FaturaBll)Bll).YeniKodVer();
            CariHareketKod = ((CariHareketleriBll)CariHareketBll).YeniKodVer();
            txtFaturaTarihi.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (FaturaSingle)OldEntity;

            txtFaturaNo.Text = entity.Kod;
            txtFaturaTipi.SelectedItem = entity.FaturaTipi.ToName();
            txtFaturaTarihi.DateTime = entity.FaturaTarihi;
            txtVadeTarihi.DateTime = entity.VadeTarihi;
            txtFaturaTuru.SelectedItem = entity.FaturaTuru.ToName();
            txtIrsaliyeNo.Text = entity.IrsaliyeNo;
            txtIrsaliyeTarihi.DateTime = entity.IrsaliyeTarihi;
            txtCari.Id = entity.CariId;
            txtCari.Text = entity.CariKodu;
            txtCariAdi.Text = entity.CariAdi;
            txtVergiDairesi.Text = entity.VergiDairesi;
            txtVergiNo.Text = entity.VergiNo;
            txtAdres.Text = entity.TamAdres;
            txtAciklama.Text = entity.Aciklama;
            txtIlkTutar.Value = entity.IlkTutar;
            txtIskonto.Value = entity.Iskonto;
            txtKdvHaricTutar.Value = entity.NetTutar;
            txtKdvTutari.Value = entity.KdvTutari;
            txtToplamTutar.Value = entity.ToplamTutar;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Fatura
            {
                Id = Id,
                Kod = txtFaturaNo.Text,
                FaturaTipi = txtFaturaTipi.Text.GetEnum<FaturaTipi>(),
                FaturaTarihi = txtFaturaTarihi.DateTime.Date,
                VadeTarihi = txtVadeTarihi.DateTime.Date,
                FaturaTuru = txtFaturaTuru.Text.GetEnum<FaturaTuru>(),
                IrsaliyeNo = txtIrsaliyeNo.Text,
                IrsaliyeTarihi = txtIrsaliyeTarihi.DateTime.Date,
                CariId = txtCari.Id,
                Aciklama = txtAciklama.Text,
                IlkTutar = txtIlkTutar.Value,
                Iskonto = txtIskonto.Value,
                NetTutar = txtKdvHaricTutar.Value,
                KdvTutari = txtKdvTutari.Value,
                ToplamTutar = txtToplamTutar.Value,
            };

            CariHareketNewEntity = new CariHareketleri
            {
                Id = BaseIslemTuru == IslemTuru.EntityInsert ? CariHareketId : CariHareketOldEntity.Id,
                Kod = BaseIslemTuru == IslemTuru.EntityInsert ? CariHareketKod : CariHareketOldEntity.Kod,
                HesapKodu = txtCari.Text,
                FaturaId = Id,
                CariId = txtCari.Id,
                Tarih = (DateTime)txtFaturaTarihi.EditValue,
                BelgeNo = txtFaturaNo.Text,
                BelgeTuru = BelgeTuru.Fatura,
                OdemeTipi = OdemeTipi.Nakit,
                Aciklama = txtAciklama.Text,
                Borc = txtFaturaTipi.Text.GetEnum<FaturaTipi>() == FaturaTipi.Satis ? txtToplamTutar.Value : 0,
                Alacak = txtFaturaTipi.Text.GetEnum<FaturaTipi>() == FaturaTipi.Alis ? txtToplamTutar.Value : 0,
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            if (stokBilgileriTable.HataliGiris()) return false;

            var result = ((FaturaBll)Bll).Insert(NewEntity, x => x.Kod == NewEntity.Kod) && stokBilgileriTable.Kaydet() && ((CariHareketleriBll)CariHareketBll).Insert(CariHareketNewEntity, x => x.Kod == CariHareketNewEntity.Kod);

            if (result && !KayitSonrasiFormuKapat)
            {
                stokBilgileriTable.Yukle();
            }

            return result;
        }

        protected override bool EntityUpdate()
        {
            if (stokBilgileriTable.HataliGiris()) return false;

            var result = ((FaturaBll)Bll).Update(OldEntity, NewEntity, x => x.Kod == NewEntity.Kod) && stokBilgileriTable.Kaydet() && ((CariHareketleriBll)CariHareketBll).Update(CariHareketOldEntity, CariHareketNewEntity, x => x.Kod == CariHareketNewEntity.Kod);

            if (result && !KayitSonrasiFormuKapat)
            {
                stokBilgileriTable.Yukle();
            }

            return result;
        }

        protected internal bool HataliGiris()
        {
            if (txtFaturaTipi.SelectedItem == null)
            {
                Messages.SecimHataMesaji("Fatura Tipi");
                txtFaturaTipi.Focus();
                return true;
            }
            else if (txtFaturaTarihi.EditValue == null)
            {
                Messages.SecimHataMesaji("Fatura Tarihi");
                txtFaturaTarihi.Focus();
                return true;
            }
            else if (txtCari.Id == null)
            {
                Messages.SecimHataMesaji("Cari");
                txtCari.Focus();
                return true;
            }
            return false;
        }

        protected internal override void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, NewEntity, stokBilgileriTable.TableValueChanged);
        }

        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtCari)
                {
                    sec.Sec(txtCari, txtCariAdi, txtVergiDairesi, txtVergiNo, txtAdres);
                }
            }
        }

        protected override void TabloYukle()
        {
            stokBilgileriTable.OwnerForm = this;
            stokBilgileriTable.Yukle();
        }

        #region Report

        private void ReportDataSource(IReport rapor)
        {
            if (OldEntity.Id == 0)
            {
                Messages.HataMesaji("Faturayı kaydetmeden önizleme yapamazsınız.");
                KayitliMi = false;
            }
            else
            {
                switch (rapor)
                {
                    case IrsaliyeRaporu rpr:
                        rpr.Irsaliye_Bilgileri.DataSource = ((FaturaBll)Bll).SingleDetail(x => x.Id == OldEntity.Id);
                        rpr.Stok_Bilgileri.DataSource = new FaturaBll().SingleDetail(x => x.Id == OldEntity.Id).StokBilgileri.ToList();
                        break;
                }
                KayitliMi = true;
            }
        }

        private MyXtraReport RaporHazirla()
        {
            var rapor = new IrsaliyeRaporu();
            ReportDataSource(rapor);
            rapor.CreateDocument();

            return rapor;
        }

        protected override void Yazdir()
        {
            if (Messages.EvetSeciliEvetHayir("İrsaliye yazdırılmak üzere yazıcıya gönderilecektir. Onaylıyor musunuz?", "Onay") != DialogResult.Yes) return;

            using (var bll = new KullaniciParametreBll())
            {
                var yaziciAdi = ((KullaniciParametre)bll.Single(x => x.KullaniciId == AnaForm.KullaniciId)).DefaultNoktaVurusluYazici;

                XtraReport irsaliyeRaporu = new IrsaliyeRaporu();
                ReportDataSource(irsaliyeRaporu);
                ReportPrintTool printTool = new ReportPrintTool(irsaliyeRaporu);
                printTool.Print(yaziciAdi);
            }
        }

        protected override void BaskiOnizleme()
        {
            var raporlar = RaporHazirla();
            if (KayitliMi)
            {
                ShowRibbonForms<RaporOnizleme>.ShowForm(false, raporlar.PrintingSystem, raporlar.Baslik);
            }
        }

        #endregion

        #endregion
    }
}