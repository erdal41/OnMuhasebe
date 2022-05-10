using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Muhasebe.Bll.Functions;
using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.Common.Functions;
using Muhasebe.Common.Messages;
using Muhasebe.Data.Contexts;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.KullaniciForms;
using Muhasebe.UI.Win.Functions;
using Muhasebe.UI.Win.Show;
using Muhasebe.UI.Win.UserControls.Controls;
using OgrenciTakip.UI.Win.Show;
using System;
using System.Configuration;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Muhasebe.UI.Win.Forms.GeneralForms
{
    public partial class GirisForm : XtraForm
    {
        #region Variables

        private Point _mouseLocation;

        #endregion

        public GirisForm()
        {
            InitializeComponent();
            EventsLoad();
        }

        #region Functions

        private void EventsLoad()
        {
            //Control Events
            foreach (Control control in Controls)
            {
                if (!(control is MyDataLayoutControl)) continue;
                control.MouseDown += Control_MouseDown;
                control.MouseMove += Control_MouseMove;

                foreach (Control ctrl in control.Controls)
                {
                    ctrl.KeyDown += Control_KeyDown;

                    switch (ctrl)
                    {
                        case MySimpleButton btn:
                            btn.Click += Control_Click;
                            break;
                        case MyHyperlinkLabelControl hypr:
                            hypr.Click += Control_Click;
                            break;
                    }
                }
            }

            //Form Events
            Shown += GirisForm_Shown;
            Load += GirisForm_Load;
        }

        private void Yukle()
        {
            txtVersion.Text = $"Versiyon : {Assembly.GetExecutingAssembly().GetName().Version}";

            var server = ConfigurationManager.AppSettings["Server"];
            var yetkilendirmeTuru = ConfigurationManager.AppSettings["YetkilendirmeTuru"].GetEnum<YetkilendirmeTuru>();
            var kullaniciAdi = ConfigurationManager.AppSettings["KullaniciAdi"].ConvertToSecureString();
            var sifre = ConfigurationManager.AppSettings["Sifre"].ConvertToSecureString();

            if (!Functions.GeneralFunctions.BaglantiKontrolu(server, kullaniciAdi, sifre, yetkilendirmeTuru, true))
            {
                if (ShowEditForms<BaglantiKontrolEditForm>.ShowDialogEditForm(IslemTuru.EntityUpdate))
                {
                    Yukle();
                    return;
                }
            }

            Functions.GeneralFunctions.CreateConnectionString("pane1228_MuhasebeDB", server, kullaniciAdi, sifre, yetkilendirmeTuru);
        }

        private void CreateConnection()
        {
            var server = ConfigurationManager.AppSettings["Server"];
            var yetkilendirmeTuru = ConfigurationManager.AppSettings["YetkilendirmeTuru"].GetEnum<YetkilendirmeTuru>();
            var kullaniciAdi = ConfigurationManager.AppSettings["KullaniciAdi"].ConvertToSecureString();
            var sifre = ConfigurationManager.AppSettings["Sifre"].ConvertToSecureString();

            if (!Functions.GeneralFunctions.BaglantiKontrolu(server, kullaniciAdi, sifre, yetkilendirmeTuru)) return;
            Functions.GeneralFunctions.CreateConnectionString("pane1228_MuhasebeDB", server, kullaniciAdi, sifre, yetkilendirmeTuru);
        }

        private void Giris()
        {
            CreateConnection();

            using (var kullaniciBll = new KullaniciBll())
            {
                var kullanici = kullaniciBll.Single(x => x.Kod == txtKullaniciAdi.Text).EntityConvert<Kullanici>();

                if (kullanici == null || txtSifre.Text.Md5Sifrele() != kullanici.Sifre)
                {
                    Messages.HataMesaji("Kullanıcı adı veya şifre hatalıdır. Lütfen kontrol edip tekrar deneyiniz.");
                    txtKullaniciAdi.Focus();
                    return;
                }

                if (!kullanici.Durum)
                {
                    Messages.HataMesaji("Pasif durumdaki kullanıcı ile giriş yapamazsınız.");
                    txtKullaniciAdi.Focus();
                    return;
                }

                using (var parametreBll = new KullaniciParametreBll())
                {
                    var entity = parametreBll.Single(x => x.KullaniciId == kullanici.Id).EntityConvert<KullaniciParametre>();
                    AnaForm.KullaniciParametreleri = entity ?? new KullaniciParametre();

                    AnaForm.KullaniciId = kullanici.Id;
                    AnaForm.KullaniciAdi = kullanici.Adi;

                    Hide();

                    ShowRibbonForms<AnaForm>.ShowForm(false);
                }
            }
        }

        #endregion

        #region Events

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            //Mouse'un koordinatlarını aldık.
            _mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            var position = MousePosition;
            position.Offset(_mouseLocation.X, _mouseLocation.Y);
            Location = position;
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            switch (sender)
            {
                case MySimpleButton button:
                    if (button == btnGiris)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        Giris();
                        Cursor.Current = Cursors.Default;
                    }
                    else if (button == btnVazgec)
                    {
                        Close();
                    }
                    break;
                case MyHyperlinkLabelControl hyper:
                    if (hyper == btnBaglantiAyarlari)
                    {
                        if (ShowEditForms<BaglantiKontrolEditForm>.ShowDialogEditForm(IslemTuru.EntityUpdate))
                        {
                            Yukle();
                        }
                    }
                    else if (hyper == btnSifremiUnuttum)
                    {
                        CreateConnection();
                        ShowEditForms<SifremiUnuttumEditForm>.ShowDialogEditForm(IslemTuru.EntityUpdate, txtKullaniciAdi.Text);
                    }
                    break;
            }
        }

        private void GirisForm_Shown(object sender, EventArgs e)
        {
            txtKullaniciAdi.Focus();
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Baslatiliyor));
            Yukle();
            SplashScreenManager.CloseForm();
        }

        #endregion
    }
}