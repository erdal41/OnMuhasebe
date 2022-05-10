using DevExpress.XtraBars;
using Muhasebe.Bll.Functions;
using Muhasebe.Bll.General;
using Muhasebe.Common.Messages;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Functions;
using Muhasebe.UI.Win.Forms.GeneralForms;
using System.Windows.Forms;

namespace Muhasebe.UI.Win.Forms.KullaniciForms
{
    public partial class SifreDegistirEditForm : BaseEditForm
    {
        public SifreDegistirEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new KullaniciBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            HideItems = new BarItem[] { btnYeni, btnGerial, btnSil };
            EventsLoad();
        }

        #region Functions

        private void SifreDegistir()
        {
            if (Messages.KayitMesaji() != DialogResult.Yes) return;

            var entity = ((KullaniciBll)Bll).Single(x => x.Id == AnaForm.KullaniciId).EntityConvert<Kullanici>();
            if (entity == null) return;
            if (HataliGiris()) return;

            if (entity.Sifre == txtEskiSifre.Text.Md5Sifrele())
            {
                var newEntity = new Kullanici
                {
                    Id = entity.Id,
                    Kod = entity.Kod,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    Email = entity.Email,
                    Sifre = txtYeniSifre.Text.Md5Sifrele(),
                    GizliKelime = string.IsNullOrEmpty(txtGizliKelime.Text) ? entity.GizliKelime : txtGizliKelime.Text.Md5Sifrele(),
                    Aciklama = entity.Aciklama,
                    Durum = entity.Durum,
                };

                if (!((KullaniciBll)Bll).Update(entity, newEntity)) return;
                Messages.BilgiMesaji("Şifreniz başarılı bir şekilde değiştirilmiştir.");
                Close();
            }
            else
            {
                Messages.HataMesaji("Girilen eski şifre bilgisi hatalıdır. Lütfen kontrol edip tekrar deneyiniz.");
                txtEskiSifre.Focus();
            }
        }

        private bool HataliGiris()
        {
            if (txtYeniSifre.Text != txtYeniSifreTekrar.Text)
            {
                Messages.HataMesaji("Girilen yeni şifre, yeni şifre tekrarı ile uyuşmuyor. Lütfen kontrol ediniz.");
                txtYeniSifre.Focus();
                return true;
            }

            if (txtYeniSifre.Text.Length < 8)
            {
                Messages.HataMesaji("Girilen yeni şifrenin uzunluğu en az 8 karakter olmalıdır.");
                txtYeniSifre.Focus();
                return true;
            }

            if (!string.IsNullOrEmpty(txtGizliKelime.Text) && txtGizliKelime.Text.Length < 10)
            {
                Messages.HataMesaji("Girilen gizli kelimenin uzunluğu en az 10 karakter olmalıdır.");
                txtGizliKelime.Focus();
                return true;
            }

            return false;
        }

        #endregion

        #region Events

        protected override void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnKaydet)
            {
                SifreDegistir();
            }
            else if (e.Item == btnCikis)
            {
                Close();
            }
        }

        protected override void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();
        }

        #endregion
    }
}