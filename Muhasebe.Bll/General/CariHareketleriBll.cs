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
    public class CariHareketleriBll : BaseGenelBll<CariHareketleri>, IBaseCommonBll
    {
        public CariHareketleriBll() : base(KartTuru.CariHareketleri) { }

        public CariHareketleriBll(Control ctrl) : base(ctrl, KartTuru.CariHareketleri) { }

        public override BaseEntity Single(Expression<Func<CariHareketleri, bool>> filter)
        {
            return BaseSingle(filter, x => new CariHareketleriSingle
            {
                Id = x.Id,
                Kod = x.Kod,
                HesapKodu = x.HesapKodu,
                FaturaId = x.FaturaId,
                CariId = x.CariId,
                CariKodu = x.Cari.Kod,
                CariAdi = x.Cari.CariAdi,
                Tarih = x.Tarih,
                BelgeNo = x.BelgeNo,
                BelgeTuru = x.BelgeTuru,
                OdemeTipi = x.OdemeTipi,
                Borc = x.Borc,
                Alacak = x.Alacak,
                Aciklama = x.Aciklama,
            });
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<CariHareketleri, bool>> filter)
        {
            return BaseList(filter, x => new CariHareketleriList
            {
                Id = x.Id,
                Kod = x.Kod,
                FaturaId = x.FaturaId,
                HesapKodu = x.HesapKodu,
                CariKodu = x.Cari.Kod,
                CariAdi = x.Cari.CariAdi,
                Tarih = x.Tarih,
                BelgeNo = x.BelgeNo,
                BelgeTuru = x.BelgeTuru,
                OdemeTipi = x.OdemeTipi,
                Borc = x.Borc,
                Alacak = x.Alacak,
                Aciklama = x.Aciklama,

            }).OrderBy(x => x.Tarih).ToList();
        }

        public override bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.CariHareketleri, false);
        }
    }
}