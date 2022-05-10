using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Muhasebe.Bll.Functions;
using Muhasebe.Bll.General;
using Muhasebe.Bll.Interfaces;
using Muhasebe.Common.Enums;
using Muhasebe.Common.Functions;
using Muhasebe.Data.Contexts;
using Muhasebe.Model.Dto;
using Muhasebe.Model.Entities;
using Muhasebe.Model.Entities.Base;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Functions;
using System;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Windows.Forms;

namespace Muhasebe.UI.Win.Forms.GeneralForms
{
    public partial class BaglantiKontrolEditForm : BaseEditForm
    {
        #region Variables

        BaseEntity KullaniciNewEntity;
        IBaseBll _KullaniciBll;

        #endregion

        public BaglantiKontrolEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            HideItems = new BarItem[] { btnYeni, btnSil };
            txtYetkilendirmeTuru.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<YetkilendirmeTuru>());
            EventsLoad();

            Size = new Size(380, 243);
        }

        #region Functions

        public override void Yukle()
        {
            OldEntity = new BaglantiAyarlari
            {
                Server = ConfigurationManager.AppSettings["Server"],
                YetkilendirmeTuru = ConfigurationManager.AppSettings["YetkilendirmeTuru"].GetEnum<YetkilendirmeTuru>(),
                KullaniciAdi = ConfigurationManager.AppSettings["KullaniciAdi"].ConvertToSecureString(),
                Sifre = ConfigurationManager.AppSettings["YetkilendirmeTuru"].GetEnum<YetkilendirmeTuru>() == YetkilendirmeTuru.SqlServer ? "Burası Şifre Alanıdır.".ConvertToSecureString() : "".ConvertToSecureString(),
            };

            NesneyiKontrollereBagla();
        }

        protected override void NesneyiKontrollereBagla()
        {
            txtServer.Text = ConfigurationManager.AppSettings["Server"];
            txtYetkilendirmeTuru.SelectedItem = ConfigurationManager.AppSettings["YetkilendirmeTuru"];
            txtKullaniciAdi.Text = ConfigurationManager.AppSettings["KullaniciAdi"];
            txtSifre.Text = ConfigurationManager.AppSettings["YetkilendirmeTuru"].GetEnum<YetkilendirmeTuru>() == YetkilendirmeTuru.SqlServer ? "Burası Şifre Alanıdır." : "";
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new BaglantiAyarlari
            {
                Server = txtServer.Text,
                YetkilendirmeTuru = txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>(),
                KullaniciAdi = txtKullaniciAdi.Text.ConvertToSecureString(),
                Sifre = txtSifre.Text.ConvertToSecureString(),
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityUpdate()
        {
            if (!Functions.GeneralFunctions.BaglantiKontrolu(txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>())) return false;

            Functions.GeneralFunctions.CreateConnectionString("pane1228_MuhasebeDB", txtServer.Text, txtKullaniciAdi.Text.ConvertToSecureString(), txtSifre.Text.ConvertToSecureString(), txtYetkilendirmeTuru.Text.GetEnum<YetkilendirmeTuru>());

            if (!Functions.GeneralFunctions.CreateDatabase<MuhasebeContext>("Lütfen Bekleyiniz", "Program ilk kurulum için hazırlanıyor...", "Programın ilk kurulum işlemi yapılacaktır. Onaylıyor musunuz?", "İlk kurulum işlemi başarılı bir şekilde oluşturuldu.")) return false;

            using (var bll = new KullaniciBll())
            {
                var source = bll.List(null).Count();
                if (source < 1)
                {
                    KullaniciNewEntity = new Kullanici
                    {
                        Id = 123456789,
                        Kod = "admin",
                        Adi = "admin",
                        Soyadi = "admin",
                        Sifre = "123".Md5Sifrele(),
                        GizliKelime = "123".Md5Sifrele(),
                        Email = "admin@gmail.com",
                        Aciklama = "Programın ilk kurulumu ile gelen kullanıcı hesabıdır.",
                        Durum = true,
                    };

                    _KullaniciBll = new KullaniciBll();
                    ((KullaniciBll)_KullaniciBll).Insert(KullaniciNewEntity, x => x.Kod == KullaniciNewEntity.Kod);
                }
            }

            var list = Muhasebe.Bll.Functions.GeneralFunctions.DegisenAlanlariGetir(OldEntity, NewEntity).ToList();

            list.ForEach(x =>
            {
                switch (x)
                {
                    case "Server":
                        Functions.GeneralFunctions.AppSettingWrite(x, txtServer.Text);
                        break;
                    case "YetkilendirmeTuru":
                        Functions.GeneralFunctions.AppSettingWrite(x, txtYetkilendirmeTuru.Text);
                        break;
                    case "KullaniciAdi":
                        Functions.GeneralFunctions.AppSettingWrite(x, txtKullaniciAdi.Text);
                        break;
                    case "Sifre":
                        Functions.GeneralFunctions.AppSettingWrite(x, txtSifre.Text);
                        break;
                }
            });
            MessageBox.Show(ConfigurationManager.AppSettings["Server"].ToString());
            return true;
        }

        #endregion

        #region Events

        protected override void Control_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(sender is ComboBoxEdit edit)) return;

            var yetkilendirmeTuru = edit.Text.GetEnum<YetkilendirmeTuru>();

            txtKullaniciAdi.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtSifre.Enabled = yetkilendirmeTuru == YetkilendirmeTuru.SqlServer;
            txtKullaniciAdi.Focus();

            if (yetkilendirmeTuru != YetkilendirmeTuru.Windows) return;

            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }

        #endregion
    }
}