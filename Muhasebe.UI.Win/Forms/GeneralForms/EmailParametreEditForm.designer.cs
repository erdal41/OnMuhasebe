
namespace Muhasebe.UI.Win.Forms.GeneralForms
{
    partial class EmailParametreEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition7 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition8 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition9 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition13 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition14 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition15 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition16 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition17 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition18 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new Muhasebe.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtKod = new Muhasebe.UI.Win.UserControls.Controls.MyKodTextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtEmail = new Muhasebe.UI.Win.UserControls.Controls.MyEmailTextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSifre = new Muhasebe.UI.Win.UserControls.Controls.MyTextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtPortNo = new Muhasebe.UI.Win.UserControls.Controls.MySpinEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtHost = new Muhasebe.UI.Win.UserControls.Controls.MyTextEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSSLKullan = new Muhasebe.UI.Win.UserControls.Controls.MyComboboxEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSSLKullan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(303, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.txtSSLKullan);
            this.myDataLayoutControl.Controls.Add(this.txtHost);
            this.myDataLayoutControl.Controls.Add(this.txtPortNo);
            this.myDataLayoutControl.Controls.Add(this.txtSifre);
            this.myDataLayoutControl.Controls.Add(this.txtEmail);
            this.myDataLayoutControl.Controls.Add(this.txtKod);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(303, 165);
            this.myDataLayoutControl.TabIndex = 0;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
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
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition7.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition7.Width = 130D;
            columnDefinition8.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition8.Width = 60D;
            columnDefinition9.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition9.Width = 90D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition7,
            columnDefinition8,
            columnDefinition9});
            rowDefinition13.Height = 24D;
            rowDefinition13.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition14.Height = 24D;
            rowDefinition14.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition15.Height = 24D;
            rowDefinition15.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition16.Height = 24D;
            rowDefinition16.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition17.Height = 24D;
            rowDefinition17.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition18.Height = 24D;
            rowDefinition18.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition13,
            rowDefinition14,
            rowDefinition15,
            rowDefinition16,
            rowDefinition17,
            rowDefinition18});
            this.Root.Size = new System.Drawing.Size(303, 165);
            this.Root.TextVisible = false;
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
            this.txtKod.Size = new System.Drawing.Size(126, 20);
            this.txtKod.StatusBarAciklama = "Kod giriniz.";
            this.txtKod.StyleController = this.myDataLayoutControl;
            this.txtKod.TabIndex = 0;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtKod;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem1.Size = new System.Drawing.Size(190, 24);
            this.layoutControlItem1.Text = "Kod";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 13);
            // 
            // txtEmail
            // 
            this.txtEmail.EnterMoveNextControl = true;
            this.txtEmail.Location = new System.Drawing.Point(72, 36);
            this.txtEmail.MenuManager = this.ribbonControl;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtEmail.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEmail.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.txtEmail.Properties.Mask.EditMask = "((([0-9a-zA-Z_%-])+[.])+|([0-9a-zA-Z_%-])+)+@((([0-9a-zA-Z_-])+[.])+|([0-9a-zA-Z_" +
    "-])+)+";
            this.txtEmail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmail.Properties.MaxLength = 50;
            this.txtEmail.Size = new System.Drawing.Size(219, 20);
            this.txtEmail.StatusBarAciklama = "E-mail adresi giriniz.";
            this.txtEmail.StyleController = this.myDataLayoutControl;
            this.txtEmail.TabIndex = 1;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.txtEmail;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(283, 24);
            this.layoutControlItem2.Text = "E-Mail";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 13);
            // 
            // txtSifre
            // 
            this.txtSifre.EnterMoveNextControl = true;
            this.txtSifre.Location = new System.Drawing.Point(72, 60);
            this.txtSifre.MenuManager = this.ribbonControl;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSifre.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSifre.Properties.MaxLength = 50;
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(219, 20);
            this.txtSifre.StatusBarAciklama = "E-mail şifresini giriniz.";
            this.txtSifre.StyleController = this.myDataLayoutControl;
            this.txtSifre.TabIndex = 2;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtSifre;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(283, 24);
            this.layoutControlItem3.Text = "Şifre";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 13);
            // 
            // txtPortNo
            // 
            this.txtPortNo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPortNo.EnterMoveNextControl = true;
            this.txtPortNo.Location = new System.Drawing.Point(72, 84);
            this.txtPortNo.MenuManager = this.ribbonControl;
            this.txtPortNo.Name = "txtPortNo";
            this.txtPortNo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtPortNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtPortNo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPortNo.Properties.Mask.EditMask = "d";
            this.txtPortNo.Size = new System.Drawing.Size(66, 20);
            this.txtPortNo.StatusBarAciklama = "Port no giriniz.";
            this.txtPortNo.StyleController = this.myDataLayoutControl;
            this.txtPortNo.TabIndex = 3;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtPortNo;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem4.Size = new System.Drawing.Size(130, 24);
            this.layoutControlItem4.Text = "Port No";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 13);
            // 
            // txtHost
            // 
            this.txtHost.EnterMoveNextControl = true;
            this.txtHost.Location = new System.Drawing.Point(72, 108);
            this.txtHost.MenuManager = this.ribbonControl;
            this.txtHost.Name = "txtHost";
            this.txtHost.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtHost.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtHost.Properties.MaxLength = 50;
            this.txtHost.Size = new System.Drawing.Size(219, 20);
            this.txtHost.StatusBarAciklama = "Host adını giriniz.";
            this.txtHost.StyleController = this.myDataLayoutControl;
            this.txtHost.TabIndex = 4;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.txtHost;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 4;
            this.layoutControlItem5.Size = new System.Drawing.Size(283, 24);
            this.layoutControlItem5.Text = "Host";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 13);
            // 
            // txtSSLKullan
            // 
            this.txtSSLKullan.EnterMoveNextControl = true;
            this.txtSSLKullan.Location = new System.Drawing.Point(72, 132);
            this.txtSSLKullan.MenuManager = this.ribbonControl;
            this.txtSSLKullan.Name = "txtSSLKullan";
            this.txtSSLKullan.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSSLKullan.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSSLKullan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSSLKullan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtSSLKullan.Size = new System.Drawing.Size(66, 20);
            this.txtSSLKullan.StatusBarAciklama = "SLL kullanım durumunu seçiniz.";
            this.txtSSLKullan.StatusBarKisaYol = "F4 :";
            this.txtSSLKullan.StatusBarKisaYolAciklama = "Seçim Yap";
            this.txtSSLKullan.StyleController = this.myDataLayoutControl;
            this.txtSSLKullan.TabIndex = 5;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.txtSSLKullan;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 5;
            this.layoutControlItem6.Size = new System.Drawing.Size(130, 25);
            this.layoutControlItem6.Text = "SSL Kullan";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 13);
            // 
            // EmailParametreEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 298);
            this.Controls.Add(this.myDataLayoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.Name = "EmailParametreEditForm";
            this.Text = "E-Mail Parametreleri";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSSLKullan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UserControls.Controls.MyComboboxEdit txtSSLKullan;
        private UserControls.Controls.MyTextEdit txtHost;
        private UserControls.Controls.MySpinEdit txtPortNo;
        private UserControls.Controls.MyTextEdit txtSifre;
        private UserControls.Controls.MyEmailTextEdit txtEmail;
        private UserControls.Controls.MyKodTextEdit txtKod;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}