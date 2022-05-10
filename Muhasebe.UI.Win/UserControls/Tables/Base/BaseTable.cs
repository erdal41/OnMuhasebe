using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Muhasebe.Bll.Interfaces;
using Muhasebe.Common.Messages;
using Muhasebe.Model.Entities.Base;
using Muhasebe.Model.Entities.Base.Interfaces;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Functions;
using Muhasebe.UI.Win.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;

namespace Muhasebe.UI.Win.UserControls.UserControl.Base
{
    public partial class BaseTable : XtraUserControl
    {
        #region Variables

        private bool _isLoaded;
        private bool _tabloSablonKayitEdilecek;
        protected internal GridView Tablo;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected IBaseBll Bll;
        protected IList<long> ListeDisiTutulacakKayitlar;
        protected internal bool TableValueChanged;
        protected internal BaseEditForm OwnerForm;

        #endregion

        public BaseTable()
        {
            InitializeComponent();
        }

        #region Functions

        protected void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in barManager.Items)
            {
                button.ItemClick += Button_ItemClick;
            }

            foreach (GridColumn column in Tablo.Columns)
            {
                if (column.ColumnEdit == null) continue;

                var type = column.ColumnEdit.GetType();

                if (type == typeof(RepositoryItemImageComboBox))
                {
                    ((RepositoryItemImageComboBox)column.ColumnEdit).SelectedValueChanged += ImageCombobox_SelectedValueChanged;
                }

                if (type == typeof(RepositoryItemCheckEdit))
                {
                    ((RepositoryItemCheckEdit)column.ColumnEdit).CheckedChanged += CheckEdit_CheckedChanged;
                }
            }

            //Navigator Events
            insUpNavigator.Navigator.ButtonClick += Navigator_ButtonClick;

