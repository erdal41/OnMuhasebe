
namespace Muhasebe.UI.Win.Forms.GeneralForms
{
    partial class Baslatiliyor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baslatiliyor));
            this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.labelCopyright = new DevExpress.XtraEditors.LabelControl();
            this.labelStatus = new DevExpress.XtraEditors.LabelControl();
            this.peImage = new DevExpress.XtraEditors.PictureEdit();
            this.lblVersion = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarControl
            // 
            this.progressBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarControl.EditValue = 0;
            this.progressBarControl.Location = new System.Drawing.Point(11, 261);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Size = new System.Drawing.Size(426, 20);
            this.progressBarControl.TabIndex = 5;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelCopyright.Appearance.Options.UseForeColor = true;
            this.labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelCopyright.Location = new System.Drawing.Point(11, 287);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(100, 13);
            this.labelCopyright.TabIndex = 6;
            this.labelCopyright.Text = "Ön Muhasebe - 2021";
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(11, 244);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(150, 13);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Başlatılıyor. Lütfen Bekleyiniz...";
            // 
            // peImage
            // 
            this.peImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.peImage.EditValue = ((object)(resources.GetObject("peImage.EditValue")));
            this.peImage.Location = new System.Drawing.Point(1, 1);
            this.peImage.Name = "peImage";
            this.peImage.Properties.AllowFocused = false;
            this.peImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peImage.Properties.Appearance.Options.UseBackColor = true;
            this.peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peImage.Properties.ShowMenu = false;
            this.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peImage.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.peImage.Size = new System.Drawing.Size(448, 227);
            this.peImage.TabIndex = 9;
            // 
            // lblVersion
            // 
            this.lblVersion.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblVersion.Appearance.Options.UseForeColor = true;
            this.lblVersion.Appearance.Options.UseTextOptions = true;
            this.lblVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVersion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblVersion.Location = new System.Drawing.Point(205, 287);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(232, 13);
            this.lblVersion.TabIndex = 10;
            this.lblVersion.Text = "Version";
            // 
            // Baslatiliyor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 330);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.peImage);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.progressBarControl);
            this.Name = "Baslatiliyor";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Baslatiliyor";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
        private DevExpress.XtraEditors.LabelControl labelCopyright;
        private DevExpress.XtraEditors.LabelControl labelStatus;
        private DevExpress.XtraEditors.PictureEdit peImage;
        private DevExpress.XtraEditors.LabelControl lblVersion;
    }
}
