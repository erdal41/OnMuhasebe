using Muhasebe.Bll.Base;
using Muhasebe.Bll.Interfaces;
using Muhasebe.Common.Enums;
using Muhasebe.Model.Dto;
using Muhasebe.Model.Entities;
using Muhasebe.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Muhasebe.Bll.General
{
    public class CariBll : BaseGenelBll<Cari>, IBaseGenelBll, IBaseCommonBll
    {
        public CariBll() : base(KartTuru.Cari) { }

        public CariBll(Control ctrl) : base(ctrl, KartTuru.Cari) { }

        public override BaseEntity Single(Expression<Func<Cari, bool>> filter)
        {
            return BaseSingle(filter, x => new CariSingle
            {
                Id = x.Id,
                Kod = x.Kod,
                CariAdi = x.CariAdi,
                CariHesapTuru = x.CariHesapTuru,
                TcKimlikNo = x.TcKimlikNo,
                Telefon1 = x.Telefon1,
                Telefon2 = x.Telefon2,
                Telefon3 = x.Telefon3,
                Fax = x.Fax,
                Website = x.Website,
                Email = x.Email,
                VergiDairesi = x.VergiDairesi,
                VergiNo = x.VergiNo,
                Adres = x.Adres,
                PostaKodu = x.PostaKodu,
                IlceId = x.IlceId,
                IlceAdi = x.Ilce.IlceAdi,
                IlId = x.IlId,
                IlAdi = x.Il.IlAdi,
                UlkeId = x.UlkeId,
                UlkeAdi = x.Ulke.UlkeAdi,
                OzelKod1Id = x.OzelKod1Id,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Id = x.OzelKod2Id,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Cari, bool>> filter)
        {
            return BaseList(filter, x => new CariList
            {
                Id = x.Id,
                Kod = ((int)x.CariHesapTuru).ToString() + " - " + x.Kod,
                CariAdi = x.CariAdi,
                CariHesapTuru = x.CariHesapTuru,
                TcKimlikNo = x.TcKimlikNo,
                Telefon1 = x.Telefon1,
                Telefon2 = x.Telefon2,
                Telefon3 = x.Telefon3,
                Fax = x.Fax,
                Website = x.Website,
                Email = x.Email,
                VergiDairesi = x.VergiDairesi,
                VergiNo = x.VergiNo,
                Adres = x.Adres,
                PostaKodu = x.PostaKodu,
                IlceAdi = x.Ilce.IlceAdi,
                IlAdi = x.Il.IlAdi,
                UlkeAdi = x.Ulke.UlkeAdi,
                OzelKod1Adi = x.OzelKod1.OzelKodAdi,
                OzelKod2Adi = x.OzelKod2.OzelKodAdi,
                Aciklama = x.Aciklama,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}