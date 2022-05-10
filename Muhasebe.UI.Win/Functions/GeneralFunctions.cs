using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Muhasebe.Common.Enums;
using Muhasebe.Common.Messages;
using Muhasebe.Model.Entities.Base;
using Muhasebe.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Security;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Net.Mail;
using System.Net;
using Muhasebe.Bll.Functions;
using System.Configuration;
using Muhasebe.UI.Win.UserControls.Controls;
using DevExpress.XtraVerticalGrid;
using Muhasebe.Model.Entities;
using Muhasebe.Bll.General;
using Muhasebe.UI.Win.Properties;
using System.Data.Entity;
using DevExpress.XtraSplashScreen;
using Muhasebe.UI.Win.Forms.GeneralForms;

namespace Muhasebe.UI.Win.Functions
{
    public static class GeneralFunctions
    {
        public static long GetRowId(this GridView tablo)
        {
            if (tablo.FocusedRowHandle > -1) return (long)tablo.GetFocusedRowCellValue("Id");
            Messages.KartSecmemeUyariMesaji();
            return -1;
        }

        public static T GetRow<T>(this GridView tablo, bool mesajVer = true)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(tablo.FocusedRowHandle);

            if (mesajVer)
                Messages.KartSecmemeUyariMesaji();

            return default;
        }

        public static T GetRow<T>(this GridView tablo, int rowHandle)
        {
            if (tablo.FocusedRowHandle > -1) return (T)tablo.GetRow(rowHandle);

            return default;
        }

        private static VeriDegisimYeri VeriDegisimYeriGetir<T>(T oldEntity, T newEntity)
        {
            foreach (var prop in newEntity.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;

                var oldValue = prop.GetValue(oldEntity) ?? string.Empty;
                var newValue = prop.GetValue(newEntity) ?? string.Empty;

                //Resim eklerken alanları karşılatırıyoruz
                if (prop.PropertyType == typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                        oldValue = new byte[] { 0 };
                    if (string.IsNullOrEmpty(newValue.ToString()))
                        newValue = new byte[] { 0 };

                    if (((byte[])oldValue).Length != ((byte[])newValue).Length)
                        return VeriDegisimYeri.Alan;
                }

                else if (prop.PropertyType == typeof(SecureString))
                {
                    var oldString = ((SecureString)oldValue).ConvertToUnSecureString();
                    var newString = ((SecureString)newValue).ConvertToUnSecureString();

                    if (!oldString.Equals(newString))
                        return VeriDegisimYeri.Alan;
                }
                else if (!newValue.Equals(oldValue))
                    return VeriDegisimYeri.Alan;
            }
            return VeriDegisimYeri.VeriDegisimiYok;
        }

        public static void ButtonEnabledDurumu<T>(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGerial, BarButtonItem btnSil, T oldEntity, T newEntity)
        {
            var veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, newEntity);
            var buttonEnabledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan;

