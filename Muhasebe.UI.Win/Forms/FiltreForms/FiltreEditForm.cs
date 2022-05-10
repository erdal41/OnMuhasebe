using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Functions;
using Muhasebe.Bll.General;

namespace Muhasebe.UI.Win.Forms.FiltreForms
{
    public partial class FiltreEditForm : BaseEditForm
    {
        #region Variables

        private readonly KartTuru _filtreKartTuru;
        private readonly GridControl _filtreGrid;

        #endregion

        public FiltreEditForm(params object[] prm)
        {
            InitializeComponent();

            _filtreKartTuru = (KartTuru)prm[0];
            _filtreGrid = (GridControl)prm[1];

            HideItems = new BarItem[] { btnYeni, btnGerial };
            ShowItems = new BarItem[] { btnFarkliKaydet, btnUygula };

            DataLayoutControl = myDataLayoutControl;
            Bll = new FiltreBll(myDataLayoutControl);
            BaseKartTuru = KartTuru.Filtre;
            EventsLoad();
        }

        #region Functions

        public override void Yukle()
        {
            txtFiltreMetni.SourceControl = _filtreGrid;

            while (true)
            {
                if (BaseIslemTuru == IslemTuru.EntityInsert)
                {
                    OldEntity = new Filtre();
                    Id = BaseIslemTuru.IdOlustur(OldEntity);
                    txtKod.Text = ((FiltreBll)Bll).YeniKodVer(x => x.KartTuru == _filtreKartTuru);
                }
                else
                {
                    OldEntity = ((FiltreBll)Bll).Single(FilterFunctions.Filter<Filtre>(Id));

                    if (OldEntity == null)
                    {
                        BaseIslemTuru = IslemTuru.EntityInsert;
                        continue;
                    }
                    NesneyiKontrollereBagla();
                }
                break;
            }
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Filtre)OldEntity;
            txtKod.Text = entity.Kod;
            txtFiltreAdi.Text = entity.FiltreAdi;
            txtFiltreMetni.FilterString = entity.FiltreMetni;
        }

        protected override void GuncelNesneOlustur()
        {
            NewEntity = new Filtre
            {
                Id = Id,
                Kod = txtKod.Text,
                FiltreAdi = txtFiltreAdi.Text,
                FiltreMetni = txtFiltreMetni.FilterString,
                KartTuru = _filtreKartTuru
            };

            ButtonEnabledDurumu();
        }

        protected override bool EntityInsert()
        {
            return ((FiltreBll)Bll).Insert(NewEntity, x => x.Kod == NewEntity.Kod && x.KartTuru == _filtreKartTuru);
        }

        protected override bool EntityUpdate()
        {
            return ((FiltreBll)Bll).Update(OldEntity, NewEntity, x => x.Kod == NewEntity.Kod && x.KartTuru == _filtreKartTuru);
        }

        protected override void FiltreUygula()
        {
            txtFiltreMetni.Select();
            txtFiltreMetni.ApplyFilter();
        }

        protected internal override void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;

            GeneralFunctions.ButtonEnabledDurumu(btnKaydet, btnFarkliKaydet, btnSil, BaseIslemTuru, OldEntity, NewEntity);
        } 

        #endregion
    }
}