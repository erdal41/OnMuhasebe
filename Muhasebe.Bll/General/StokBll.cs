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
    public class StokBll : BaseGenelBll<Stok>, IBaseGenelBll, IBaseCommonBll
    {
        public StokBll() : base(KartTuru.Stok) { }

        public StokBll(Control ctrl) : base(ctrl, KartTuru.Stok) { }

        public override BaseEntity Single(Expression<Func<Stok, bool>> filter)
        {
            return BaseSingle(filter, x => new StokSingle
            {
                Id = x.Id,
                Kod = x.Kod,
                StokAdi = x.StokAdi,
                BirimId = x.BirimId,
                BirimAdi = x.Birim.BirimAdi,
                AlisFiyati = x.AlisFiyati,
                AlisKdvOrani = x.AlisKdvOrani,
                SatisFiyati = x.SatisFiyati,
                SatisKdvOrani = x.SatisKdvOrani,
                Aciklama = x.Aciklama,
                Durum = x.Durum
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Stok, bool>> filter)
        {
            return BaseList(filter, x => new StokList
            {
                Id = x.Id,
                Kod = x.Kod,
                StokAdi = x.StokAdi,
                BirimAdi = x.Birim.BirimAdi,
                AlisFiyati = x.AlisFiyati,
                AlisKdvOrani = x.AlisKdvOrani,
                SatisFiyati = x.SatisFiyati,
                SatisKdvOrani = x.SatisKdvOrani,
                Aciklama = x.Aciklama,
            }).OrderBy(x => x.Kod).ToList();
        }
    }
}