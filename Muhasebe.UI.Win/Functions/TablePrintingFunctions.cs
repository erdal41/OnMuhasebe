using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.GeneralForms;
using Muhasebe.UI.Win.Show;
using OgrenciTakip.UI.Win.Show;
using System.Drawing;
using System.Drawing.Printing;

namespace Muhasebe.UI.Win.Functions
{
    public class TablePrintingFunctions
    {
        #region Variables

        private static GridView _tablo;
        private static string _p1Baslik;
        private static string _p1Value;
        private static string _p2Baslik;
        private static string _p2Value;
        private static PrintableComponentLink _link;
        private static PrintingSystem _ps;
        private static DokumParametreleri _dp;

        #endregion

        #region Functions

        public static void Yazdir(GridView tablo, string raporBaslik, string p1Baslik = null, string p1Value = null, string p2Baslik = null, string p2Value = null)
        {
            _link = new PrintableComponentLink();
            _ps = new PrintingSystem();
            _tablo = tablo;
            _p1Baslik = p1Baslik;
            _p1Value = p1Value;
            _p2Baslik = p2Baslik;
            _p2Value = p2Value;
            _dp = ShowEditForms<TabloDokumParametreleri>.ShowDialogEditForm<DokumParametreleri>(raporBaslik);

            RaporDokumu();
        }

        private static void RaporDokumu()
        {
            BaslikEkle();
            RaporuKagidaSigdir();

            _tablo.OptionsPrint.PrintHorzLines = _dp.YatayCizgileriGoster == EvetHayir.Evet;
            _tablo.OptionsPrint.PrintVertLines = _dp.DikeyCizgileriGoster == EvetHayir.Evet;
            _tablo.OptionsPrint.PrintHeader = _dp.SutunBasliklariniGoster == EvetHayir.Evet;
            _tablo.OptionsView.ShowViewCaption = false;

            _link.Component = _tablo.GridControl;
            _link.PaperKind = PaperKind.Letter;
            _link.Margins = new Margins(59, 59, 115, 48);
            _link.CreateMarginalHeaderArea += Link_CreateMarginalHeaderArea;
            _link.CreateDocument(_ps);

            switch (_dp.DokumSekli)
            {
                case DokumSekli.TabloBaskiOnizleme:
                    ShowRibbonForms<RaporOnizleme>.ShowForm(true, _ps, _dp.RaporBaslik);
                    break;
                case DokumSekli.TabloYazdir:
                    for (int i = 0; i < _dp.YazdirilacakAdet; i++)
                    {
                        _link.Print(_dp.YaziciAdi);
                    }
                    break;
            }

            _tablo.OptionsView.ShowViewCaption = true;
        }

        private static void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            if (_dp.BaslikEkle == EvetHayir.Hayir) return;

            var boldFont = new Font("Tahoma", 7, FontStyle.Bold);
            var regularFont = new Font("Tahoma", 7, FontStyle.Regular);

            var sayfaBrick = new PageInfoBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = regularFont,
                PageInfo = PageInfo.NumberOfTotal,
                Format = "Sayfa : {0} / {1}",
                Alignment = BrickAlignment.Far,
                AutoWidth = true
            };
            _ps.Graph.DrawBrick(sayfaBrick, new RectangleF(200, 25, 40, 15));

            var tarihBrick = new PageInfoBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = regularFont,
                PageInfo = PageInfo.DateTime,
                Format = "Tarih : {0:dd.MM.yyyy}",
                Alignment = BrickAlignment.Far,
                AutoWidth = true
            };
            _ps.Graph.DrawBrick(tarihBrick, new RectangleF(0, 40, 50, 15));

            if (_p1Baslik != null)
            {
                var baslikBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
                {
                    Font = boldFont,
                    Text = _p1Baslik
                };
                _ps.Graph.DrawBrick(baslikBrick, new RectangleF(500, 40, 67, 15));

                var valueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
                {
                    Font = regularFont,
                    Text = $": {_p1Value}"
                };
                _ps.Graph.DrawBrick(valueBrick, new RectangleF(567, 40, 150, 15));
            }

            if (_p2Baslik != null)
            {
                var baslikBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
                {
                    Font = boldFont,
                    Text = _p2Baslik
                };
                _ps.Graph.DrawBrick(baslikBrick, new RectangleF(250, 55, 90, 15));

                var valueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
                {
                    Font = regularFont,
                    Text = $": {_p2Value}"
                };
                _ps.Graph.DrawBrick(valueBrick, new RectangleF(340, 55, 150, 15));
            }
        }

        private static void RaporuKagidaSigdir()
        {
            YazdirmaYonunuAyarla();

            switch (_dp.RaporuKagidaSigdir)
            {
                case RaporuKagidaSigdirmaTuru.SutunlariDaraltarakSigdir:
                    _tablo.OptionsPrint.AutoWidth = true;
                    break;
                case RaporuKagidaSigdirmaTuru.YaziBoyutunuKuculterekSigdir:
                    _tablo.OptionsPrint.AutoWidth = false;
                    _ps.Document.AutoFitToPagesWidth = 1;
                    break;
                default:
                    _tablo.OptionsPrint.AutoWidth = false;
                    _ps.Document.ScaleFactor = 1.0f;
                    break;
            }
        }

        private static void YazdirmaYonunuAyarla()
        {
            switch (_dp.YazdirmaYonu)
            {
                case YazdirmaYonu.Dikey:
                    _link.Landscape = false;
                    break;
                case YazdirmaYonu.Yatay:
                    _link.Landscape = true;
                    break;
                case YazdirmaYonu.Otomatik:
                    _link.Landscape = OtomatikYazdirmaYonu();
                    break;
            }
        }

        private static bool OtomatikYazdirmaYonu()
        {
            const int sayfaGenisligi = 703;
            var tabloSutunGenislikleri = 0;

            for (int i = 0; i < _tablo.Columns.Count; i++)
            {
                if (_tablo.Columns[i].Visible)
                {
                    tabloSutunGenislikleri += _tablo.Columns[i].Width;
                }
            }
            return tabloSutunGenislikleri > sayfaGenisligi;
        }

        private static void BaslikEkle()
        {
            if (_dp.BaslikEkle == EvetHayir.Hayir) return;

            var headerArea = new PageHeaderArea();
            headerArea.Content.AddRange(new[] { "", _dp.RaporBaslik, "" });
            headerArea.Font = new Font("Arial Narrow", 10f, FontStyle.Bold);
            headerArea.LineAlignment = BrickAlignment.Far;
            _link.PageHeaderFooter = new PageHeaderFooter(headerArea, null);
        } 

        #endregion
    }
}