            btnKaydet.Enabled = buttonEnabledDurumu;
            btnGerial.Enabled = buttonEnabledDurumu;
            btnYeni.Enabled = !buttonEnabledDurumu;
            btnSil.Enabled = !buttonEnabledDurumu;
        }

        public static void ButtonEnabledDurumu<T>(BarButtonItem btnKaydet, BarButtonItem btnFarkliKaydet, BarButtonItem btnSil, IslemTuru ıslemTuru, T oldEntity, T newEntity)
        {
            var veriDegisimYeri = VeriDegisimYeriGetir(oldEntity, newEntity);
            var buttonEnabledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan;

            btnKaydet.Enabled = buttonEnabledDurumu;
            btnFarkliKaydet.Enabled = ıslemTuru != IslemTuru.EntityInsert;
            btnSil.Enabled = !buttonEnabledDurumu;
        }
        public static void ButtonEnabledDurumu<T>(BarButtonItem btnYeni, BarButtonItem btnKaydet, BarButtonItem btnGerial, BarButtonItem btnSil, T oldEntity, T newEntity, bool tableValueChanged)
        {
            var veriDegisimYeri = tableValueChanged ? VeriDegisimYeri.Tablo : VeriDegisimYeriGetir(oldEntity, newEntity);
            var buttonEnabledDurumu = veriDegisimYeri == VeriDegisimYeri.Alan || veriDegisimYeri == VeriDegisimYeri.Tablo;

            btnKaydet.Enabled = buttonEnabledDurumu;
            btnGerial.Enabled = buttonEnabledDurumu;
            btnYeni.Enabled = !buttonEnabledDurumu;
            btnSil.Enabled = !buttonEnabledDurumu;
        }

        public static long IdOlustur(this IslemTuru islemTuru, BaseEntity selectedEntity)
        {
            string SifirEkle(string deger)
            {
                if (deger.Length == 1)
                {
                    return "0" + deger;
                }
                return deger;
            }

            string UcBasamakYap(string deger)
            {
                switch (deger.Length)
                {
                    case 1:
                        return "00" + deger;
                    case 2:
                        return "0" + deger;
                }
                return deger;
            }

            string Id()
            {
                var yil = SifirEkle(DateTime.Now.Date.Year.ToString());
                var ay = SifirEkle(DateTime.Now.Date.Month.ToString());
                var gun = SifirEkle(DateTime.Now.Date.Day.ToString());
                var saat = SifirEkle(DateTime.Now.Date.Hour.ToString());
                var dakika = SifirEkle(DateTime.Now.Date.Minute.ToString());
                var saniye = SifirEkle(DateTime.Now.Date.Second.ToString());
                var milisaniye = UcBasamakYap(DateTime.Now.Date.Millisecond.ToString());
                var random = SifirEkle(new Random().Next(0, 99).ToString());

                return yil + ay + gun + saat + dakika + saniye + milisaniye + random;
            }

            return islemTuru == IslemTuru.EntityUpdate ? selectedEntity.Id : long.Parse(Id());
        }

        public static void ControlEnabledChange(this MyButtonEdit baseEdit, Control prmEdit)
        {
            switch (prmEdit)
            {
                case MyButtonEdit edit:
                    edit.Enabled = baseEdit.Id.HasValue && baseEdit.Id > 0;

                    break;
                case PropertyGridControl propertyGrid:
                    propertyGrid.Enabled = baseEdit.Id.HasValue && baseEdit.Id > 0;

                    if (!propertyGrid.Enabled)
                    {
                        propertyGrid.SelectedObject = null;
                    }
                    break;
            }
        }

        public static void RowFocus(this GridView tablo, string aranacakKolon, object aranacakDeger)
        {
            var rowHandle = 0;

            //Aranandegeri bulduğundan en son bulunan değere focuslanır. Ama for dongusunu ilk bulunan kayıtta durdurursak ilk bulunan degerde focuslanır
            for (int i = 0; i < tablo.RowCount; i++)
            {
                var bulunanDeger = tablo.GetRowCellValue(i, aranacakKolon);

                if (aranacakDeger.Equals(bulunanDeger))
                {
                    rowHandle = i;
                }
            }

            tablo.Focus();
            tablo.FocusedRowHandle = rowHandle;
        }

        public static void RowFocus(this GridView tablo, int rowHandle)
        {
            if (rowHandle <= 0) return;

            if (rowHandle == tablo.RowCount - 1)
            {
                tablo.FocusedRowHandle = rowHandle;
            }
            else
            {
                tablo.FocusedRowHandle = rowHandle - 1;
            }
        }

        public static void SagMenuGoster(this MouseEventArgs e, PopupMenu sagMenu)
        {
            if (e.Button != MouseButtons.Right) return;

            sagMenu.ShowPopup(Control.MousePosition);
        }

        public static List<string> YazicilariListele()
        {
            return PrinterSettings.InstalledPrinters.Cast<string>().ToList();
        }

        public static string DefaultYazici()
        {
            var settings = new PrinterSettings();
            return settings.PrinterName;
        }

        public static void ShowPopupMenu(this MouseEventArgs e, PopupMenu popupMenu)
        {
            if (e.Button != MouseButtons.Right) return;
            popupMenu.ShowPopup(Control.MousePosition);
        }

        public static byte[] ResimYukle()
        {
            var dialog = new OpenFileDialog()
            {
                Title = "Resim Seç",
                Filter = "Resim Dosyaları (*.bmp, *.gif *.jpg, *.png)|*.bmp; *.gif; *.jpg; *.png|Bmp Dosyaları|*.bmp|Gif Dosyaları|*gif|Jpg Dosyaları|*.jpg|Png Dosyaları|*.png",
                InitialDirectory = @"C:\",
            };

            byte[] Resim()
            {
                using (var stream = new MemoryStream())
                {
                    Image.FromFile(dialog.FileName).Save(stream, ImageFormat.Png);
                    return stream.ToArray();
                }
            }
            return dialog.ShowDialog() != DialogResult.OK ? null : Resim();
        }

        public static void RefreshDataSource(this GridView tablo)
        {
            var source = tablo.DataController.ListSource.Cast<IBaseHareketEntity>().ToList();
            if (!source.Any(x => x.Delete)) return;
            var rowHandle = tablo.FocusedRowHandle;

            tablo.CustomRowFilter += Tablo_CustomRowFilter;
            tablo.RefreshData();
            tablo.CustomRowFilter -= Tablo_CustomRowFilter;
            tablo.RowFocus(rowHandle);

            void Tablo_CustomRowFilter(object sender, RowFilterEventArgs e)
            {
                var entity = source[e.ListSourceRow];
                if (entity == null) return;

                if (!entity.Delete) return;
                e.Visible = false;
                e.Handled = true;
            }
        }

        public static BindingList<T> ToBindingList<T>(this IEnumerable<BaseHareketEntity> list)
        {
            return new BindingList<T>((IList<T>)list);
        }

        public static void AppSettingWrite(string key, string value)
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static void CreateConnectionString(string initialCatalog, string server, SecureString kullaniciAdi, SecureString sifre, YetkilendirmeTuru yetkilendirmeTuru)
        {
            SqlConnectionStringBuilder builder = null;

            switch (yetkilendirmeTuru)
            {
                case YetkilendirmeTuru.SqlServer:
                    builder = new SqlConnectionStringBuilder
                    {
                        DataSource = server,
                        UserID = kullaniciAdi.ConvertToUnSecureString(),
                        Password = sifre.ConvertToUnSecureString(),
                        InitialCatalog = initialCatalog,
                        MultipleActiveResultSets = true,
                    };
                    break;
                case YetkilendirmeTuru.Windows:
                    builder = new SqlConnectionStringBuilder
                    {
                        DataSource = server,
                        InitialCatalog = initialCatalog,
                        IntegratedSecurity = true,
                        MultipleActiveResultSets = true,
                    };
                    break;
            }

            var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.ConnectionStrings.ConnectionStrings["MuhasebeContext"].ConnectionString = builder?.ConnectionString;
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
            Settings.Default.Reset();
            Settings.Default.Save();
        }

        public static bool BaglantiKontrolu(string server, SecureString kullaniciAdi, SecureString sifre, YetkilendirmeTuru yetkilendirmeTuru, bool genelMesajVer = false)
        {
            CreateConnectionString("", server, kullaniciAdi, sifre, yetkilendirmeTuru);

            using (var con = new SqlConnection(Bll.Functions.GeneralFunctions.GetConnectionString()))
            {
                try
                {
                    if (con.ConnectionString == "") return false;

                    con.Open();
                    return true;
                }
                catch (SqlException ex)
                {
                    if (genelMesajVer)
                    {
                        Messages.HataMesaji("Server bağlantı ayarlarınız hatalıdır. Lütfen kontrol ediniz.");
                        return false;
                    }

                    switch (ex.Number)
                    {
                        case 18456:
                            Messages.HataMesaji("Server kullanıcı adı veya şifresi hatalıdır.");
                            break;
                        default:
                            Messages.HataMesaji(ex.Message);
                            break;
                    }
                }

                return false;
            }
        }

        public static bool CreateDatabase<TContext>(string splashCaption, string splashDescription, string onayMesaji, string bilgiMesaji) where TContext : DbContext, new()
        {
            using (var con = new TContext())
            {
                con.Database.Connection.ConnectionString = Bll.Functions.GeneralFunctions.GetConnectionString();

                if (con.Database.Exists()) return true;
                if (Messages.EvetSeciliEvetHayir(onayMesaji, "Onay") != DialogResult.Yes) return false;

                var splashForm = new SplashScreenManager(Form.ActiveForm, typeof(BekleForm), true, true);
                SplashBaslat(splashForm);

                splashForm.SetWaitFormCaption(splashCaption);
                splashForm.SetWaitFormDescription(splashDescription);

                try
                {
                    if (con.Database.CreateIfNotExists())
                    {
                        SplashDurdur(splashForm);
                        Messages.BilgiMesaji(bilgiMesaji);
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    SplashDurdur(splashForm);

                    switch (ex.Number)
                    {
                        case 5170:
                            Messages.HataMesaji("Veritabanı dosyalarının yükleneceği klasörde aynı isimde dosya zaten var. Lütfen kontrol ediniz.\n\n" + ex.Message);
                            break;
                        default:
                            Messages.HataMesaji(ex.Message);
                            break;
                    }
                }

                return false;
            }
        }

        private static void SplashBaslat(SplashScreenManager manager)
        {
            if (manager.IsSplashFormVisible)
            {
                manager.CloseWaitForm();
                manager.ShowWaitForm();
            }
            else
            {
                manager.ShowWaitForm();
            }
        }

        private static void SplashDurdur(SplashScreenManager manager)
        {
            if (manager.IsSplashFormVisible)
            {
                manager.CloseWaitForm();
            }
        }

        public static string Md5Sifrele(this string value)
        {
            var md5 = new MD5CryptoServiceProvider();
            var byt = Encoding.UTF8.GetBytes(value);
            byt = md5.ComputeHash(byt);

            var md5Sifre = BitConverter.ToString(byt).Replace("-", "");

            return md5Sifre;
        }

        public static (SecureString secureSifre, SecureString secureGizliKelime, string sifre, string gizliKelime) SifreUret()
        {
            string RandomDegerUret(int minValue, int count)
            {
                var random = new Random();

                //const atanan değişkenin hiçbir zaman değişmeyeceğini, ekleme veya guncelleme yapılmayağını gösterir.
                const string karakterTablosu = "0123456789ABCDEFGHIJKLMNOPRSTUVXWYZabcdefghijklmnoprstuvxwyz";
                string sonuc = null;

                for (int i = 0; i < count; i++)
                {
                    sonuc += karakterTablosu[random.Next(minValue, karakterTablosu.Length - 1)].ToString();
                }

                return sonuc;
            }

            var secureSifre = RandomDegerUret(0, 8).ConvertToSecureString();
            var secureGizlikelime = RandomDegerUret(9, 10).ConvertToSecureString();
            var sifre = secureSifre.ConvertToUnSecureString().Md5Sifrele();
            var gizliKelime = secureGizlikelime.ConvertToUnSecureString().Md5Sifrele();

            return (secureSifre, secureGizlikelime, sifre, gizliKelime);
        }

        public static bool SifreMailiGonder(this string kullaniciAdi, string email, SecureString secureSifre, SecureString secureGizliKelime)
        {
            using (var bll = new MailParametreBll())
            {
                var entity = (MailParametre)bll.Single(null);

                if (entity == null)
                {
                    Messages.HataMesaji("Email gönderilemedi. Kurumun Email parametreleri girilmemiş. Lütfen kontrol edip tekrar deneyiniz.");
                    return false;
                }

                var client = new SmtpClient
                {
                    Port = entity.PortNo,
                    Host = entity.Host,
                    EnableSsl = entity.SLLKullan == EvetHayir.Evet,
                    UseDefaultCredentials = true,
                    Credentials = new NetworkCredential(entity.EMail, entity.Sifre.Decrypt(entity.Id + entity.Kod).ConvertToSecureString()),
                };

                var mesaj = new MailMessage
                {
                    From = new MailAddress(entity.EMail, "Öğrenci Takip Programı"),
                    To = { email },
                    Subject = "Öğrenci Takip Programı Kullanıcı Bilgileri",
                    IsBodyHtml = true,
                    Body = "Öğrenci Takip Programına giriş için gereken kullanıcı adı, şifre ve gizli kelime bilgileri aşağıdadır.<br/>" +
                    "Lütfen programa giriş yaptıktan sonra bu bilgileri değiştiriniz.<br/><br/><br/>" +
                    $"<b>Kullanıcı Adı : </b>{ kullaniciAdi }<br/>" +
                    $"<b>Şifre : </b>{ secureSifre.ConvertToUnSecureString() }<br/>" +
                    $"<b>Gizli Kelime : </b>{ secureGizliKelime.ConvertToUnSecureString() }"
                };

                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    client.Send(mesaj);

                    Cursor.Current = Cursors.Default;

                    return true;
                }
                catch (Exception ex)
                {
                    Messages.HataMesaji(ex.Message);
                    return false;
                }
            }
        }

        public static void EncryptConfigFile(string configFileName, params string[] sectionName)
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(configFileName);

            foreach (var x in sectionName)
            {
                var section = configuration.GetSection(x);

                if (section.SectionInformation.IsProtected)
                {
                    return;
                }
                else
                {
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }

                section.SectionInformation.ForceSave = true;
                configuration.Save();
            }
        }
    }
}