            //Table Events
            Tablo.CellValueChanged += Tablo_CellValueChanged;
            Tablo.MouseUp += Tablo_MouseUp;
            Tablo.GotFocus += Tablo_GotFocus;
            Tablo.LostFocus += Tablo_LostFocus;
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.FocusedColumnChanged += Tablo_FocusedColumnChanged;
            Tablo.ColumnPositionChanged += Tablo_SablonChanged;
            Tablo.ColumnWidthChanged += Tablo_SablonChanged;
            Tablo.EndSorting += Tablo_SablonChanged;
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.FocusedRowObjectChanged += Tablo_FocusedRowObjectChanged;
            Tablo.RowCountChanged += Tablo_RowCountChanged;
            Tablo.CustomUnboundColumnData += Tablo_CustomUnboundColumnData;
            Tablo.CustomDrawFooterCell += Tablo_CustomDrawFooterCell;
        }

        protected internal void Yukle()
        {
            _isLoaded = true;
            TableValueChanged = false;
            OwnerForm.ButtonEnabledDurumu();
            insUpNavigator.Navigator.NavigatableControl = Tablo.GridControl;
            SablonYukle();
            Listele();
            ButtonGizleGoster();
            Tablo_LostFocus(Tablo, EventArgs.Empty);
        }

        private void SablonKaydet()
        {
            if (_tabloSablonKayitEdilecek)
            {
                Tablo.TabloSablonKaydet(Tablo.ViewCaption);
            }
        }

        private void SablonYukle()
        {
            Tablo.TabloSablonYukle(Tablo.ViewCaption);
        }

        protected internal virtual void Listele() { }
        private void ButtonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }

        protected virtual void HareketEkle() { }

        protected virtual void HareketSil()
        {
            if (Tablo.DataRowCount == 0) return;
            if (Messages.SilmeMesaji("İşlem Satırı") != DialogResult.Yes) return;

            Tablo.GetRow<IBaseHareketEntity>().Delete = true;
            Tablo.RefreshDataSource();
            ButtonEnabledDurumu(true);
        }

        protected void ButtonEnabledDurumu(bool durum)
        {
            TableValueChanged = durum;
            OwnerForm.ButtonEnabledDurumu();
        }

        protected internal virtual bool HataliGiris()
        {
            return false;
        }

        protected virtual void OpenEntity() { }
        protected virtual void SutunGizleGoster() { }
        protected virtual void RowCellAllowEdit() { }
        protected virtual void IptalEt() { }
        protected virtual void IptalGeriAl() { }
        protected virtual void TumunuSec() { }
        protected virtual void TumSecimleriKaldir() { }
        protected virtual void BelgeHareketleri() { }

        protected internal bool Kaydet()
        {
            insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
            var source = Tablo.DataController.ListSource;

            //durumu insert olan ve delete olmayan kayıtları getir.
            var insert = source.Cast<IBaseHareketEntity>().Where(x => x.Insert && !x.Delete).Cast<BaseHareketEntity>().ToList();
            //durumu update olan ve delete olmayan kayıtları getir.
            var update = source.Cast<IBaseHareketEntity>().Where(x => x.Update && !x.Delete).Cast<BaseHareketEntity>().ToList();
            //durumu delete olan ve insert olmayan kayıtları getir.
            var delete = source.Cast<IBaseHareketEntity>().Where(x => x.Delete && !x.Insert).Cast<BaseHareketEntity>().ToList();

            if (insert.Any())
            {
                if (!((IBaseHareketGenelBll)Bll).Insert(insert))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} tablosundaki hareketler eklenemedi.");
                    return false;
                }
            }

            if (update.Any())
            {
                if (!((IBaseHareketGenelBll)Bll).Update(update))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} tablosundaki hareketler güncellenemedi.");
                    return false;
                }
            }

            if (delete.Any())
            {
                if (!((IBaseHareketGenelBll)Bll).Delete(delete))
                {
                    Messages.HataMesaji($"{Tablo.ViewCaption} tablosundaki hareketler silinemedi.");
                    return false;
                }
            }

            ButtonEnabledDurumu(false);
            return true;
        }

        #endregion

        #region Events

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnHareketEkle)
            {
                HareketEkle();
            }
            else if (e.Item == btnHareketSil)
            {
                HareketSil();
            }
            else if (e.Item == btnKartDuzenle)
            {
                OpenEntity();
            }
            else if (e.Item == btnIptalEt)
            {
                IptalEt();
            }
            else if (e.Item == btnIptalGeriAl)
            {
                IptalGeriAl();
            }
            else if (e.Item == btnBelgeHareketleri)
            {
                BelgeHareketleri();
            }
            else if (e.Item == btnTumunuSec)
            {
                TumunuSec();
            }
            else if (e.Item == btnTumSecimleriKaldir)
            {
                TumSecimleriKaldir();
            }

            Cursor.Current = DefaultCursor;
        }

        protected virtual void ImageCombobox_SelectedValueChanged(object sender, EventArgs e) { }

        protected virtual void CheckEdit_CheckedChanged(object sender, EventArgs e) { }

        private void Navigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button == insUpNavigator.Navigator.Buttons.Append)
            {
                HareketEkle();
            }
            else if (e.Button == insUpNavigator.Navigator.Buttons.Remove)
            {
                HareketSil();
            }

            if (e.Button == insUpNavigator.Navigator.Buttons.Append || e.Button == insUpNavigator.Navigator.Buttons.Remove)
            {
                e.Handled = true;
            }
        }

        protected virtual void Tablo_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (!_isLoaded) return;

            var entity = Tablo.GetRow<IBaseHareketEntity>();
            if (!entity.Insert)
            {
                entity.Update = true;
            }

            ButtonEnabledDurumu(true);
        }

        protected virtual void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            if (popupMenu == null) return;
            if (e.Button != MouseButtons.Right) return;

            btnHareketSil.Enabled = Tablo.RowCount > 0;
            btnKartDuzenle.Enabled = Tablo.RowCount > 0;
            btnIptalEt.Enabled = Tablo.RowCount > 0;
            btnIptalGeriAl.Enabled = Tablo.RowCount > 0;

            e.SagMenuGoster(popupMenu);
        }

        private void Tablo_GotFocus(object sender, EventArgs e)
        {
            OwnerForm.statusBarKisaYol.Visibility = BarItemVisibility.Always;
            OwnerForm.statusBarKisaYolAciklama.Visibility = BarItemVisibility.Always;

            OwnerForm.statusBarAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarAciklama;
            OwnerForm.statusBarKisaYol.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYol;
            OwnerForm.statusBarKisaYolAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYolAciklama;
        }

        private void Tablo_LostFocus(object sender, EventArgs e)
        {
            OwnerForm.statusBarKisaYol.Visibility = BarItemVisibility.Never;
            OwnerForm.statusBarKisaYolAciklama.Visibility = BarItemVisibility.Never;
        }

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    if (Tablo.IsEditorFocused)
                    {
                        insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.CancelEdit);
                    }
                    else
                    {
                        OwnerForm.Close();
                    }
                    break;
                case Keys.Tab:
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    insUpNavigator.Navigator.Buttons.DoClick(insUpNavigator.Navigator.Buttons.EndEdit);
                    break;
                case Keys.Insert when e.Modifiers == Keys.Shift:
                    HareketEkle();
                    break;
                case Keys.Delete when e.Modifiers == Keys.Shift:
                    HareketSil();
                    break;
                case Keys.F3:
                    OpenEntity();
                    break;
                case Keys.T when e.Control:
                    IptalEt();
                    break;
                case Keys.R when e.Control:
                    IptalGeriAl();
                    break;
                case Keys.F6:
                    BelgeHareketleri();
                    break;
            }
        }

        protected virtual void Tablo_FocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e)
        {
            if (OwnerForm == null) return;

            OwnerForm.statusBarKisaYol.Visibility = BarItemVisibility.Never;
            OwnerForm.statusBarKisaYolAciklama.Visibility = BarItemVisibility.Never;

            if (!e.FocusedColumn.OptionsColumn.AllowEdit)
            {
                Tablo_GotFocus(sender, null);
            }
            else if (((IStatusBarKisaYol)e.FocusedColumn).StatusBarKisaYol != null)
            {
                OwnerForm.statusBarKisaYol.Visibility = BarItemVisibility.Always;
                OwnerForm.statusBarKisaYolAciklama.Visibility = BarItemVisibility.Always;

                OwnerForm.statusBarAciklama.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarAciklama;
                OwnerForm.statusBarKisaYol.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarKisaYol;
                OwnerForm.statusBarKisaYolAciklama.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarKisaYolAciklama;
            }
            else if (((IStatusBarKisaYol)e.FocusedColumn).StatusBarAciklama != null)
            {
                OwnerForm.statusBarAciklama.Caption = ((IStatusBarKisaYol)e.FocusedColumn).StatusBarAciklama;
            }
        }

        private void Tablo_SablonChanged(object sender, EventArgs e)
        {
            _tabloSablonKayitEdilecek = true;
            SablonKaydet();
        }

        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            OpenEntity();
        }

        protected virtual void Tablo_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            SutunGizleGoster();
            RowCellAllowEdit();
        }

        protected virtual void Tablo_RowCountChanged(object sender, EventArgs e) { }
        protected virtual void Tablo_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e) { }
        protected virtual void Tablo_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e) { }

        #endregion
    }
}