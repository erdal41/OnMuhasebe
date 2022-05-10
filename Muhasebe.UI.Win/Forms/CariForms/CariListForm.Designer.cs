
namespace Muhasebe.UI.Win.Forms.CariForms
{
    partial class CariListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariListForm));
            this.grid = new Muhasebe.UI.Win.UserControls.Grids.MyGridControl();
            this.tablo = new Muhasebe.UI.Win.UserControls.Grids.MyGridView();
            this.colId = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colKod = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCariAdi = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colTcKimlikNo = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colVergiDairesi = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colVergiNo = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colTelefon1 = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colTelefon2 = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colTelefon3 = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colFax = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colEmail = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colWebsite = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colAdres = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colPostaKodu = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIlceAdi = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colIlAdi = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colUlkeAdi = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCariTipi = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colOzelKod1Adi = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colOzelKod2Adi = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.colAciklama = new Muhasebe.UI.Win.UserControls.Grids.MyGridColumn();
            this.longNavigator = new Muhasebe.UI.Win.UserControls.Navigators.LongNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
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
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 109);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1098, 471);
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
            this.colCariAdi,
            this.colTcKimlikNo,
            this.colVergiDairesi,
            this.colVergiNo,
            this.colTelefon1,
            this.colTelefon2,
            this.colTelefon3,
            this.colFax,
            this.colEmail,
            this.colWebsite,
            this.colAdres,
            this.colPostaKodu,
            this.colIlceAdi,
            this.colIlAdi,
            this.colUlkeAdi,
            this.colCariTipi,
            this.colOzelKod1Adi,
            this.colOzelKod2Adi,
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
            this.tablo.StatusBarAciklama = "Cari Kart Detayları";
            this.tablo.StatusBarKisaYol = null;
            this.tablo.StatusBarKisaYolAciklama = null;
            this.tablo.ViewCaption = "Cari Kart Detayları";
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
            this.colKod.Caption = "Kod";
            this.colKod.FieldName = "Kod";
            this.colKod.Name = "colKod";
            this.colKod.OptionsColumn.AllowEdit = false;
            this.colKod.StatusBarAciklama = null;
            this.colKod.StatusBarKisaYol = null;
            this.colKod.StatusBarKisaYolAciklama = null;
            this.colKod.Visible = true;
            this.colKod.VisibleIndex = 0;
            this.colKod.Width = 200;
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
            this.colCariAdi.Width = 300;
            // 
            // colTcKimlikNo
            // 
            this.colTcKimlikNo.Caption = "T.C. Kimlik No";
            this.colTcKimlikNo.FieldName = "TcKimlikNo";
            this.colTcKimlikNo.Name = "colTcKimlikNo";
            this.colTcKimlikNo.OptionsColumn.AllowEdit = false;
            this.colTcKimlikNo.StatusBarAciklama = null;
            this.colTcKimlikNo.StatusBarKisaYol = null;
            this.colTcKimlikNo.StatusBarKisaYolAciklama = null;
            this.colTcKimlikNo.Visible = true;
            this.colTcKimlikNo.VisibleIndex = 2;
            this.colTcKimlikNo.Width = 120;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.Caption = "Vergi Dairesi";
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.OptionsColumn.AllowEdit = false;
            this.colVergiDairesi.StatusBarAciklama = null;
            this.colVergiDairesi.StatusBarKisaYol = null;
            this.colVergiDairesi.StatusBarKisaYolAciklama = null;
            this.colVergiDairesi.Visible = true;
            this.colVergiDairesi.VisibleIndex = 3;
            this.colVergiDairesi.Width = 120;
            // 
            // colVergiNo
            // 
            this.colVergiNo.Caption = "Vergi No";
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.OptionsColumn.AllowEdit = false;
            this.colVergiNo.StatusBarAciklama = null;
            this.colVergiNo.StatusBarKisaYol = null;
            this.colVergiNo.StatusBarKisaYolAciklama = null;
            this.colVergiNo.Visible = true;
            this.colVergiNo.VisibleIndex = 4;
            this.colVergiNo.Width = 120;
            // 
            // colTelefon1
            // 
            this.colTelefon1.Caption = "Telefon-1";
            this.colTelefon1.FieldName = "Telefon1";
            this.colTelefon1.Name = "colTelefon1";
            this.colTelefon1.OptionsColumn.AllowEdit = false;
            this.colTelefon1.StatusBarAciklama = null;
            this.colTelefon1.StatusBarKisaYol = null;
            this.colTelefon1.StatusBarKisaYolAciklama = null;
            this.colTelefon1.Visible = true;
            this.colTelefon1.VisibleIndex = 5;
            this.colTelefon1.Width = 120;
            // 
            // colTelefon2
            // 
            this.colTelefon2.Caption = "Telefon-2";
            this.colTelefon2.FieldName = "Telefon2";
            this.colTelefon2.Name = "colTelefon2";
            this.colTelefon2.OptionsColumn.AllowEdit = false;
            this.colTelefon2.StatusBarAciklama = null;
            this.colTelefon2.StatusBarKisaYol = null;
            this.colTelefon2.StatusBarKisaYolAciklama = null;
            this.colTelefon2.Visible = true;
            this.colTelefon2.VisibleIndex = 7;
            this.colTelefon2.Width = 120;
            // 
            // colTelefon3
            // 
            this.colTelefon3.Caption = "Telefon-3";
            this.colTelefon3.FieldName = "Telefon3";
            this.colTelefon3.Name = "colTelefon3";
            this.colTelefon3.OptionsColumn.AllowEdit = false;
            this.colTelefon3.StatusBarAciklama = null;
            this.colTelefon3.StatusBarKisaYol = null;
            this.colTelefon3.StatusBarKisaYolAciklama = null;
            this.colTelefon3.Visible = true;
            this.colTelefon3.VisibleIndex = 8;
            this.colTelefon3.Width = 120;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowEdit = false;
            this.colFax.StatusBarAciklama = null;
            this.colFax.StatusBarKisaYol = null;
            this.colFax.StatusBarKisaYolAciklama = null;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 6;
            this.colFax.Width = 120;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "E-Mail";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.StatusBarAciklama = null;
            this.colEmail.StatusBarKisaYol = null;
            this.colEmail.StatusBarKisaYolAciklama = null;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 9;
            this.colEmail.Width = 120;
            // 
            // colWebsite
            // 
            this.colWebsite.Caption = "Website";
            this.colWebsite.FieldName = "Website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.OptionsColumn.AllowEdit = false;
            this.colWebsite.StatusBarAciklama = null;
            this.colWebsite.StatusBarKisaYol = null;
            this.colWebsite.StatusBarKisaYolAciklama = null;
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 10;
            this.colWebsite.Width = 120;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.StatusBarAciklama = null;
            this.colAdres.StatusBarKisaYol = null;
            this.colAdres.StatusBarKisaYolAciklama = null;
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 11;
            this.colAdres.Width = 300;
            // 
            // colPostaKodu
            // 
            this.colPostaKodu.Caption = "Posta Kodu";
            this.colPostaKodu.FieldName = "PostaKodu";
            this.colPostaKodu.Name = "colPostaKodu";
            this.colPostaKodu.OptionsColumn.AllowEdit = false;
            this.colPostaKodu.StatusBarAciklama = null;
            this.colPostaKodu.StatusBarKisaYol = null;
            this.colPostaKodu.StatusBarKisaYolAciklama = null;
            this.colPostaKodu.Visible = true;
            this.colPostaKodu.VisibleIndex = 15;
            this.colPostaKodu.Width = 100;
            // 
            // colIlceAdi
            // 
            this.colIlceAdi.Caption = "İlçe";
            this.colIlceAdi.FieldName = "IlceAdi";
            this.colIlceAdi.Name = "colIlceAdi";
            this.colIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIlceAdi.StatusBarAciklama = null;
            this.colIlceAdi.StatusBarKisaYol = null;
            this.colIlceAdi.StatusBarKisaYolAciklama = null;
            this.colIlceAdi.Visible = true;
            this.colIlceAdi.VisibleIndex = 12;
            this.colIlceAdi.Width = 120;
            // 
            // colIlAdi
            // 
            this.colIlAdi.Caption = "İl";
            this.colIlAdi.FieldName = "IlAdi";
            this.colIlAdi.Name = "colIlAdi";
            this.colIlAdi.OptionsColumn.AllowEdit = false;
            this.colIlAdi.StatusBarAciklama = null;
            this.colIlAdi.StatusBarKisaYol = null;
            this.colIlAdi.StatusBarKisaYolAciklama = null;
            this.colIlAdi.Visible = true;
            this.colIlAdi.VisibleIndex = 13;
            this.colIlAdi.Width = 120;
            // 
            // colUlkeAdi
            // 
            this.colUlkeAdi.Caption = "Ülke";
            this.colUlkeAdi.FieldName = "UlkeAdi";
            this.colUlkeAdi.Name = "colUlkeAdi";
            this.colUlkeAdi.OptionsColumn.AllowEdit = false;
            this.colUlkeAdi.StatusBarAciklama = null;
            this.colUlkeAdi.StatusBarKisaYol = null;
            this.colUlkeAdi.StatusBarKisaYolAciklama = null;
            this.colUlkeAdi.Visible = true;
            this.colUlkeAdi.VisibleIndex = 14;
            this.colUlkeAdi.Width = 120;
            // 
            // colCariTipi
            // 
            this.colCariTipi.Caption = "Cari Tipi";
            this.colCariTipi.FieldName = "CariTipi";
            this.colCariTipi.Name = "colCariTipi";
            this.colCariTipi.OptionsColumn.AllowEdit = false;
            this.colCariTipi.StatusBarAciklama = null;
            this.colCariTipi.StatusBarKisaYol = null;
            this.colCariTipi.StatusBarKisaYolAciklama = null;
            this.colCariTipi.Visible = true;
            this.colCariTipi.VisibleIndex = 16;
            this.colCariTipi.Width = 100;
            // 
            // colOzelKod1Adi
            // 
            this.colOzelKod1Adi.Caption = "Özel Kod-1";
            this.colOzelKod1Adi.FieldName = "OzelKod1Adi";
            this.colOzelKod1Adi.Name = "colOzelKod1Adi";
            this.colOzelKod1Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod1Adi.StatusBarAciklama = null;
            this.colOzelKod1Adi.StatusBarKisaYol = null;
            this.colOzelKod1Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod1Adi.Visible = true;
            this.colOzelKod1Adi.VisibleIndex = 17;
            this.colOzelKod1Adi.Width = 110;
            // 
            // colOzelKod2Adi
            // 
            this.colOzelKod2Adi.Caption = "Özel Kod-2";
            this.colOzelKod2Adi.FieldName = "OzelKod2Adi";
            this.colOzelKod2Adi.Name = "colOzelKod2Adi";
            this.colOzelKod2Adi.OptionsColumn.AllowEdit = false;
            this.colOzelKod2Adi.StatusBarAciklama = null;
            this.colOzelKod2Adi.StatusBarKisaYol = null;
            this.colOzelKod2Adi.StatusBarKisaYolAciklama = null;
            this.colOzelKod2Adi.Visible = true;
            this.colOzelKod2Adi.VisibleIndex = 18;
            this.colOzelKod2Adi.Width = 110;
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
            this.colAciklama.VisibleIndex = 19;
            this.colAciklama.Width = 250;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 580);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1098, 24);
            this.longNavigator.TabIndex = 4;
            // 
            // CariListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 628);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "CariListForm";
            this.Text = "Cari Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UserControls.Grids.MyGridControl grid;
        private UserControls.Grids.MyGridView tablo;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colKod;
        private UserControls.Grids.MyGridColumn colCariAdi;
        private UserControls.Grids.MyGridColumn colTcKimlikNo;
        private UserControls.Grids.MyGridColumn colVergiDairesi;
        private UserControls.Grids.MyGridColumn colVergiNo;
        private UserControls.Grids.MyGridColumn colTelefon1;
        private UserControls.Grids.MyGridColumn colFax;
        private UserControls.Grids.MyGridColumn colEmail;
        private UserControls.Grids.MyGridColumn colWebsite;
        private UserControls.Grids.MyGridColumn colAdres;
        private UserControls.Grids.MyGridColumn colIlceAdi;
        private UserControls.Grids.MyGridColumn colIlAdi;
        private UserControls.Grids.MyGridColumn colUlkeAdi;
        private UserControls.Grids.MyGridColumn colPostaKodu;
        private UserControls.Grids.MyGridColumn colCariTipi;
        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridColumn colTelefon2;
        private UserControls.Grids.MyGridColumn colTelefon3;
        private UserControls.Grids.MyGridColumn colOzelKod1Adi;
        private UserControls.Grids.MyGridColumn colOzelKod2Adi;
        private UserControls.Grids.MyGridColumn colAciklama;
    }
}