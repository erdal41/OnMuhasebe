
namespace Muhasebe.UI.Win.Forms.StokForms
{
    partial class StokEditForm
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
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new Muhasebe.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.txtBirim = new Muhasebe.UI.Win.UserControls.Controls.MyButtonEdit();
            this.txtAciklama = new Muhasebe.UI.Win.UserControls.Controls.MyMemoEdit();
            this.txtSatisKdvOrani = new Muhasebe.UI.Win.UserControls.Controls.MySpinEdit();
            this.txtSatisFiyati = new Muhasebe.UI.Win.UserControls.Controls.MyCalcEdit();
            this.txtAlisKdvOrani = new Muhasebe.UI.Win.UserControls.Controls.MySpinEdit();
            this.txtAlisFiyati = new Muhasebe.UI.Win.UserControls.Controls.MyCalcEdit();
            this.tglDurum = new Muhasebe.UI.Win.UserControls.Controls.MyToggleSwitch();
            this.txtStokAdi = new Muhasebe.UI.Win.UserControls.Controls.MyTextEdit();
            this.txtKod = new Muhasebe.UI.Win.UserControls.Controls.MyKodTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisKdvOrani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisKdvOrani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(440, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.txtBirim);
            this.myDataLayoutControl.Controls.Add(this.txtAciklama);
            this.myDataLayoutControl.Controls.Add(this.txtSatisKdvOrani);
            this.myDataLayoutControl.Controls.Add(this.txtSatisFiyati);
            this.myDataLayoutControl.Controls.Add(this.txtAlisKdvOrani);
            this.myDataLayoutControl.Controls.Add(this.txtAlisFiyati);
            this.myDataLayoutControl.Controls.Add(this.tglDurum);
            this.myDataLayoutControl.Controls.Add(this.txtStokAdi);
            this.myDataLayoutControl.Controls.Add(this.txtKod);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(440, 206);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // txtBirim
            // 
            this.txtBirim.EnterMoveNextControl = true;
            this.txtBirim.Id = null;
            this.txtBirim.Location = new System.Drawing.Point(67, 60);
            this.txtBirim.MenuManager = this.ribbonControl;
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtBirim.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtBirim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtBirim.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtBirim.Size = new System.Drawing.Size(141, 20);
            this.txtBirim.StatusBarAciklama = "Birim seçiniz.";
            this.txtBirim.StatusBarKisaYol = "F4 :";
            this.txtBirim.StatusBarKisaYolAciklama = "Seçim yap";
            this.txtBirim.StyleController = this.myDataLayoutControl;
            this.txtBirim.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.EnterMoveNextControl = true;
            this.txtAciklama.Location = new System.Drawing.Point(67, 132);
            this.txtAciklama.MenuManager = this.ribbonControl;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtAciklama.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAciklama.Properties.MaxLength = 500;
            this.txtAciklama.Size = new System.Drawing.Size(361, 62);
            this.txtAciklama.StatusBarAciklama = "Açıklama giriniz.";
            this.txtAciklama.StyleController = this.myDataLayoutControl;
            this.txtAciklama.TabIndex = 7;
            // 
            // txtSatisKdvOrani
            // 
            this.txtSatisKdvOrani.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSatisKdvOrani.EnterMoveNextControl = true;
            this.txtSatisKdvOrani.Location = new System.Drawing.Point(362, 108);
            this.txtSatisKdvOrani.MenuManager = this.ribbonControl;
            this.txtSatisKdvOrani.Name = "txtSatisKdvOrani";
            this.txtSatisKdvOrani.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtSatisKdvOrani.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtSatisKdvOrani.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSatisKdvOrani.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSatisKdvOrani.Properties.Mask.EditMask = "d";
            this.txtSatisKdvOrani.Size = new System.Drawing.Size(66, 20);
            this.txtSatisKdvOrani.StatusBarAciklama = "Satış K.D.V. oranı giriniz.";
            this.txtSatisKdvOrani.StyleController = this.myDataLayoutControl;
            this.txtSatisKdvOrani.TabIndex = 6;
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.EnterMoveNextControl = true;
            this.txtSatisFiyati.Location = new System.Drawing.Point(67, 108);
            this.txtSatisFiyati.MenuManager = this.ribbonControl;
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtSatisFiyati.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtSatisFiyati.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSatisFiyati.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSatisFiyati.Properties.DisplayFormat.FormatString = "n2";
            this.txtSatisFiyati.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSatisFiyati.Properties.Mask.EditMask = "n2";
            this.txtSatisFiyati.Size = new System.Drawing.Size(141, 20);
            this.txtSatisFiyati.StatusBarAciklama = "Satış fiyatı giriniz.";
            this.txtSatisFiyati.StatusBarKisaYol = "F4 :";
            this.txtSatisFiyati.StatusBarKisaYolAciklama = "Hesap Makinesi";
            this.txtSatisFiyati.StyleController = this.myDataLayoutControl;
            this.txtSatisFiyati.TabIndex = 5;
            // 
            // txtAlisKdvOrani
            // 
            this.txtAlisKdvOrani.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtAlisKdvOrani.EnterMoveNextControl = true;
            this.txtAlisKdvOrani.Location = new System.Drawing.Point(362, 84);
            this.txtAlisKdvOrani.MenuManager = this.ribbonControl;
            this.txtAlisKdvOrani.Name = "txtAlisKdvOrani";
            this.txtAlisKdvOrani.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtAlisKdvOrani.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtAlisKdvOrani.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAlisKdvOrani.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAlisKdvOrani.Properties.Mask.EditMask = "d";
            this.txtAlisKdvOrani.Size = new System.Drawing.Size(66, 20);
            this.txtAlisKdvOrani.StatusBarAciklama = "Alış K.D.V. oranı giriniz.";
            this.txtAlisKdvOrani.StyleController = this.myDataLayoutControl;
            this.txtAlisKdvOrani.TabIndex = 4;
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.EnterMoveNextControl = true;
            this.txtAlisFiyati.Location = new System.Drawing.Point(67, 84);
            this.txtAlisFiyati.MenuManager = this.ribbonControl;
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtAlisFiyati.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtAlisFiyati.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAlisFiyati.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAlisFiyati.Properties.DisplayFormat.FormatString = "n2";
            this.txtAlisFiyati.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAlisFiyati.Properties.Mask.EditMask = "n2";
            this.txtAlisFiyati.Size = new System.Drawing.Size(141, 20);
            this.txtAlisFiyati.StatusBarAciklama = "Alış fiyatı giriniz.";
            this.txtAlisFiyati.StatusBarKisaYol = "F4 :";
            this.txtAlisFiyati.StatusBarKisaYolAciklama = "Hesap Makinesi";
            this.txtAlisFiyati.StyleController = this.myDataLayoutControl;
            this.txtAlisFiyati.TabIndex = 3;
            // 
            // tglDurum
            // 
            this.tglDurum.EnterMoveNextControl = true;
            this.tglDurum.Location = new System.Drawing.Point(355, 12);
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
            this.tglDurum.TabIndex = 8;
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.EnterMoveNextControl = true;
            this.txtStokAdi.Location = new System.Drawing.Point(67, 36);
            this.txtStokAdi.MenuManager = this.ribbonControl;
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtStokAdi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtStokAdi.Properties.MaxLength = 50;
            this.txtStokAdi.Size = new System.Drawing.Size(361, 20);
            this.txtStokAdi.StatusBarAciklama = "Stok adı giriniz.";
            this.txtStokAdi.StyleController = this.myDataLayoutControl;
            this.txtStokAdi.TabIndex = 1;
            // 
            // txtKod
            // 
            this.txtKod.EnterMoveNextControl = true;
            this.txtKod.Location = new System.Drawing.Point(67, 12);
            this.txtKod.MenuManager = this.ribbonControl;
            this.txtKod.Name = "txtKod";
            this.txtKod.Properties.Appearance.BackColor = System.Drawing.Color.PeachPuff;
            this.txtKod.Properties.Appearance.Options.UseBackColor = true;
            this.txtKod.Properties.Appearance.Options.UseTextOptions = true;
            this.txtKod.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtKod.Properties.AppearanceFocused.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtKod.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtKod.Properties.MaxLength = 20;
            this.txtKod.Size = new System.Drawing.Size(161, 20);
            this.txtKod.StatusBarAciklama = "Stok kodu giriniz.";
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
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 20D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 100D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 100D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 24D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition6.Height = 100D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5,
            rowDefinition6});
            this.Root.Size = new System.Drawing.Size(440, 206);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtKod;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem1.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem1.Text = "Kod";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtStokAdi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 4;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(420, 24);
            this.layoutControlItem2.Text = "Stok Adı";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtAlisFiyati;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem5.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem5.Text = "Alış Fiyatı";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtAlisKdvOrani;
            this.layoutControlItem6.Location = new System.Drawing.Point(220, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem6.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem6.Text = "Alış KDV Oranı";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(125, 20);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem7.Control = this.txtSatisFiyati;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem7.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem7.Text = "Satış Fiyatı";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem8.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem8.Control = this.txtSatisKdvOrani;
            this.layoutControlItem8.Location = new System.Drawing.Point(220, 96);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem8.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem8.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem8.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem8.Text = "Satış KDV Oranı";
            this.layoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(125, 20);
            this.layoutControlItem8.TextToControlDistance = 5;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem9.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem9.Control = this.txtAciklama;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.OptionsTableLayoutItem.ColumnSpan = 4;
            this.layoutControlItem9.OptionsTableLayoutItem.RowIndex = 5;
            this.layoutControlItem9.Size = new System.Drawing.Size(420, 66);
            this.layoutControlItem9.Text = "Açıklama";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.tglDurum;
            this.layoutControlItem3.Location = new System.Drawing.Point(320, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 3;
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(25, 2, 2, 2);
            this.layoutControlItem3.Size = new System.Drawing.Size(100, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtBirim;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem4.Size = new System.Drawing.Size(200, 24);
            this.layoutControlItem4.Text = "Birim";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 13);
            // 
            // StokEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 339);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.MinimumSize = new System.Drawing.Size(442, 340);
            this.Name = "StokEditForm";
            this.Text = "Stok Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisKdvOrani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisKdvOrani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UserControls.Controls.MyMemoEdit txtAciklama;
        private UserControls.Controls.MySpinEdit txtSatisKdvOrani;
        private UserControls.Controls.MyCalcEdit txtSatisFiyati;
        private UserControls.Controls.MySpinEdit txtAlisKdvOrani;
        private UserControls.Controls.MyCalcEdit txtAlisFiyati;
        private UserControls.Controls.MyToggleSwitch tglDurum;
        private UserControls.Controls.MyTextEdit txtStokAdi;
        private UserControls.Controls.MyKodTextEdit txtKod;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private UserControls.Controls.MyButtonEdit txtBirim;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}