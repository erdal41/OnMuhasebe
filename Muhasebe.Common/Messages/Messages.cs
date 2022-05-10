using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Muhasebe.Common.Messages
{
    public class Messages
    {
        #region Functions

        public static void HataMesaji(string hataMesaji)
        {
            XtraMessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void UyariMesaji(string uyariMesaji)
        {
            XtraMessageBox.Show(uyariMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void BilgiMesaji(string bilgiMesaji)
        {
            XtraMessageBox.Show(bilgiMesaji, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult EvetSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult HayirSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult EvetSeciliEvetHayirIptal(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult SilmeMesaji(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} silinecektir. Onaylıyor musunuz?", "Silme Onayı");
        }

        public static DialogResult KapanisMesaji()
        {
            return EvetSeciliEvetHayirIptal("Yapılan değişiklikler kayıt edilsin mi?", "Çıkış Onayı");
        }

        public static DialogResult KayitMesaji()
        {
            return EvetSeciliEvetHayir("Yapılan değişiklikler kayıt edilsin mi?", "Kayıt Onayı");
        }

        public static void KartSecmemeUyariMesaji()
        {
            UyariMesaji("Lütfen bir kart seçiniz.");
        }

        public static void MukerrerKayitHataMesaji(string alanAdi)
        {
            HataMesaji($"Girmiş olduğunuz {alanAdi} daha önce kullanılmıştır.");
        }

        public static void HataliVeriMesaji(string alanAdi)
        {
            HataMesaji($"{alanAdi} alanına geçerli bir değer girmelisiniz.");
        }

        public static DialogResult TabloExportMesaji(string dosyaFormati)
        {
            return EvetSeciliEvetHayir($"İlgili tablo, {dosyaFormati} olarak dışarı aktarılacaktır. Onaylıyor musunuz? ", "Aktarım Onayı");
        }

        public static void KartBulunamadiMesaji(string kartTuru)
        {
            UyariMesaji($"İşlem yapılabilecek {kartTuru} bulunamadı.");
        }

        public static void SecimHataMesaji(string alanAdi)
        {
            HataMesaji($"{alanAdi} seçimi yapmalısınız.");
        }

        public static void BosGecilemez(string alanAdi)
        {
            HataMesaji($"{alanAdi} alanı boş geçilemez.");
        }

        public static DialogResult EmailGonderimOnayMesaji()
        {
            return HayirSeciliEvetHayir("Kullanıcı şifresi sıfırlanarak, kullanıcı bilgilerini içeren yeni bir mail gönderilecektir. Onaylıyor musunuz?", "E-mail Onayı");
        } 

        #endregion
    }
}