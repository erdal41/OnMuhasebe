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
    public class KullaniciBll : BaseGenelBll<Kullanici>, IBaseGenelBll, IBaseCommonBll
    {
        public KullaniciBll() : base(KartTuru.Kullanici) { }
        public KullaniciBll(Control ctrl) : base(ctrl, KartTuru.Kullanici) { }

        public BaseEntity SingleDetail(Expression<Func<Kullanici, bool>> filter)
        {
            return BaseSingle(filter, x => new Kullanici
            {
                Id = x.Id,
                Kod = x.Kod,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                Email = x.Email,
                Sifre = x.Sifre,
                GizliKelime = x.GizliKelime,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Kullanici, bool>> filter)
        {
            return BaseList(filter, x => new KullaniciList
            {
                Id = x.Id,
                Kod = x.Kod,
                Adi = x.Adi,
                Soyadi = x.Soyadi,
                Email = x.Email,
                Aciklama = x.Aciklama,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}