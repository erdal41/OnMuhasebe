namespace Muhasebe.UI.Win.Forms.BirimForms
{
    partial class BirimEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new Muhasebe.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.txtBirimKisaAdi = new Muhasebe.UI.Win.UserControls.Controls.MyTextEdit();
            this.tglDurum = new Muhasebe.UI.Win.UserControls.Controls.MyToggleSwitch();
            this.txtAciklama = new Muhasebe.UI.Win.UserControls.Controls.MyMemoEdit();
            this.txtBirimAdi = new Muhasebe.UI.Win.UserControls.Controls.MyTextEdit();
            this.txtKod = new Muhasebe.UI.Win.UserControls.Controls.MyKodTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirimKisaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirimAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(404, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.txtBirimKisaAdi);
            this.myDataLayoutControl.Controls.Add(this.tglDurum);
            this.myDataLayoutControl.Controls.Add(this.txtAciklama);
            this.myDataLayoutControl.Controls.Add(this.txtBirimAdi);
            this.myDataLayoutControl.Controls.Add(this.txtKod);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(404, 141);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // txtBirimKisaAdi
            // 
            this.txtBirimKisaAdi.EnterMoveNextControl = true;
            this.txtBirimKisaAdi.Location = new System.Drawing.Point(297, 36);
            this.txtBirimKisaAdi.MenuManager = this.ribbonControl;
            this.txtBirimKisaAdi.Name = "txtBirimKisaAdi";
            this.txtBirimKisaAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtBirimKisaAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBirimKisaAdi.Properties.MaxLength = 50;
            this.txtBirimKisaAdi.Size = new System.Drawing.Size(95, 20);
            this.txtBirimKisaAdi.StatusBarAciklama = "Birim için kullanılacak kısa adı giriniz.";
            this.txtBirimKisaAdi.StyleController = this.myDataLayoutControl;
            this.txtBirimKisaAdi.TabIndex = 2;
            // 
            // tglDurum
            // 
            this.tglDurum.EnterMoveNextControl = true;
            this.tglDurum.Location = new System.Drawing.Point(297, 12);
            this.tglDurum.MenuManager = this.ribbonControl;
            this.tglDurum.Name = "tglDurum";
            this.tglDurum.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.tglDurum.Properties.Appearance.Options.UseForeColor = true;
            this.tglDurum.Properties.AutoHeight = false;
            this.tglDurum.Properties.AutoWidth = true;
            this.tglDurum.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tglDurum.Properties.OffText = "Pasif";
            this.tglDurum.Properties.OnText = "Aktif";
            this.tglDurum.Size = new System.Drawing.Size(77, 20);
            this.tglDurum.StatusBarAciklama = "Kartın kullanım durumunu seçiniz.";
            this.tglDurum.StyleController = this.myDataLayoutControl;
            this.tglDurum.TabIndex = 4;
            // 
            // txtAciklama
            // 
            this.txtAciklama.EnterMoveNextControl = true;
            this.txtAciklama.Location = new System.Drawing.Point(72, 60);
            this.txtAciklama.MenuManager = this.ribbonControl;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtAciklama.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAciklama.Properties.MaxLength = 500;
            this.txtAciklama.Size = new System.Drawing.Size(320, 69);
            this.txtAciklama.StatusBarAciklama = "Açıklama giriniz.";
            this.txtAciklama.StyleController = this.myDataLayoutControl;
            this.txtAciklama.TabIndex = 3;
            // 
            // txtBirimAdi
            // 
            this.txtBirimAdi.EnterMoveNextControl = true;
            this.txtBirimAdi.Location = new System.Drawing.Point(72, 36);
            this.txtBirimAdi.MenuManager = this.ribbonControl;
            this.txtBirimAdi.Name = "txtBirimAdi";
            this.txtBirimAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtBirimAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBirimAdi.Properties.MaxLength = 50;
            this.txtBirimAdi.Size = new System.Drawing.Size(136, 20);
            this.txtBirimAdi.StatusBarAciklama = "Birim adı giriniz.";
            this.txtBirimAdi.StyleController = this.myDataLayoutControl;
            this.txtBirimAdi.TabIndex = 1;
            // 
            // txtKod
            // 
            this.txtKod.EnterMoveNextControl = true;
            this.txtKod.Location = new System.Drawing.Point(72, 12);
            this.txtKod.MenuManager = this.ribbonControl;
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtKod.Properties.Appearance.Options.UseBackColor = true;
            this.txtKod.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKod.Properties.MaxLength = 20;
            this.txtKod.Size = new System.Drawing.Size(136, 20);
            this.txtKod.StatusBarAciklama = "Kod giriniz.";
            this.txtKod.StyleController = this.myDataLayoutControl;
            this.txtKod.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 20D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 100D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 99D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 100D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
            this.Root.Size = new System.Drawing.Size(404, 141);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtKod;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem1.Text = "Kod";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(50, 20);
            this.layoutControlItem1.TextToControlDistance = 10;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtBirimAdi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem2.Text = "Birim Adı";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(50, 20);
            this.layoutControlItem2.TextToControlDistance = 10;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtAciklama;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 4;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(384, 73);
            this.layoutControlItem3.Text = "Açıklama";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(50, 20);
            this.layoutControlItem3.TextToControlDistance = 10;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.tglDurum;
            this.layoutControlItem4.Location = new System.Drawing.Point(285, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(99, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtBirimKisaAdi;
            this.layoutControlItem5.Location = new System.Drawing.Point(220, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem5.Size = new System.Drawing.Size(164, 24);
            this.layoutControlItem5.Text = "Birim Kısa Adı";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(62, 13);
            // 
            // BirimEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 274);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "BirimEditForm";
            this.Text = "Ülke Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBirimKisaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirimAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UserControls.Controls.MyKodTextEdit txtKod;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private UserControls.Controls.MyTextEdit txtBirimAdi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private UserControls.Controls.MyMemoEdit txtAciklama;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private UserControls.Controls.MyToggleSwitch tglDurum;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private UserControls.Controls.MyTextEdit txtBirimKisaAdi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}