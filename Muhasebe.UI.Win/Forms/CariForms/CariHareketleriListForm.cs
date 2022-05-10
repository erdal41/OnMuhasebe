using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.Common.Messages;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Show;
using Muhasebe.UI.Win.Functions;
using System;
using System.Windows.Forms;
using System.Drawing;
using Muhasebe.Model.Dto;
using Muhasebe.Bll.Functions;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.FaturaForms;
using DevExpress.XtraBars;

namespace Muhasebe.UI.Win.Forms.CariForms
{
    public partial class CariHareketleriListForm : BaseListForm
    {
        #region Variables

        private readonly long _cariId;

        #endregion

        public CariHareketleriListForm(params object[] prm)
        {
            InitializeComponent();
            Bll = new CariHareketleriBll();
            HideItems = new BarItem[] { btnSec };
            _cariId = (long)prm[0];
        }

        #region Functions

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.CariHareketleri;
            FormShow = new ShowEditForms<CariHareketFisiEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((CariHareketleriBll)Bll).List(x => x.CariId == _cariId);

            decimal borc = 0;
            decimal alacak = 0;
            for (int i = 0; i < tablo.DataRowCount; i++)
            {
                decimal cBorc = Convert.ToDecimal(tablo.GetRowCellValue(i, "Borc"));
                decimal cAlacak = Convert.ToDecimal(tablo.GetRowCellValue(i, "Alacak"));

                if (i == 0)
                {
                    borc = cBorc;
                    alacak = cAlacak;
                }
                else
                {
                    borc += cBorc;
                    alacak += cAlacak;
                }

                decimal bakiye = alacak - borc;
                tablo.SetRowCellValue(i, "Bakiye", bakiye);
            }
        }

        protected override void Duzelt()
        {
            var entity = Tablo.GetRow<CariHareketleriList>();
            if (entity == null) return;

            using (var bll = new FaturaBll())
            {
                var faturaKontrol = bll.Single(x => x.Id == entity.FaturaId).EntityConvert<Fatura>();

                if (faturaKontrol != null)
                {
                    Messages.HataMesaji("Seçilen 'Cari Hesap Hareketi' 'Fatura' olarak eklendiğinden dolayı düzeltme işlemi 'Fatura Kartları' kısmından yapabilirsiniz.");

                    if (Messages.EvetSeciliEvetHayir("Seçilen 'Cari Hesap Hareketi' 'Fatura' düzenleme olarak açılsın mı?", "Fatura düzenleme modunda açılsın mı?") != DialogResult.Yes) return;
                    ShowEditForms<FaturaEditForm>.ShowDialogEditForm(KartTuru.Fatura, (long)entity.FaturaId);
                }
                else
                {
                    base.Duzelt();
                }
            }
        }

        protected override void EntityDelete()
        {
            if (Messages.HayirSeciliEvetHayir("Seçili olan 'Cari Hesap Hareketi' silinecektir. Onaylıyor musunuz?", "Silme Onayı") != DialogResult.Yes) return;

            var entity = Tablo.GetRow<CariHareketleriList>();
            if (entity == null) return;

            using (var bll = new FaturaBll())
            {
                var faturaKontrol = bll.Single(x => x.Id == entity.FaturaId).EntityConvert<Fatura>();

                if (faturaKontrol != null)
                {
                    Messages.HataMesaji("Seçilen 'Cari Hesap Hareketi' 'Fatura' olarak eklendiğinden dolayı silme işlemi yapamazsınız.");
                }
                else
                {
                    base.EntityDelete();
                }
            }
        }

        #endregion

        #region Events

        protected override void Tablo_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Bakiye" && e.ListSourceRowIndex != GridControl.InvalidRowHandle)
            {
                //int currencyType = (int)view.GetListSourceRowCellValue(e.ListSourceRowIndex, "NumericType");
                decimal bakiye = Convert.ToDecimal(e.Value);

                if (bakiye > 0)
                {
                    e.DisplayText = string.Format("{0:n2} A", bakiye);
                }
                else if (bakiye < 0)
                {
                    bakiye *= -1;
                    e.DisplayText = string.Format("{0:n2} B", bakiye);
                }
            }
        }

        protected override void Tablo_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
        {
            if (e.SummaryProcess != CustomSummaryProcess.Finalize) return;

            var item = (GridSummaryItem)e.Item;
            if (item.FieldName != "Bakiye") return;

            if (e.IsTotalSummary)
            {
                var borclarToplami = Convert.ToDecimal(colBorc.SummaryItem.SummaryValue);
                var alacaklarToplami = Convert.ToDecimal(colAlacak.SummaryItem.SummaryValue);
                decimal bakiye = alacaklarToplami - borclarToplami;
                e.TotalValue = bakiye;
            }
        }

        protected override void Tablo_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Aciklama")
            {
                e.Appearance.BackColor = Color.FromArgb(240, 240, 240);
                e.Appearance.FillRectangle(e.Cache, e.Bounds);
                e.Info.AllowDrawBackground = false;
            }

            if (e.Column.FieldName != "Bakiye") return;

            decimal bakiye = (decimal)e.Info.Value;
            if (bakiye > 0)
            {
                e.Info.Appearance.BackColor = Color.Red;
                e.Info.SummaryItem.DisplayFormat = "{0:n2} A";
            }
            else if (bakiye < 0)
            {
                bakiye *= -1;
                e.Appearance.BackColor = Color.Red;
                e.Info.DisplayText = string.Format("{0:n2} B", bakiye);
            }
            else if (bakiye == 0)
            {
                e.Info.Appearance.BackColor = Color.Orange;
                e.Info.SummaryItem.DisplayFormat = "{0:n2}";
            }
        }

        #endregion
    }
}