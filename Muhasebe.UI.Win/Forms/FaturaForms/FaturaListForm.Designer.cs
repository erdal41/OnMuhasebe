
namespace Muhasebe.UI.Win.Forms.FaturaForms
{
    partial class FaturaListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaListForm));
            this.longNavigator = new Muhasebe.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new Muhasebe.UI.Win.UserControls.Grids.MyBandedGridControl();
            this.tablo = new Muhasebe.UI.Win.UserControls.Grids.MyBandedGridView();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCariKodu = new Muhasebe.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colCariAdi = new Muhasebe.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFaturaTipi = new Muhasebe.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colKod = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colFaturaTarihi = new Muhasebe.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemTarih = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colVadeTarihi = new Muhasebe.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colFaturaTuru = new Muhasebe.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIrsaliyeNo = new Muhasebe.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colIrsaliyeTarihi = new Muhasebe.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIlkTutar = new Muhasebe.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colIskonto = new Muhasebe.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.repositoryItemYuzde = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colNetTutar = new Muhasebe.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colKdvTutari = new Muhasebe.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colToplamTutar = new Muhasebe.UI.Win.UserControls.Grids.MyBandedGridColumn();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemYuzde)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGonder
            // 
            this.btnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.Image")));
            this.btnGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGonder.ImageOptions.LargeImage")));
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 451);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1098, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDecimal,
            this.repositoryItemTarih,
            this.repositoryItemYuzde});
            this.grid.Size = new System.Drawing.Size(1098, 342);
            this.grid.TabIndex = 3;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.BandPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.BandPanel.ForeColor = System.Drawing.Color.DarkBlue;
            this.tablo.Appearance.BandPanel.Options.UseFont = true;
            this.tablo.Appearance.BandPanel.Options.UseForeColor = true;
            this.tablo.Appearance.BandPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseFont = true;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.BandPanelRowHeight = 40;
            this.tablo.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand3,
            this.gridBand1,
            this.gridBand2,
            this.gridBand4});
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colKod,
            this.colFaturaTipi,
            this.colFaturaTarihi,
            this.colVadeTarihi,
            this.colFaturaTuru,
            this.colIrsaliyeNo,
            this.colIrsaliyeTarihi,
            this.colCariKodu,
            this.colCariAdi,
            this.colIlkTutar,
            this.colIskonto,
            this.colNetTutar,
            this.colKdvTutari,
            this.colToplamTutar});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "Fatura Detay Listesi";
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Fatura Detay Listesi";
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Cari Bilgileri";
            this.gridBand3.Columns.Add(this.colCariKodu);
            this.gridBand3.Columns.Add(this.colCariAdi);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 0;
            this.gridBand3.Width = 500;
            // 
            // colCariKodu
            // 
            this.colCariKodu.Caption = "Cari Kodu";
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.OptionsColumn.AllowEdit = false;
            this.colCariKodu.StatusBarAciklama = null;
            this.colCariKodu.StatusBarKisaYol = null;
            this.colCariKodu.StatusBarKisaYolAciklama = null;
            this.colCariKodu.Visible = true;
            this.colCariKodu.Width = 200;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Caption = "Cari Adı";
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.OptionsColumn.AllowEdit = false;
            this.colCariAdi.StatusBarAciklama = null;
            this.colCariAdi.StatusBarKisaYol = null;
            this.colCariAdi.StatusBarKisaYolAciklama = null;
            this.colCariAdi.Visible = true;
            this.colCariAdi.Width = 300;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Fatura Bilgileri";
            this.gridBand1.Columns.Add(this.colFaturaTipi);
            this.gridBand1.Columns.Add(this.colKod);
            this.gridBand1.Columns.Add(this.colFaturaTarihi);
            this.gridBand1.Columns.Add(this.colVadeTarihi);
            this.gridBand1.Columns.Add(this.colFaturaTuru);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 1;
            this.gridBand1.Width = 600;
            // 
            // colFaturaTipi
            // 
            this.colFaturaTipi.Caption = "Fatura Tipi";
            this.colFaturaTipi.FieldName = "FaturaTipi";
            this.colFaturaTipi.Name = "colFaturaTipi";
            this.colFaturaTipi.OptionsColumn.AllowEdit = false;
            this.colFaturaTipi.StatusBarAciklama = null;
            this.colFaturaTipi.StatusBarKisaYol = null;
            this.colFaturaTipi.StatusBarKisaYolAciklama = null;
            this.colFaturaTipi.Visible = true;
            this.colFaturaTipi.Width = 120;
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Fatura No";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.Visible = true;
            this.colKod.Width = 120;
            // 
            // colFaturaTarihi
            // 
            this.colFaturaTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colFaturaTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFaturaTarihi.Caption = "Fatura Tarihi";
            this.colFaturaTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colFaturaTarihi.FieldName = "FaturaTarihi";
            this.colFaturaTarihi.Name = "colFaturaTarihi";
            this.colFaturaTarihi.OptionsColumn.AllowEdit = false;
            this.colFaturaTarihi.StatusBarAciklama = null;
            this.colFaturaTarihi.StatusBarKisaYol = null;
            this.colFaturaTarihi.StatusBarKisaYolAciklama = null;
            this.colFaturaTarihi.Visible = true;
            this.colFaturaTarihi.Width = 120;
            // 
            // repositoryItemTarih
            // 
            this.repositoryItemTarih.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTarih.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemTarih.AutoHeight = false;
            this.repositoryItemTarih.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTarih.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemTarih.Name = "repositoryItemTarih";
            // 
            // colVadeTarihi
            // 
            this.colVadeTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colVadeTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVadeTarihi.Caption = "Vade Tarihi";
            this.colVadeTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colVadeTarihi.FieldName = "VadeTarihi";
            this.colVadeTarihi.Name = "colVadeTarihi";
            this.colVadeTarihi.OptionsColumn.AllowEdit = false;
            this.colVadeTarihi.StatusBarAciklama = null;
            this.colVadeTarihi.StatusBarKisaYol = null;
            this.colVadeTarihi.StatusBarKisaYolAciklama = null;
            this.colVadeTarihi.Visible = true;
            this.colVadeTarihi.Width = 120;
            // 
            // colFaturaTuru
            // 
            this.colFaturaTuru.Caption = "FaturaTuru";
            this.colFaturaTuru.FieldName = "FaturaTuru";
            this.colFaturaTuru.Name = "colFaturaTuru";
            this.colFaturaTuru.OptionsColumn.AllowEdit = false;
            this.colFaturaTuru.StatusBarAciklama = null;
            this.colFaturaTuru.StatusBarKisaYol = null;
            this.colFaturaTuru.StatusBarKisaYolAciklama = null;
            this.colFaturaTuru.Visible = true;
            this.colFaturaTuru.Width = 120;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "İrsaliye Bilgileri";
            this.gridBand2.Columns.Add(this.colIrsaliyeNo);
            this.gridBand2.Columns.Add(this.colIrsaliyeTarihi);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 2;
            this.gridBand2.Width = 240;
            // 
            // colIrsaliyeNo
            // 
            this.colIrsaliyeNo.Caption = "İrsaliye No";
            this.colIrsaliyeNo.FieldName = "IrsaliyeNo";
            this.colIrsaliyeNo.Name = "colIrsaliyeNo";
            this.colIrsaliyeNo.OptionsColumn.AllowEdit = false;
            this.colIrsaliyeNo.StatusBarAciklama = null;
            this.colIrsaliyeNo.StatusBarKisaYol = null;
            this.colIrsaliyeNo.StatusBarKisaYolAciklama = null;
            this.colIrsaliyeNo.Visible = true;
            this.colIrsaliyeNo.Width = 120;
            // 
            // colIrsaliyeTarihi
            // 
            this.colIrsaliyeTarihi.AppearanceCell.Options.UseTextOptions = true;
            this.colIrsaliyeTarihi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIrsaliyeTarihi.Caption = "İrsaliye Tarihi";
            this.colIrsaliyeTarihi.ColumnEdit = this.repositoryItemTarih;
            this.colIrsaliyeTarihi.FieldName = "IrsaliyeTarihi";
            this.colIrsaliyeTarihi.Name = "colIrsaliyeTarihi";
            this.colIrsaliyeTarihi.OptionsColumn.AllowEdit = false;
            this.colIrsaliyeTarihi.StatusBarAciklama = null;
            this.colIrsaliyeTarihi.StatusBarKisaYol = null;
            this.colIrsaliyeTarihi.StatusBarKisaYolAciklama = null;
            this.colIrsaliyeTarihi.Visible = true;
            this.colIrsaliyeTarihi.Width = 120;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Tutar Bilgileri";
            this.gridBand4.Columns.Add(this.colIlkTutar);
            this.gridBand4.Columns.Add(this.colIskonto);
            this.gridBand4.Columns.Add(this.colNetTutar);
            this.gridBand4.Columns.Add(this.colKdvTutari);
            this.gridBand4.Columns.Add(this.colToplamTutar);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 555;
            // 
            // colIlkTutar
            // 
            this.colIlkTutar.Caption = "İlk Tutar";
            this.colIlkTutar.ColumnEdit = this.repositoryItemDecimal;
            this.colIlkTutar.FieldName = "IlkTutar";
            this.colIlkTutar.Name = "colIlkTutar";
            this.colIlkTutar.OptionsColumn.AllowEdit = false;
            this.colIlkTutar.StatusBarAciklama = null;
            this.colIlkTutar.StatusBarKisaYol = null;
            this.colIlkTutar.StatusBarKisaYolAciklama = null;
            this.colIlkTutar.Visible = true;
            this.colIlkTutar.Width = 120;
            // 
            // repositoryItemDecimal
            // 
            this.repositoryItemDecimal.Appearance.Options.UseTextOptions = true;
            this.repositoryItemDecimal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemDecimal.AutoHeight = false;
            this.repositoryItemDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryItemDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
            // 
            // colIskonto
            // 
            this.colIskonto.Caption = "İskonto (%)";
            this.colIskonto.ColumnEdit = this.repositoryItemYuzde;
            this.colIskonto.FieldName = "Iskonto";
            this.colIskonto.Name = "colIskonto";
            this.colIskonto.OptionsColumn.AllowEdit = false;
            this.colIskonto.StatusBarAciklama = null;
            this.colIskonto.StatusBarKisaYol = null;
            this.colIskonto.StatusBarKisaYolAciklama = null;
            this.colIskonto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Iskonto", "TOPLAM :")});
            this.colIskonto.Visible = true;
            // 
            // repositoryItemYuzde
            // 
            this.repositoryItemYuzde.AutoHeight = false;
            this.repositoryItemYuzde.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemYuzde.DisplayFormat.FormatString = "{0:F} %";
            this.repositoryItemYuzde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemYuzde.Name = "repositoryItemYuzde";
            // 
            // colNetTutar
            // 
            this.colNetTutar.Caption = "Net Tutar";
            this.colNetTutar.ColumnEdit = this.repositoryItemDecimal;
            this.colNetTutar.FieldName = "NetTutar";
            this.colNetTutar.Name = "colNetTutar";
            this.colNetTutar.OptionsColumn.AllowEdit = false;
            this.colNetTutar.StatusBarAciklama = null;
            this.colNetTutar.StatusBarKisaYol = null;
            this.colNetTutar.StatusBarKisaYolAciklama = null;
            this.colNetTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetTutar", "{0:n2}")});
            this.colNetTutar.Visible = true;
            this.colNetTutar.Width = 120;
            // 
            // colKdvTutari
            // 
            this.colKdvTutari.Caption = "Kdv Tutarı";
            this.colKdvTutari.ColumnEdit = this.repositoryItemDecimal;
            this.colKdvTutari.FieldName = "KdvTutari";
            this.colKdvTutari.Name = "colKdvTutari";
            this.colKdvTutari.OptionsColumn.AllowEdit = false;
            this.colKdvTutari.StatusBarAciklama = null;
            this.colKdvTutari.StatusBarKisaYol = null;
            this.colKdvTutari.StatusBarKisaYolAciklama = null;
            this.colKdvTutari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KdvTutari", "{0:n2}")});
            this.colKdvTutari.Visible = true;
            this.colKdvTutari.Width = 120;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Caption = "Toplam Tutar";
            this.colToplamTutar.ColumnEdit = this.repositoryItemDecimal;
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.StatusBarAciklama = null;
            this.colToplamTutar.StatusBarKisaYol = null;
            this.colToplamTutar.StatusBarKisaYolAciklama = null;
            this.colToplamTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ToplamTutar", "{0:n2}")});
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.Width = 120;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // FaturaListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 499);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "FaturaListForm";
            this.Text = "Fatura Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemYuzde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyBandedGridControl grid;
        private UserControls.Grids.MyBandedGridView tablo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKod;
        private UserControls.Grids.MyBandedGridColumn colFaturaTipi;
        private UserControls.Grids.MyBandedGridColumn colFaturaTarihi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemTarih;
        private UserControls.Grids.MyBandedGridColumn colVadeTarihi;
        private UserControls.Grids.MyBandedGridColumn colFaturaTuru;
        private UserControls.Grids.MyBandedGridColumn colIrsaliyeNo;
        private UserControls.Grids.MyBandedGridColumn colIrsaliyeTarihi;
        private UserControls.Grids.MyBandedGridColumn colCariKodu;
        private UserControls.Grids.MyBandedGridColumn colCariAdi;
        private UserControls.Grids.MyBandedGridColumn colIlkTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private UserControls.Grids.MyBandedGridColumn colIskonto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemYuzde;
        private UserControls.Grids.MyBandedGridColumn colNetTutar;
        private UserControls.Grids.MyBandedGridColumn colKdvTutari;
        private UserControls.Grids.MyBandedGridColumn colToplamTutar;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
    }
}