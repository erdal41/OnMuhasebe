using DevExpress.XtraBars;
using Muhasebe.Bll.Functions;
using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.Common.Functions;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Functions;

namespace Muhasebe.UI.Win.Forms.GeneralForms
{
    public partial class EmailParametreEditForm : BaseEditForm
    {
        public EmailParametreEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new MailParametreBll(myDataLayoutControl); //Hata durumunda kontrollere focuslanma için
            txtSSLKullan.Properties.Items.AddRange(EnumFunctions.GetEnumDescriptionList<EvetHayir>());
            HideItems = new BarItem[] { btnYeni, btnSil };
            EventsLoad();

        }

        #region Functions

        public override void Yukle()
        {
            //Bu form direk edit olarak açıldığı için farklı bir sorgulama metodu yaptık. OldEntity bağlı olan Bll'deki kullaniciId parametresi giriş yapan kullanıcının Id'sine eşit ise o kullanıcının verilerini yukler. Ama yeni kullanıcı kayıt olup giriş yapmışsa yani null ise KullaniciParametreSingle'deki varsayılan verileri çeker.
            OldEntity = ((MailParametreBll)Bll).Single(null) ?? new MailParametre();
            ((MailParametre)OldEntity).Sifre = "Bu Email Şifresidir".Encrypt(OldEntity.Id + OldEntity.Kod);


            // OldEntity bağlı olan Bll'deki kullaniciId parametresi giriş yapan kullanıcının Id'sine eşit ise OldEntity sıfır(0) gelmeyecek ve güncelleme yapacak. Ama yeni kullanıcı kayıt olup giriş yapmışsa sıfır(0) gelecek ve kaydetme işlemini yapacak.
            BaseIslemTuru = OldEntity.Id == 0 ? IslemTuru.EntityInsert : IslemTuru.EntityUpdate;
            NesneyiKontrollereBagla();

            //işlem turu insert ise return yani işlem durur. Update ise aşağıdaki işlemlere devam eder.
            if (BaseIslemTuru != IslemTuru.EntityInsert) return;

            //Yeni id oluştur
            Id = BaseIslemTuru.IdOlustur(OldEntity);
            txtKod.Text = "Email";
            //txte focuslanır
            txtEmail.Focus();
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (MailParametre)OldEntity;

            Id = entity.Id;
            txtKod.Text = entity.Kod;
            txtEmail.Text = entity.EMail;
            txtSifre.Text = BaseIslemTuru == IslemTuru.EntityInsert ? null : entity.Sifre.Decrypt(entity.Id + entity.Kod);
            txtPortNo.Value = entity.PortNo;
            txtHost.Text = entity.Host;
            txtSSLKullan.SelectedItem = entity.SLLKullan.ToName();
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new MailParametre
            {
                Id = Id,
                Kod = txtKod.Text,
                EMail = txtEmail.Text,
                Sifre = string.IsNullOrWhiteSpace(txtSifre.Text) ? null : txtSifre.Text.Encrypt(Id + txtKod.Text),
                PortNo = (int)txtPortNo.Value,
                Host = txtHost.Text,
                SLLKullan = txtSSLKullan.Text.GetEnum<EvetHayir>(),
            };

            ButtonEnabledDurumu();
        } 

        #endregion
    }
}