using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Muhasebe.Bll.Functions;
using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.Common.Messages;
using Muhasebe.Model.Dto;
using Muhasebe.UI.Win.Forms.FaturaForms;
using Muhasebe.UI.Win.Forms.StokForms;
using Muhasebe.UI.Win.Functions;
using Muhasebe.UI.Win.UserControls.UserControl.Base;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Drawing;
using System.Linq;

namespace Muhasebe.UI.Win.UserControls.Tables.StokTables
{
    public partial class StokBilgileriTable : BaseTable
    {
        public StokBilgileriTable()
        {
            InitializeComponent();
            Bll = new StokBilgileriBll();
            Tablo = tablo;
            EventsLoad();
            insUpNavigator.Navigator.Buttons.Append.Hint = "Stok Ekle";
            insUpNavigator.Navigator.Buttons.Remove.Hint = "Stok Sil";
        }

        #region Functions

        protected internal override void Listele()
        {
            //gelen listeyi tobindingliste dönüştürdük.
            tablo.GridControl.DataSource = ((StokBilgileriBll)Bll).List(x => x.FaturaId == OwnerForm.Id).ToBindingList<StokBilgileriList>();
        }

        protected override void HareketEkle()
        {
            if (((FaturaEditForm)OwnerForm).HataliGiris()) return;

            var source = tablo.DataController.ListSource;
            ListeDisiTutulacakKayitlar = source.Cast<StokBilgileriList>().Where(x => !x.Delete).Select(x => x.StokId).ToList();

            var entities = ShowListForms<StokListForm>.ShowDialogListForm(KartTuru.Stok, ListeDisiTutulacakKayitlar, true, false).EntityListConvert<StokList>();
            if (entities == null) return;

            foreach (var entity in entities)
            {
                var row = new StokBilgileriList
                {
                    FaturaId = OwnerForm.Id,
                    StokId = entity.Id,
                    StokKodu = entity.Kod,
                    StokAdi = entity.StokAdi,
                    BirimAdi = entity.BirimAdi,
                    Miktar = 0,
                    BirimFiyati = 0,
                    MiktarTutari = 0,
                    IskontoOrani = 0,
                    IskontoTutari = 0,
                    KdvHaricTutar = 0,
                    KdvOrani = 0,
                    KdvTutari = 0,
                    Tutar = 0,
                    Insert = true,
                };

                source.Add(row);
            }

            tablo.Focus();
            tablo.RefreshDataSource();
            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
            tablo.FocusedColumn = colMiktar;
            ButtonEnabledDurumu(true);
        }

        protected internal override bool HataliGiris()
        {
            if (!TableValueChanged) return false;

            if (tablo.HasColumnErrors)
            {
                tablo.ClearColumnErrors();
            }

            for (int i = 0; i < Tablo.DataRowCount; i++)
            {
                var entity = tablo.GetRow<StokBilgileriList>(i);
                if (entity.Miktar <= 0)
                {
                    Messages.HataMesaji("Stok miktarı giriniz.");
                    tablo.Focus();
                    tablo.FocusedRowHandle = i;
                    return true;

                }
                else if (entity.BirimFiyati <= 0)
                {
                    Messages.HataMesaji("Stok birim fiyatını giriniz.");
                    tablo.Focus();
                    tablo.FocusedRowHandle = i;
                    return true;
                }
            }
            return false;
        }

        protected override void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            base.Tablo_CellValueChanged(sender, e);
            if (tablo == null) return;

            if (e.Column.FieldName != "KdvHaricTutar" && e.Column.FieldName != "MiktarTutari" && e.Column.FieldName != "IskontoTutari" && e.Column.FieldName != "KdvTutari" && e.Column.FieldName != "Tutar")
            {
                if (tablo.GetRowCellValue(e.RowHandle, "Miktar").ToString() != "0" && tablo.GetRowCellValue(e.RowHandle, "BirimFiyati").ToString() != "0")
                {
                    decimal miktar = Convert.ToDecimal(tablo.GetRowCellValue(e.RowHandle, "Miktar"));
                    decimal birimFiyati = Convert.ToDecimal(tablo.GetRowCellValue(e.RowHandle, "BirimFiyati"));
                    decimal miktarTutari = miktar * birimFiyati;
                    decimal iskontoOrani = Convert.ToDecimal(tablo.GetRowCellValue(e.RowHandle, "IskontoOrani"));
                    decimal iskontoTutari = iskontoOrani > 0 ? miktarTutari * iskontoOrani / 100 : 0;
                    decimal kdvHaricTutar = miktarTutari - iskontoTutari;
                    decimal kdvOrani = Convert.ToDecimal(tablo.GetRowCellValue(e.RowHandle, "KdvOrani"));
                    decimal kdvTutari = kdvOrani > 0 ? kdvHaricTutar * kdvOrani / 100 : 0;
                    decimal toplamTutar = kdvHaricTutar + kdvTutari;

                    tablo.SetRowCellValue(e.RowHandle, "MiktarTutari", miktarTutari);
                    tablo.SetRowCellValue(e.RowHandle, "IskontoTutari", iskontoTutari);
                    tablo.SetRowCellValue(e.RowHandle, "KdvHaricTutar", kdvHaricTutar);
                    tablo.SetRowCellValue(e.RowHandle, "KdvTutari", kdvTutari);
                    tablo.SetRowCellValue(e.RowHandle, "Tutar", toplamTutar);
                }
            }

            ((FaturaEditForm)OwnerForm).txtIlkTutar.Value = (decimal)tablo.DataController.ListSource.Cast<StokBilgileriList>().Where(x => !x.Delete).Sum(x => x.MiktarTutari);
            ((FaturaEditForm)OwnerForm).txtIskonto.Value = (decimal)tablo.DataController.ListSource.Cast<StokBilgileriList>().Where(x => !x.Delete).Sum(x => x.IskontoOrani > 0 ? x.MiktarTutari * x.IskontoOrani / 100 : 0);
            ((FaturaEditForm)OwnerForm).txtKdvHaricTutar.Value = (decimal)tablo.DataController.ListSource.Cast<StokBilgileriList>().Where(x => !x.Delete).Sum(x => x.MiktarTutari - x.IskontoTutari);
            ((FaturaEditForm)OwnerForm).txtKdvTutari.Value = (decimal)tablo.DataController.ListSource.Cast<StokBilgileriList>().Where(x => !x.Delete).Sum(x => x.KdvOrani > 0 ? x.KdvHaricTutar * x.KdvOrani / 100 : 0);
            ((FaturaEditForm)OwnerForm).txtToplamTutar.Value = (decimal)tablo.DataController.ListSource.Cast<StokBilgileriList>().Where(x => !x.Delete).Sum(x => x.KdvHaricTutar + x.KdvTutari);
        }

        protected override void Tablo_RowCountChanged(object sender, EventArgs e)
        {
            OwnerForm.btnSil.Enabled = tablo.DataController.ListSource.Cast<StokBilgileriList>().Where(x => !x.Delete).ToList().Any();
        }

        protected override void Tablo_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName != "IskontoOrani") return;
            e.Appearance.BackColor = Color.FromArgb(240, 240, 240);
            e.Appearance.FillRectangle(e.Cache, e.Bounds);
            e.Info.AllowDrawBackground = false;
        } 

        #endregion
    }
}
