
namespace Muhasebe.UI.Win.Forms.StokForms
{
    partial class StokListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokListForm));
            this.longNavigator = new Muhasebe.UI.Win.UserControls.Navigators.LongNavigator();
            this.grid = new Muhasebe.UI.Win.UserControls.Grids.MyGridControl();
            this.tablo = new Muhasebe.UI.Win.UserControls.Grids.MyGridView();
            this.colId = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colKod = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colStokAdi = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colBirimAdi = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colAlisFiyati = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.repositoryItemDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colAlisKdvOrani = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colSatisFiyati = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colSatisKdvOrani = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colAciklama = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(742, 109);
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
            this.longNavigator.Location = new System.Drawing.Point(0, 414);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(742, 24);
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
            this.grid.Size = new System.Drawing.Size(742, 305);
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
            this.colKod,
            this.colStokAdi,
            this.colBirimAdi,
            this.colAlisFiyati,
            this.colAlisKdvOrani,
            this.colSatisFiyati,
            this.colSatisKdvOrani,
            this.colAciklama});
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
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarAciklama = "Stok Kart Listesi";
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Stok Kart Listesi";
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
            // 
            // colKod
            // 
            this.colKod.AppearanceCell.Options.UseTextOptions = true;
            this.colKod.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = null;
            this.colKod.StatusBarKisaYolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 120;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Caption = "Stok Adi";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.StatusBarAciklama = null;
            this.colStokAdi.StatusBarKisaYol = null;
            this.colStokAdi.StatusBarKisaYolAciklama = null;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 1;
            this.colStokAdi.Width = 300;
            // 
            // colBirimAdi
            // 
            this.colBirimAdi.Caption = "Birim";
            this.colBirimAdi.FieldName = "BirimAdi";
            this.colBirimAdi.Name = "colBirimAdi";
            this.colBirimAdi.OptionsColumn.AllowEdit = false;
            this.colBirimAdi.StatusBarAciklama = null;
            this.colBirimAdi.StatusBarKisaYol = null;
            this.colBirimAdi.StatusBarKisaYolAciklama = null;
            this.colBirimAdi.Visible = true;
            this.colBirimAdi.VisibleIndex = 2;
            this.colBirimAdi.Width = 120;
            // 
            // colAlisFiyati
            // 
            this.colAlisFiyati.Caption = "Alış Fiyatı";
            this.colAlisFiyati.ColumnEdit = this.repositoryItemDecimal;
            this.colAlisFiyati.FieldName = "AlisFiyati";
            this.colAlisFiyati.Name = "colAlisFiyati";
            this.colAlisFiyati.OptionsColumn.AllowEdit = false;
            this.colAlisFiyati.StatusBarAciklama = null;
            this.colAlisFiyati.StatusBarKisaYol = null;
            this.colAlisFiyati.StatusBarKisaYolAciklama = null;
            this.colAlisFiyati.Visible = true;
            this.colAlisFiyati.VisibleIndex = 3;
            this.colAlisFiyati.Width = 120;
            // 
            // repositoryItemDecimal
            // 
            this.repositoryItemDecimal.Appearance.Options.UseTextOptions = true;
            this.repositoryItemDecimal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemDecimal.AutoHeight = false;
            this.repositoryItemDecimal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDecimal.DisplayFormat.FormatString = "{0:n5}";
            this.repositoryItemDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemDecimal.Name = "repositoryItemDecimal";
            // 
            // colAlisKdvOrani
            // 
            this.colAlisKdvOrani.Caption = "Alış K.D.V. Oranı";
            this.colAlisKdvOrani.FieldName = "AlisKdvOrani";
            this.colAlisKdvOrani.Name = "colAlisKdvOrani";
            this.colAlisKdvOrani.OptionsColumn.AllowEdit = false;
            this.colAlisKdvOrani.StatusBarAciklama = null;
            this.colAlisKdvOrani.StatusBarKisaYol = null;
            this.colAlisKdvOrani.StatusBarKisaYolAciklama = null;
            this.colAlisKdvOrani.Visible = true;
            this.colAlisKdvOrani.VisibleIndex = 4;
            this.colAlisKdvOrani.Width = 120;
            // 
            // colSatisFiyati
            // 
            this.colSatisFiyati.Caption = "Satış Fiyatı";
            this.colSatisFiyati.ColumnEdit = this.repositoryItemDecimal;
            this.colSatisFiyati.FieldName = "SatisFiyati";
            this.colSatisFiyati.Name = "colSatisFiyati";
            this.colSatisFiyati.OptionsColumn.AllowEdit = false;
            this.colSatisFiyati.StatusBarAciklama = null;
            this.colSatisFiyati.StatusBarKisaYol = null;
            this.colSatisFiyati.StatusBarKisaYolAciklama = null;
            this.colSatisFiyati.Visible = true;
            this.colSatisFiyati.VisibleIndex = 5;
            this.colSatisFiyati.Width = 120;
            // 
            // colSatisKdvOrani
            // 
            this.colSatisKdvOrani.Caption = "Satış K.D.V. Oranı";
            this.colSatisKdvOrani.FieldName = "AlisKdvOrani";
            this.colSatisKdvOrani.Name = "colSatisKdvOrani";
            this.colSatisKdvOrani.OptionsColumn.AllowEdit = false;
            this.colSatisKdvOrani.StatusBarAciklama = null;
            this.colSatisKdvOrani.StatusBarKisaYol = null;
            this.colSatisKdvOrani.StatusBarKisaYolAciklama = null;
            this.colSatisKdvOrani.Visible = true;
            this.colSatisKdvOrani.VisibleIndex = 6;
            this.colSatisKdvOrani.Width = 120;
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
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 7;
            this.colAciklama.Width = 350;
            // 
            // StokListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 462);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "StokListForm";
            this.Text = "Stok Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl grid;
        private UserControls.Grids.MyGridView tablo;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colKod;
        private UserControls.Grids.MyGridColumn colStokAdi;
        private UserControls.Grids.MyGridColumn colBirimAdi;
        private UserControls.Grids.MyGridColumn colAlisFiyati;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemDecimal;
        private UserControls.Grids.MyGridColumn colAlisKdvOrani;
        private UserControls.Grids.MyGridColumn colSatisFiyati;
        private UserControls.Grids.MyGridColumn colSatisKdvOrani;
        private UserControls.Grids.MyGridColumn colAciklama;
    }
}