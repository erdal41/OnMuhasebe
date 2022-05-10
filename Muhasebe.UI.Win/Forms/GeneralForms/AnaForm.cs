using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraTabbedMdi;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Muhasebe.Common.Enums;
using Muhasebe.Common.Messages;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BirimForms;
using Muhasebe.UI.Win.Forms.CariForms;
using Muhasebe.UI.Win.Forms.FaturaForms;
using Muhasebe.UI.Win.Forms.KullaniciForms;
using Muhasebe.UI.Win.Forms.StokForms;
using Muhasebe.UI.Win.Show;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace Muhasebe.UI.Win.Forms.GeneralForms
{
    public partial class AnaForm : RibbonForm
    {
        #region Variables

        public static long KullaniciId;
        public static string KullaniciAdi;
        public static KullaniciParametre KullaniciParametreleri = new KullaniciParametre();

        #endregion

        public AnaForm()
        {
            InitializeComponent();
            EventsLoad();

            imgArkaPlanResmi.EditValue = KullaniciParametreleri.ArkaPlanResmi;
        }

        #region Functions

        private void EventsLoad()
        {
            Load += AnaForm_Load;
            FormClosing += AnaForm_FormClosing;
            KeyDown += Control_KeyDown;

            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    //SkinRibbonGalleryBarItem BarButtonItem'dan implement yani referans aldığı için üste yazılmalı
                    case SkinRibbonGalleryBarItem btn:
                        btn.GalleryItemClick += Gallery_GalleryItemClick;
                        break;
                    case SkinPaletteRibbonGalleryBarItem btn:
                        btn.GalleryItemClick += Gallery_GalleryItemClick;
                        break;
                    case BarButtonItem btn:
                        btn.ItemClick += Btnlar_ItemClick;
                        break;

                }
            }

            foreach (Control control in Controls)
            {
                //Form üzerindeki herhangi bir controle(button, text vb.) focuslanılsa bile aşağıdaki event çalışacak. 
                control.KeyDown += Control_KeyDown;
            }

            xtraTabbedMdiManager.PageAdded += XtraTabbedMdiManager_PageAdded;
            xtraTabbedMdiManager.PageRemoved += XtraTabbedMdiManager_PageRemoved;
        }

        private void YedekAl()
        {
            Backup fullDBBackup = new Backup
            {
                Action = BackupActionType.Database,
                Database = "pane1228_MuhasebeDB"
            };

            fullDBBackup.Devices.AddDevice(@"C:\BACKUP\" + "Database_BackupLog_" + DateTime.Now.ToString("ddmmyyyy") + DateTime.Now.ToString("HHmmss") + ".bak", DeviceType.File);
            fullDBBackup.BackupSetName = "Yedek" + DateTime.Now.ToString("dd/mm/yyyy") + "-" + DateTime.Now.ToString("HH/mm/ss");
            fullDBBackup.BackupSetDescription = "Muhasebe Veritabanı Yedeği";
            fullDBBackup.ExpirationDate = DateTime.Today.AddDays(1000);
            fullDBBackup.Initialize = false;
            fullDBBackup.PercentComplete += CompletionStatusInPercent;
            fullDBBackup.Complete += Backup_Completed;
            Server server = new Server(ConfigurationManager.AppSettings["Server"]);
            fullDBBackup.SqlBackup(server);
        }

        #endregion

        #region  Events

        private void AnaForm_Load(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            barKullaniciAdi.Caption = $"{KullaniciAdi}";

            Cursor.Current = Cursors.Default;
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Messages.HayirSeciliEvetHayir("Programdan çıkmak istiyor musunuz?", "Çıkış Onayı") == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Gallery_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            var gallery = sender as InRibbonGallery;
            var key = "";

            if (gallery.OwnerItem.GetType() == typeof(SkinRibbonGalleryBarItem))
            {
                key = "Skin";
            }
            else if (gallery.OwnerItem.GetType() == typeof(SkinPaletteRibbonGalleryBarItem))
            {
                key = "Palette";
            }

            Functions.GeneralFunctions.AppSettingWrite(key, e.Item.Caption);
        }

        private void Btnlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnBirimKartlari)
            {
                ShowListForms<BirimListForm>.ShowListForm(KartTuru.Birim, -1);
            }
            else if (e.Item == btnCariKartlari)
            {
                ShowListForms<CariListForm>.ShowListForm(KartTuru.Cari, -1 , null);
            }
            if (e.Item == btnCariHareketFisi)
            {
                ShowEditForms<CariHareketFisiEditForm>.ShowDialogEditForm(KartTuru.CariHareketFisi, -1);
            }
            else if (e.Item == btnStokKartlari)
            {
                ShowListForms<StokListForm>.ShowListForm(KartTuru.Stok);
            }
            else if (e.Item == btnFaturaKartlari)
            {
                ShowListForms<FaturaListForm>.ShowListForm(KartTuru.Fatura);
            }
            else if (e.Item == btnKullaniciParametreleri)
            {
                var entity = ShowEditForms<KullaniciParametreEditForm>.ShowDialogEditForm<KullaniciParametre>(KartTuru.KullaniciParametre, KullaniciId);

                if (entity == null) return;

                KullaniciParametreleri = entity;
                imgArkaPlanResmi.EditValue = entity.ArkaPlanResmi;
            }
            else if (e.Item == btnMailParametreleri)
            {
                ShowEditForms<EmailParametreEditForm>.ShowDialogEditForm();
            }
            else if (e.Item == btnKullaniciKartlari)
            {
                ShowListForms<KullaniciListForm>.ShowListForm(KartTuru.Kullanici);
            }
            else if (e.Item == btnSifreDegistir)
            {
                ShowEditForms<SifreDegistirEditForm>.ShowDialogEditForm();
            }
            else if (e.Item == btnYedekleme)
            {
                YedekAl();
            }
            else if (e.Item == btnHesapMakinesi)
            {
                try
                {
                    Process.Start("calc.exe");
                }
                catch
                {
                    Messages.HataMesaji("Hesap makinesi bulunamadı.");
                }
            }
            else if (e.Item == btnNotDefteri)
            {
                try
                {
                    Process.Start("notepad.exe");
                }
                catch
                {
                    Messages.HataMesaji("Not defteri bulunamadı.");
                }
            }
            else if (e.Item == btnWord)
            {
                try
                {
                    Process.Start("winword.exe");
                }
                catch
                {
                    Messages.HataMesaji("Microsoft Word bulunamadı.");
                }
            }
            else if (e.Item == btnExcell)
            {
                try
                {
                    Process.Start("excel.exe");
                }
                catch
                {
                    Messages.HataMesaji("Microsoft Excell bulunamadı.");
                }
            }

            Cursor.Current = Cursors.Default;
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void XtraTabbedMdiManager_PageAdded(object sender, MdiTabPageEventArgs e)
        {
            imgArkaPlanResmi.SendToBack();
        }

        private void XtraTabbedMdiManager_PageRemoved(object sender, MdiTabPageEventArgs e)
        {
            if (((XtraTabbedMdiManager)sender).Pages.Count == 0)
            {
                imgArkaPlanResmi.BringToFront();
            }
        }

        private void CompletionStatusInPercent(object sender, PercentCompleteEventArgs args)
        {
            progressBarControl.Visible = true;
            progressBarControl.Properties.Step = args.Percent;
            progressBarControl.PerformStep();
            progressBarControl.Update();
        }

        private void Backup_Completed(object sender, ServerMessageEventArgs args)
        {
            switch (args.Error.Number)
            {
                case 3014:
                    Messages.BilgiMesaji("Yedekleme işlemi başarılı..!\n\n" + args.Error.Message);
                    progressBarControl.EditValue = 0;
                    progressBarControl.Visible = false;
                    break;
            }
        }

        #endregion
    }
}