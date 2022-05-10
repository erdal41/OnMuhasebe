
namespace Muhasebe.UI.Win.Forms.CariForms
{
    partial class CariHareketleriListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariHareketleriListForm));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.colBakiye = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.longNavigator = new Muhasebe.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new Muhasebe.UI.Win.UserControls.Grids.MyGridControl();
            this.tablo = new Muhasebe.UI.Win.UserControls.Grids.MyGridView();
            this.colId = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colHesapKodu = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCariAdi = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colTarih = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBelgeNo = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colOdemeTipi = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colAciklama = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBorc = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colAlacak = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
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
            // colBakiye
            // 
            this.colBakiye.Caption = "Bakiye";
            this.colBakiye.ColumnEdit = this.repositoryItemDecimal;
            this.colBakiye.FieldName = "Bakiye";
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.OptionsColumn.AllowEdit = false;
            this.colBakiye.StatusBarAciklama = null;
            this.colBakiye.StatusBarKisaYol = null;
            this.colBakiye.StatusBarKisaYolAciklama = null;
            this.colBakiye.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Bakiye", "{0:n2}")});
            this.colBakiye.Visible = true;
            this.colBakiye.VisibleIndex = 8;
            this.colBakiye.Width = 150;
            // 
            // repositoryItemDecimal
            // 
            this.repositoryItemDecimal.AutoHeight = false;
            this.repositoryItemDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDecimal.DisplayFormat.FormatString = "{0:n2}";
            this.repositoryItemDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
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
            this.repositoryItemDecimal});
            this.grid.Size = new System.Drawing.Size(1098, 342);
            this.grid.TabIndex = 3;
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
            this.colHesapKodu,
            this.colCariAdi,
            this.colTarih,
            this.colBelgeNo,
            this.colOdemeTipi,
            this.colAciklama,
            this.colBorc,
            this.colAlacak,
            this.colBakiye});
            gridFormatRule1.Column = this.colBakiye;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.White;
            formatConditionRuleExpression1.Appearance.Options.HighPriority = true;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "[Bakiye] = 0";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.Column = this.colBakiye;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression2.Appearance.Options.HighPriority = true;
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Expression = "[Bakiye] < 0";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            gridFormatRule3.Column = this.colBakiye;
            gridFormatRule3.Name = "Format2";
            formatConditionRuleExpression3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression3.Appearance.Options.HighPriority = true;
            formatConditionRuleExpression3.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression3.Expression = "[Bakiye] > 0";
            gridFormatRule3.Rule = formatConditionRuleExpression3;
            this.tablo.FormatRules.Add(gridFormatRule1);
            this.tablo.FormatRules.Add(gridFormatRule2);
            this.tablo.FormatRules.Add(gridFormatRule3);
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
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowFooter = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "Cari Hesap Hareket Detayları";
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Cari Hesap Hareket Detayları";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarAciklama = null;
            this.colId.StatusBarKisaYol = null;
            this.colId.StatusBarKisaYolAciklama = null;
            this.colId.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // colHesapKodu
            // 
            this.colHesapKodu.Caption = "Hesap Kodu";
            this.colHesapKodu.FieldName = "HesapKodu";
            this.colHesapKodu.Name = "colHesapKodu";
            this.colHesapKodu.OptionsColumn.AllowEdit = false;
            this.colHesapKodu.StatusBarAciklama = null;
            this.colHesapKodu.StatusBarKisaYol = null;
            this.colHesapKodu.StatusBarKisaYolAciklama = null;
            this.colHesapKodu.Visible = true;
            this.colHesapKodu.VisibleIndex = 0;
            this.colHesapKodu.Width = 150;
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
            this.colCariAdi.VisibleIndex = 1;
            this.colCariAdi.Width = 250;
            // 
            // colTarih
            // 
            this.colTarih.AppearanceCell.Options.UseTextOptions = true;
            this.colTarih.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.StatusBarAciklama = null;
            this.colTarih.StatusBarKisaYol = null;
            this.colTarih.StatusBarKisaYolAciklama = null;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 2;
            this.colTarih.Width = 120;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.AppearanceCell.Options.UseTextOptions = true;
            this.colBelgeNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBelgeNo.Caption = "Belge No";
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            this.colBelgeNo.StatusBarAciklama = null;
            this.colBelgeNo.StatusBarKisaYol = null;
            this.colBelgeNo.StatusBarKisaYolAciklama = null;
            this.colBelgeNo.Visible = true;
            this.colBelgeNo.VisibleIndex = 3;
            this.colBelgeNo.Width = 150;
            // 
            // colOdemeTipi
            // 
            this.colOdemeTipi.AppearanceCell.Options.UseTextOptions = true;
            this.colOdemeTipi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOdemeTipi.Caption = "Ödeme Tipi";
            this.colOdemeTipi.FieldName = "OdemeTipi";
            this.colOdemeTipi.Name = "colOdemeTipi";
            this.colOdemeTipi.OptionsColumn.AllowEdit = false;
            this.colOdemeTipi.StatusBarAciklama = null;
            this.colOdemeTipi.StatusBarKisaYol = null;
            this.colOdemeTipi.StatusBarKisaYolAciklama = null;
            this.colOdemeTipi.Visible = true;
            this.colOdemeTipi.VisibleIndex = 4;
            this.colOdemeTipi.Width = 150;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.StatusBarAciklama = null;
            this.colAciklama.StatusBarKisaYol = null;
            this.colAciklama.StatusBarKisaYolAciklama = null;
            this.colAciklama.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Aciklama", "TOPLAM:", "TOPLAM:")});
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 5;
            this.colAciklama.Width = 250;
            // 
            // colBorc
            // 
            this.colBorc.Caption = "Borç";
            this.colBorc.ColumnEdit = this.repositoryItemDecimal;
            this.colBorc.FieldName = "Borc";
            this.colBorc.Name = "colBorc";
            this.colBorc.OptionsColumn.AllowEdit = false;
            this.colBorc.StatusBarAciklama = null;
            this.colBorc.StatusBarKisaYol = null;
            this.colBorc.StatusBarKisaYolAciklama = null;
            this.colBorc.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Borc", "{0:n2}")});
            this.colBorc.Visible = true;
            this.colBorc.VisibleIndex = 6;
            this.colBorc.Width = 150;
            // 
            // colAlacak
            // 
            this.colAlacak.Caption = "Alacak";
            this.colAlacak.ColumnEdit = this.repositoryItemDecimal;
            this.colAlacak.FieldName = "Alacak";
            this.colAlacak.Name = "colAlacak";
            this.colAlacak.OptionsColumn.AllowEdit = false;
            this.colAlacak.StatusBarAciklama = null;
            this.colAlacak.StatusBarKisaYol = null;
            this.colAlacak.StatusBarKisaYolAciklama = null;
            this.colAlacak.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Alacak", "{0:n2}")});
            this.colAlacak.Visible = true;
            this.colAlacak.VisibleIndex = 7;
            this.colAlacak.Width = 150;
            // 
            // CariHareketleriListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 499);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "CariHareketleriListForm";
            this.Text = "Cari Hesap Hareket Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl grid;
        private UserControls.Grids.MyGridView tablo;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colHesapKodu;
        private UserControls.Grids.MyGridColumn colCariAdi;
        private UserControls.Grids.MyGridColumn colTarih;
        private UserControls.Grids.MyGridColumn colBelgeNo;
        private UserControls.Grids.MyGridColumn colOdemeTipi;
        private UserControls.Grids.MyGridColumn colAciklama;
        private UserControls.Grids.MyGridColumn colBorc;
        private UserControls.Grids.MyGridColumn colAlacak;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private UserControls.Grids.MyGridColumn colBakiye;
    }
}