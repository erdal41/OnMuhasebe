
namespace Muhasebe.UI.Win.UserControls.Tables.StokTables
{
    partial class StokBilgileriTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new Muhasebe.UI.Win.UserControls.Grids.MyGridControl();
            this.tablo = new Muhasebe.UI.Win.UserControls.Grids.MyGridView();
            this.colId = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colStokKodu = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colStokAdi = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colMiktar = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemMiktar = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colBirimAdi = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBirimFiyati = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemBirimFiyati = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colMiktarTutari = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colIskontoOrani = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemYuzde = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colIskontoTutari = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colKdvHaricTutar = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colKdvOrani = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colKdvTutari = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colTutar = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBirimFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemYuzde)).BeginInit();
            this.SuspendLayout();
            // 
            // insUpNavigator
            // 
            this.insUpNavigator.Location = new System.Drawing.Point(0, 325);
            this.insUpNavigator.Size = new System.Drawing.Size(758, 24);
            this.insUpNavigator.TabIndex = 1;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.tablo;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemBirimFiyati,
            this.repositoryItemDecimal,
            this.repositoryItemMiktar,
            this.repositoryItemYuzde});
            this.grid.Size = new System.Drawing.Size(758, 325);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
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
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colStokKodu,
            this.colStokAdi,
            this.colMiktar,
            this.colBirimAdi,
            this.colBirimFiyati,
            this.colMiktarTutari,
            this.colIskontoOrani,
            this.colIskontoTutari,
            this.colKdvHaricTutar,
            this.colKdvOrani,
            this.colKdvTutari,
            this.colTutar});
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
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "Stok ekleyiniz.";
            this.tablo.StatusBarKisaYol = "Shift+Insert : ";
            this.tablo.StatusBarKisaYolAciklama = "Stok Ekle";
            this.tablo.ViewCaption = "STOK BİLGİLERİ";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.OptionsFilter.AllowAutoFilter = false;
            this.colId.OptionsFilter.AllowFilter = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisaYol = null;
            this.colId.StatusBarKisaYolAciklama = null;
            // 
            // colStokKodu
            // 
            this.colStokKodu.AppearanceCell.Options.UseTextOptions = true;
            this.colStokKodu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStokKodu.Caption = "Stok Kodu";
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.OptionsFilter.AllowAutoFilter = false;
            this.colStokKodu.OptionsFilter.AllowFilter = false;
            this.colStokKodu.StatusBarAciklama = null;
            this.colStokKodu.StatusBarKisaYol = null;
            this.colStokKodu.StatusBarKisaYolAciklama = null;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 0;
            this.colStokKodu.Width = 250;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adı";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.OptionsFilter.AllowAutoFilter = false;
            this.colStokAdi.OptionsFilter.AllowFilter = false;
            this.colStokAdi.StatusBarAciklama = null;
            this.colStokAdi.StatusBarKisaYol = null;
            this.colStokAdi.StatusBarKisaYolAciklama = null;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 1;
            this.colStokAdi.Width = 250;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.ColumnEdit = this.repositoryItemMiktar;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsFilter.AllowAutoFilter = false;
            this.colMiktar.OptionsFilter.AllowFilter = false;
            this.colMiktar.StatusBarAciklama = "Miktar giriniz.";
            this.colMiktar.StatusBarKisaYol = null;
            this.colMiktar.StatusBarKisaYolAciklama = null;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 2;
            // 
            // repositoryItemMiktar
            // 
            this.repositoryItemMiktar.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMiktar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemMiktar.AutoHeight = false;
            this.repositoryItemMiktar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMiktar.DisplayFormat.FormatString = "n0";
            this.repositoryItemMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemMiktar.EditFormat.FormatString = "n0";
            this.repositoryItemMiktar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemMiktar.Mask.EditMask = "n0";
            this.repositoryItemMiktar.Name = "repositoryItemMiktar";
            // 
            // colBirimAdi
            // 
            this.colBirimAdi.Caption = "Birim";
            this.colBirimAdi.FieldName = "BirimAdi";
            this.colBirimAdi.Name = "colBirimAdi";
            this.colBirimAdi.OptionsColumn.AllowEdit = false;
            this.colBirimAdi.OptionsFilter.AllowAutoFilter = false;
            this.colBirimAdi.OptionsFilter.AllowFilter = false;
            this.colBirimAdi.StatusBarAciklama = null;
            this.colBirimAdi.StatusBarKisaYol = null;
            this.colBirimAdi.StatusBarKisaYolAciklama = null;
            this.colBirimAdi.Visible = true;
            this.colBirimAdi.VisibleIndex = 3;
            this.colBirimAdi.Width = 100;
            // 
            // colBirimFiyati
            // 
            this.colBirimFiyati.Caption = "Birim Fiyatı";
            this.colBirimFiyati.ColumnEdit = this.repositoryItemBirimFiyati;
            this.colBirimFiyati.FieldName = "BirimFiyati";
            this.colBirimFiyati.Name = "colBirimFiyati";
            this.colBirimFiyati.OptionsFilter.AllowAutoFilter = false;
            this.colBirimFiyati.OptionsFilter.AllowFilter = false;
            this.colBirimFiyati.StatusBarAciklama = "Birim fiyatı giriniz.";
            this.colBirimFiyati.StatusBarKisaYol = null;
            this.colBirimFiyati.StatusBarKisaYolAciklama = null;
            this.colBirimFiyati.Visible = true;
            this.colBirimFiyati.VisibleIndex = 4;
            this.colBirimFiyati.Width = 150;
            // 
            // repositoryItemBirimFiyati
            // 
            this.repositoryItemBirimFiyati.Appearance.Options.UseTextOptions = true;
            this.repositoryItemBirimFiyati.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemBirimFiyati.AutoHeight = false;
            this.repositoryItemBirimFiyati.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemBirimFiyati.DisplayFormat.FormatString = "{0:n5}";
            this.repositoryItemBirimFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemBirimFiyati.EditFormat.FormatString = "{0:n5}";
            this.repositoryItemBirimFiyati.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemBirimFiyati.Mask.EditMask = "n5";
            this.repositoryItemBirimFiyati.Name = "repositoryItemBirimFiyati";
            // 
            // colMiktarTutari
            // 
            this.colMiktarTutari.Caption = "Miktar Tutarı";
            this.colMiktarTutari.ColumnEdit = this.repositoryItemDecimal;
            this.colMiktarTutari.FieldName = "MiktarTutari";
            this.colMiktarTutari.Name = "colMiktarTutari";
            this.colMiktarTutari.OptionsColumn.AllowEdit = false;
            this.colMiktarTutari.StatusBarAciklama = null;
            this.colMiktarTutari.StatusBarKisaYol = null;
            this.colMiktarTutari.StatusBarKisaYolAciklama = null;
            this.colMiktarTutari.Visible = true;
            this.colMiktarTutari.VisibleIndex = 5;
            this.colMiktarTutari.Width = 150;
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
            this.repositoryItemDecimal.EditFormat.FormatString = "{0:n2}";
            this.repositoryItemDecimal.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.Mask.EditMask = "n2";
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
            // 
            // colIskontoOrani
            // 
            this.colIskontoOrani.Caption = "İskonto (%)";
            this.colIskontoOrani.ColumnEdit = this.repositoryItemYuzde;
            this.colIskontoOrani.FieldName = "IskontoOrani";
            this.colIskontoOrani.Name = "colIskontoOrani";
            this.colIskontoOrani.OptionsFilter.AllowAutoFilter = false;
            this.colIskontoOrani.OptionsFilter.AllowFilter = false;
            this.colIskontoOrani.StatusBarAciklama = "İskonto oranı giriniz.";
            this.colIskontoOrani.StatusBarKisaYol = null;
            this.colIskontoOrani.StatusBarKisaYolAciklama = null;
            this.colIskontoOrani.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "IskontoOrani", "TOPLAM :")});
            this.colIskontoOrani.Visible = true;
            this.colIskontoOrani.VisibleIndex = 6;
            this.colIskontoOrani.Width = 150;
            // 
            // repositoryItemYuzde
            // 
            this.repositoryItemYuzde.Appearance.Options.UseTextOptions = true;
            this.repositoryItemYuzde.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemYuzde.AutoHeight = false;
            this.repositoryItemYuzde.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemYuzde.DisplayFormat.FormatString = "{0:F0} %";
            this.repositoryItemYuzde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemYuzde.EditFormat.FormatString = "{0:F0} %";
            this.repositoryItemYuzde.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemYuzde.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repositoryItemYuzde.Name = "repositoryItemYuzde";
            // 
            // colIskontoTutari
            // 
            this.colIskontoTutari.Caption = "İskonto Tutarı";
            this.colIskontoTutari.ColumnEdit = this.repositoryItemDecimal;
            this.colIskontoTutari.FieldName = "IskontoTutari";
            this.colIskontoTutari.Name = "colIskontoTutari";
            this.colIskontoTutari.OptionsColumn.AllowEdit = false;
            this.colIskontoTutari.StatusBarAciklama = null;
            this.colIskontoTutari.StatusBarKisaYol = null;
            this.colIskontoTutari.StatusBarKisaYolAciklama = null;
            this.colIskontoTutari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IskontoTutari", "{0:n2}")});
            this.colIskontoTutari.Visible = true;
            this.colIskontoTutari.VisibleIndex = 7;
            this.colIskontoTutari.Width = 150;
            // 
            // colKdvHaricTutar
            // 
            this.colKdvHaricTutar.Caption = "Kdv Hariç Tutar";
            this.colKdvHaricTutar.ColumnEdit = this.repositoryItemDecimal;
            this.colKdvHaricTutar.FieldName = "KdvHaricTutar";
            this.colKdvHaricTutar.Name = "colKdvHaricTutar";
            this.colKdvHaricTutar.OptionsColumn.AllowEdit = false;
            this.colKdvHaricTutar.OptionsFilter.AllowAutoFilter = false;
            this.colKdvHaricTutar.OptionsFilter.AllowFilter = false;
            this.colKdvHaricTutar.StatusBarAciklama = null;
            this.colKdvHaricTutar.StatusBarKisaYol = null;
            this.colKdvHaricTutar.StatusBarKisaYolAciklama = null;
            this.colKdvHaricTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KdvHaricTutar", "{0:n2}")});
            this.colKdvHaricTutar.Visible = true;
            this.colKdvHaricTutar.VisibleIndex = 8;
            this.colKdvHaricTutar.Width = 150;
            // 
            // colKdvOrani
            // 
            this.colKdvOrani.Caption = "Kdv Oranı (%)";
            this.colKdvOrani.ColumnEdit = this.repositoryItemYuzde;
            this.colKdvOrani.FieldName = "KdvOrani";
            this.colKdvOrani.Name = "colKdvOrani";
            this.colKdvOrani.OptionsFilter.AllowAutoFilter = false;
            this.colKdvOrani.OptionsFilter.AllowFilter = false;
            this.colKdvOrani.StatusBarAciklama = "Kdv oranı giriniz.";
            this.colKdvOrani.StatusBarKisaYol = null;
            this.colKdvOrani.StatusBarKisaYolAciklama = null;
            this.colKdvOrani.Visible = true;
            this.colKdvOrani.VisibleIndex = 9;
            this.colKdvOrani.Width = 150;
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
            this.colKdvTutari.VisibleIndex = 10;
            this.colKdvTutari.Width = 150;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.ColumnEdit = this.repositoryItemDecimal;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.OptionsFilter.AllowAutoFilter = false;
            this.colTutar.OptionsFilter.AllowFilter = false;
            this.colTutar.StatusBarAciklama = null;
            this.colTutar.StatusBarKisaYol = null;
            this.colTutar.StatusBarKisaYolAciklama = null;
            this.colTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "{0:n2}")});
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 11;
            this.colTutar.Width = 150;
            // 
            // StokBilgileriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Name = "StokBilgileriTable";
            this.Size = new System.Drawing.Size(758, 349);
            this.Controls.SetChildIndex(this.insUpNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBirimFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemYuzde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Grids.MyGridControl grid;
        private Grids.MyGridView tablo;
        private Grids.MyGridColumn colId;
        private Grids.MyGridColumn colStokKodu;
        private Grids.MyGridColumn colStokAdi;
        private Grids.MyGridColumn colMiktar;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemMiktar;
        private Grids.MyGridColumn colBirimAdi;
        private Grids.MyGridColumn colBirimFiyati;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemBirimFiyati;
        private Grids.MyGridColumn colIskontoOrani;
        private Grids.MyGridColumn colKdvHaricTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private Grids.MyGridColumn colKdvOrani;
        private Grids.MyGridColumn colTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemYuzde;
        private Grids.MyGridColumn colMiktarTutari;
        private Grids.MyGridColumn colIskontoTutari;
        private Grids.MyGridColumn colKdvTutari;
    }
}
