using System.ComponentModel;

namespace Muhasebe.Common.Enums
{
    public enum KartTuru : byte
    {
        [Description("Özel Kod Kartı")]
        OzelKod = 1,
        [Description("Cari Kartı")]
        Cari = 2,
        [Description("İlçe Kartı")]
        Ilce = 3,
        [Description("İl Kartı")]
        Il = 4,
        [Description("Ülke Kartı")]
        Ulke = 5,
        [Description("Stok Kartı")]
        Stok = 6,
        [Description("Birim Kartı")]
        Birim = 7,
        [Description("Fatura Kartı")]
        Fatura = 8,
        [Description("Cari Hareketleri Kartı")]
        CariHareketleri = 9,
        [Description("Cari Hareket Fişi Kartı")]
        CariHareketFisi = 10,
        [Description("Dönem Kartı")]
        Donem = 11,
        [Description("Kullanıcı Kartı")]
        Kullanici = 12,
        [Description("Baglantı Ayarları Kartı")]
        BaglantiAyarlari = 13,
        [Description("Baglantı Ayarları Kartı")]
        Filtre = 14,
        [Description("Kullanıcı Parametre Kartı")]
        KullaniciParametre = 15,
    }
}