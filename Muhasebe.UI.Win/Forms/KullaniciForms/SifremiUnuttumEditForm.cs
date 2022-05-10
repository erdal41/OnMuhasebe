using DevExpress.XtraBars;
using Muhasebe.Bll.Functions;
using Muhasebe.Bll.General;
using Muhasebe.Common.Messages;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Functions;
using System.Windows.Forms;

namespace Muhasebe.UI.Win.Forms.KullaniciForms
{
    public partial class SifremiUnuttumEditForm : BaseEditForm
    {
        #region Variables

        private readonly string _kullaniciAdi;

        #endregion

        public SifremiUnuttumEditForm(params object[] prm)
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new KullaniciBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            HideItems = new BarItem[] { btnYeni, btnKaydet, btnGerial, btnSil };
            ShowItems = new BarItem[] { btnSifreSifirla };
            EventsLoad();

            _kullaniciAdi = prm[0].ToString();
        }

        #region Functions

        public override void Yukle()
        {
            txtKullaniciAdi.Text = _kullaniciAdi;
        }

        public override void SifreSifirla()
        {
            if (Messages.EmailGonderimOnayMesaji() != DialogResult.Yes) return;

            var entity = ((KullaniciBll)Bll).Single(x => x.Kod == txtKullaniciAdi.Text).EntityConvert<Kullanici>();
            if (entity == null)
            {
                Messages.HataMesaji("Veritabanında böyle bir kullanıcı kaydı bulunmamaktadır.");
                return;
            }

            if (txtAdi.Text == entity.Adi && txtSoyadi.Text == entity.Soyadi && txtEmail.Text == entity.Email && txtGizliKelime.Text.Md5Sifrele() == entity.GizliKelime)
            {
                var (secureSifre, secureGizliKelime, sifre, gizliKelime) = Functions.GeneralFunctions.SifreUret();

                var newEntity = new Kullanici
                {
                    Id = entity.Id,
                    Kod = entity.Kod,
                    Adi = entity.Adi,
                    Soyadi = entity.Soyadi,
                    Email = entity.Email,
                    Aciklama = entity.Aciklama,
                    Durum = entity.Durum,
                    Sifre = sifre,
                    GizliKelime = gizliKelime,
                };

                if (!((KullaniciBll)Bll).Update(entity, newEntity)) return;

                var sonuc = txtKullaniciAdi.Text.SifreMailiGonder(entity.Email, secureSifre, secureGizliKelime);

                if (sonuc)
                {
                    Messages.BilgiMesaji("Şifre sıfırlama işlemi başarılı bir şekilde gerçekleşti.");
                    Close();
                }
                else
                {
                    Messages.HataMesaji("Şifre sıfırlama işlemi başarılı bir şekilde gerçekleşti. Ama E-Mail gönderilemedi. Lütfen tekrar deneyiniz.");
                }
            }
            else
            {
                Messages.HataMesaji("Girilen bilgiler mevcut bilgilerle uyuşmuyor. Lütfen kontrol edip tekrar deneyiniz.");
            }
        } 

        #endregion
    }
}