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
    public class FaturaBll : BaseGenelBll<Fatura>, IBaseCommonBll
    {
        public FaturaBll() : base(KartTuru.Fatura) { }

        public FaturaBll(Control ctrl) : base(ctrl, KartTuru.Fatura) { }

        public override BaseEntity Single(Expression<Func<Fatura, bool>> filter)
        {
            return BaseSingle(filter, x => new FaturaSingle
            {
                Id = x.Id,
                Kod = x.Kod,
                FaturaTipi = x.FaturaTipi,
                FaturaTarihi = x.FaturaTarihi,
                VadeTarihi = x.VadeTarihi,
                FaturaTuru = x.FaturaTuru,
                IrsaliyeNo = x.IrsaliyeNo,
                IrsaliyeTarihi = x.IrsaliyeTarihi,
                CariId = x.CariId,
                CariKodu = ((int)x.Cari.CariHesapTuru).ToString() + " - " + x.Cari.Kod,
                CariAdi = x.Cari.CariAdi,
                VergiDairesi = x.Cari.VergiDairesi,
                VergiNo = x.Cari.VergiNo,
                TamAdres = x.Cari.Adres + ", " + x.Cari.PostaKodu + " " + x.Cari.Ilce.IlceAdi + " / " + x.Cari.Il.IlAdi + " / " + x.Cari.Ulke.UlkeAdi,
                Aciklama = x.Aciklama,
                IlkTutar = x.IlkTutar,
                Iskonto = x.Iskonto,
                NetTutar = x.NetTutar,
                KdvTutari = x.KdvTutari,
                ToplamTutar = x.ToplamTutar,
                ToplamTutarYazi = x.ToplamTutarYazi,
            });
        }

        public IrsaliyeRapor SingleDetail(Expression<Func<Fatura, bool>> filter)
        {
            return BaseSingle(filter, x => new IrsaliyeRapor
            {
                FaturaId = x.Id,
                IrsaliyeTarihi = x.IrsaliyeTarihi,
                CariAdi = x.Cari.CariAdi,
                TamAdres = x.Cari.Adres + ", " + x.Cari.PostaKodu + " " + x.Cari.Ilce.IlceAdi + " / " + x.Cari.Il.IlAdi + " / " + x.Cari.Ulke.UlkeAdi,
                VergiDairesi = x.Cari.VergiDairesi,
                VergiNo = x.Cari.VergiNo,

                StokBilgileri = x.StokBilgileri.Where(y => y.FaturaId == x.Id).Select(y => new StokBilgileriRapor
                {
                    MiktarBirim = y.Miktar + " " + y.Stok.Birim.BirimKisaAdi,
                    StokAdi = y.Stok.StokAdi,
                }).ToList(),
            });
        }

        public BaseEntity SingleSummary(Expression<Func<Fatura, bool>> filter)
        {
            return BaseSingle(filter, x => x);
        }

        public override IEnumerable<BaseEntity> List(Expression<Func<Fatura, bool>> filter)
        {
            return BaseList(filter, x => new FaturaList
            {
                Id = x.Id,
                Kod = x.Kod,
                FaturaTipi = x.FaturaTipi,
                FaturaTarihi = x.FaturaTarihi,
                VadeTarihi = x.VadeTarihi,
                FaturaTuru = x.FaturaTuru,
                IrsaliyeNo = x.IrsaliyeNo,
                IrsaliyeTarihi = x.IrsaliyeTarihi,
                CariId = x.CariId,
                CariKodu = ((int)x.Cari.CariHesapTuru).ToString() + " - " + x.Cari.Kod,
                CariAdi = x.Cari.CariAdi,
                VergiDairesi = x.Cari.VergiDairesi,
                VergiNo = x.Cari.VergiNo,
                TamAdres = x.Cari.Adres + ", " + x.Cari.PostaKodu + " " + x.Cari.Ilce.IlceAdi + " / " + x.Cari.Il.IlAdi + " / " + x.Cari.Ulke.UlkeAdi,
                Aciklama = x.Aciklama,
                IlkTutar = x.IlkTutar,
                Iskonto = x.Iskonto,
                NetTutar = x.NetTutar,
                KdvTutari = x.KdvTutari,
                ToplamTutar = x.ToplamTutar,
                ToplamTutarYazi = x.ToplamTutarYazi,

            }).OrderBy(x => x.Kod).ToList();
        }

        public override bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.Fatura, false);
        }
    }
}