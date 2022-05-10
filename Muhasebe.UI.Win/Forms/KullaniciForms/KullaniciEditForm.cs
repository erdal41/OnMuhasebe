using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.Common.Messages;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Functions;
using System.Security;
using System.Windows.Forms;

namespace Muhasebe.UI.Win.Forms.KullaniciForms
{
    public partial class KullaniciEditForm : BaseEditForm
    {
        #region Variables

        private string _sifre;
        private string _gizliKelime;
        private SecureString _secureSifre;
        private SecureString _secureGizliKelime;
        private bool _tekrarGonder;

        #endregion

        public KullaniciEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new KullaniciBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            BaseKartTuru = KartTuru.Kullanici;    //Kartturu form isimleri ve yetki için
            ShowItems = new BarItem[] { btnSifreSifirla };
            EventsLoad();
        }

        #region Functions

        public override void Yukle()
        {
            OldEntity = BaseIslemTuru == IslemTuru.EntityInsert ? new Kullanici
                () : ((KullaniciBll)Bll).Single(FilterFunctions.Filter<Kullanici>(Id));
            NesneyiKontrollereBagla();

            if (BaseIslemTuru != IslemTuru.EntityInsert) return;
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKullaniciAdi.Focus();
            btnSifreSifirla.Enabled = false;
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Kullanici)OldEntity;

            txtKullaniciAdi.Text = entity.Kod;
            txtAdi.Text = entity.Adi;
            txtSoyadi.Text = entity.Soyadi;
            txtEmail.Text = entity.Email;
            txtAciklama.Text = entity.Aciklama;
            tglDurum.IsOn = entity.Durum;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Kullanici
            {
                Id = Id,
                Kod = txtKullaniciAdi.Text,
                Adi = txtAdi.Text,
                Soyadi = txtSoyadi.Text,
                Email = txtEmail.Text,
                Sifre = _sifre,
                GizliKelime = _gizliKelime,
                Aciklama = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            SifreUret();

            var result = base.EntityInsert();

            if (result)
            {
                txtKullaniciAdi.Text.SifreMailiGonder(txtEmail.Text, _secureSifre, _secureGizliKelime);
            }

            return result;
        }

        protected override bool EntityUpdate()
        {
            var result = base.EntityUpdate();

            if (_tekrarGonder)
            {
                txtKullaniciAdi.Text.SifreMailiGonder(txtEmail.Text, _secureSifre, _secureGizliKelime);
            }

            return result;
        }

        private void SifreUret()
        {
            var (secureSifre, secureGizliKelime, sifre, gizliKelime) = GeneralFunctions.SifreUret();

            _sifre = sifre;
            _gizliKelime = gizliKelime;
            _secureSifre = secureSifre;
            _secureGizliKelime = secureGizliKelime;

            GuncelNesneOlustur();
        }

        public override void SifreSifirla()
        {
            if (Messages.EmailGonderimOnayMesaji() != DialogResult.Yes) return;

            _tekrarGonder = true;
            SifreUret();
            btnKaydet.PerformClick();
        }

        #endregion
    }
}