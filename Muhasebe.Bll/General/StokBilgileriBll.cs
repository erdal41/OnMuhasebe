using Muhasebe.Bll.Base;
using Muhasebe.Bll.Interfaces;
using Muhasebe.Data.Contexts;
using Muhasebe.Model.Dto;
using Muhasebe.Model.Entities;
using Muhasebe.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Muhasebe.Bll.General
{
    public class StokBilgileriBll : BaseHareketBll<StokBilgileri, MuhasebeContext>, IBaseHareketSelectBll<StokBilgileri>
    {
        public IEnumerable<BaseHareketEntity> List(Expression<Func<StokBilgileri, bool>> filter)
        {
            return List(filter, x => new StokBilgileriList
            {
                Id = x.Id,
                FaturaId = x.FaturaId,
                StokId = x.StokId,
                StokKodu = x.Stok.Kod,
                StokAdi = x.Stok.StokAdi,
                Miktar = x.Miktar,
                BirimAdi = x.Stok.Birim.BirimAdi,
                BirimFiyati = x.BirimFiyati,
                MiktarTutari = (decimal)(x.Miktar * x.BirimFiyati),
                IskontoOrani = x.IskontoOrani,
                IskontoTutari = (decimal)(x.Miktar * x.BirimFiyati) * (decimal)x.IskontoOrani / 100,
                KdvHaricTutar = ((decimal)(x.Miktar * x.BirimFiyati)) - ((decimal)(x.Miktar * x.BirimFiyati) * (decimal)x.IskontoOrani / 100),
                KdvOrani = x.KdvOrani,
                KdvTutari = (((decimal)(x.Miktar * x.BirimFiyati)) - ((decimal)(x.Miktar * x.BirimFiyati) * (decimal)x.IskontoOrani / 100)) * (decimal)x.KdvOrani / 100,
                Tutar = (((decimal)(x.Miktar * x.BirimFiyati)) - ((decimal)(x.Miktar * x.BirimFiyati) * (decimal)x.IskontoOrani / 100)) + ((((decimal)(x.Miktar * x.BirimFiyati)) - ((decimal)(x.Miktar * x.BirimFiyati) * (decimal)x.IskontoOrani / 100)) * (decimal)x.KdvOrani / 100),
            }).ToList();
        }
    }
}