using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid;
using Muhasebe.Bll.Interfaces;
using Muhasebe.Common.Enums;
using Muhasebe.Common.Messages;
using Muhasebe.Model.Entities.Base;
using Muhasebe.Model.Entities.Base.Interfaces;
using Muhasebe.UI.Win.Functions;
using Muhasebe.UI.Win.Interfaces;
using Muhasebe.UI.Win.UserControls.Controls;
using Muhasebe.UI.Win.UserControls.Grids;
using System;
using System.Windows.Forms;

namespace Muhasebe.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        #region Variables

        private bool formSablonKayitEdilecek;
        protected MyDataLayoutControl DataLayoutControl;
        protected MyDataLayoutControl[] DataLayoutControls;
        protected IBaseBll Bll;
        protected KartTuru BaseKartTuru;
        protected BaseEntity OldEntity;
        protected BaseEntity NewEntity;
        protected bool IsLoaded;
        protected bool KayitSonrasiFormuKapat = true;
        protected bool FarkliDonemIslemi;
        protected bool KayitliMi;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        protected internal IslemTuru BaseIslemTuru;
        protected internal long Id;
        protected internal bool RefreshYapılacak;

        #endregion

        public BaseEditForm()
        {
            InitializeComponent();
        }

        #region Functions

        protected void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in ribbonControl.Items)
            {
                button.ItemClick += Button_ItemClick;
            }

            //Form Events
            LocationChanged += BaseEditForm_LocationChanged;
            SizeChanged += BaseEditForm_SizeChanged;
            Load += BaseEditForm_Load;
            FormClosing += BaseEditForm_FormClosing;
            Shown += BaseEditForm_Shown;

            void ControlEvents(Control control)
            {
                control.KeyDown += Control_KeyDown;
                control.GotFocus += Control_GotFocus;
                control.Leave += Control_Leave;
                control.Enter += Control_Enter;

                switch (control)
                {
                    case FilterControl edit:
                        edit.FilterChanged += Control_EditValueChanged;
                        break;
                    case ComboBoxEdit edit:
                        edit.EditValueChanged += Control_EditValueChanged;
                        edit.SelectedValueChanged += Control_SelectedValueChanged;
                        break;
                    case MyCalcEdit edit:
                        edit.LostFocus += Control_LostFocus;
                        edit.ValueChanged += Control_EditValueChanged;
                        break;
                    //Case sıralaması önemli
                    case MyButtonEdit edit:
                        edit.IdChanged += Control_IdChanged;
                        edit.EnabledChange += Control_EnabledChange;
                        edit.ButtonClick += Control_ButtonClick;
                        edit.DoubleClick += Control_DoubleClick;
                        break;
                    case BaseEdit edit:
                        edit.EditValueChanged += Control_EditValueChanged;
                        break;
                    case TabPane tab:
                        tab.SelectedPageChanged += Control_SelectedPageChanged;
                        break;
                    case PropertyGridControl propertyGrid:
                        propertyGrid.CellValueChanged += Control_CellValueChanged;
                        propertyGrid.FocusedRowChanged += Control_FocusedRowChanged;
                        break;
                    case MyGridControl grid:
                        grid.MainView.GotFocus += Control_GotFocus;
                        break;
                }
            }

            if (DataLayoutControls == null)
            {
                if (DataLayoutControl == null) return;

                foreach (Control ctrl in DataLayoutControl.Controls)
                {
                    ControlEvents(ctrl);
                }
            }
            else
            {
                foreach (var layout in DataLayoutControls)
                {
                    foreach (Control ctrl in layout.Controls)
                    {
                        ControlEvents(ctrl);
                    }
                }
            }
        }

        private bool Kaydet(bool kapanis)
        {
            bool KayitIslemi()
            {
                Cursor.Current = Cursors.WaitCursor;

                switch (BaseIslemTuru)
                {
                    case IslemTuru.EntityInsert:
                        if (EntityInsert())
                        {
                            return KayitSonrasiIslemleri();
                        }
                        break;

                    case IslemTuru.EntityUpdate:
                        if (EntityUpdate())
                        {
                            return KayitSonrasiIslemleri();
                        }
                        break;
                }

                bool KayitSonrasiIslemleri()
                {
                    OldEntity = NewEntity;
                    RefreshYapılacak = true;
                    ButtonEnabledDurumu();

                    if (KayitSonrasiFormuKapat)
                    {
                        Close();
                    }
                    else
                    {
                        BaseIslemTuru = BaseIslemTuru == IslemTuru.EntityInsert ? IslemTuru.EntityUpdate : BaseIslemTuru;
                    }
                    return true;
                }
                return false;
            }

            var result = kapanis ? Messages.KapanisMesaji() : Messages.KayitMesaji();

            switch (result)
            {
                case DialogResult.Yes:
                    return KayitIslemi();

                case DialogResult.No:
                    if (kapanis)
                    {
                        btnKaydet.Enabled = false;
                    }
                    return true;

                case DialogResult.Cancel:
                    return false;
            }
            return false;
        }

        private void FarkliKaydet()
        {
            if (Messages.EvetSeciliEvetHayir("Bu filtre referans alınarak yeni bir filtre oluşturulacaktır. Onaylıyor musunuz?", "Kayıt Onayı") != DialogResult.Yes) return;

            BaseIslemTuru = IslemTuru.EntityInsert;
            Yukle();

            if (Kaydet(true))
            {
                Close();
            }
        }

        private void ButtonGizleGoster()
        {
            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }

        private void Gerial()
        {
            if (Messages.HayirSeciliEvetHayir("Yapılan değişiklikler geri alınacaktır. Onaylıyor musunuz?", "Geri Al Onayı") != DialogResult.Yes) return;

            if (BaseIslemTuru == IslemTuru.EntityUpdate)
            {
                Yukle();
            }
            else
            {
                Close();
            }
        }

        private void SablonYukle()
        {
            Name.FormSablonYukle(this);
        }

        protected void SablonKaydet()
        {
            if (formSablonKayitEdilecek)
            {
                Name.FormSablonKaydet(Left, Top, Width, Height, WindowState);
            }
        }

        protected virtual void BaskiOnizleme() { }
        protected virtual void Yazdir() { }
        protected virtual bool EntityInsert()
        {
            return ((IBaseGenelBll)Bll).Insert(NewEntity);
        }

        protected virtual bool EntityUpdate()
        {
            return ((IBaseGenelBll)Bll).Update(OldEntity, NewEntity);
        }

        protected virtual void EntityDelete()
        {
            if (!((IBaseCommonBll)Bll).Delete(OldEntity)) return;

            RefreshYapılacak = true;
            Close();
        }

        protected virtual void SecimYap(object sender) { }
        protected virtual void FiltreUygula() { }
        protected virtual void TaksitOlustur() { }
        protected virtual void NesneyiKontrollereBagla() { }
        protected virtual void GuncelNesneOlustur() { }
        protected virtual void TabloYukle() { }
        public virtual void Yukle() { }
        public virtual void Giris() { }
        public virtual void SifreSifirla() { }
        protected internal virtual IBaseEntity ReturnEntity()
        {
            return null;
        }

        protected internal virtual void ButtonEnabledDurumu()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurumu(btnYeni, btnKaydet, btnGerial, btnSil, OldEntity, NewEntity);
        }

        #endregion

        #region Events

        protected virtual void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.Item == btnYeni)
            {
                //if (!BaseKartTuru.YetkiKontrolu(YetkiTuru.Ekleyebilir)) return;

                BaseIslemTuru = IslemTuru.EntityInsert;
                Yukle();
            }
            else if (e.Item == btnKaydet)
            {
                Kaydet(false);
            }
            else if (e.Item == btnFarkliKaydet)
            {
                //if (!BaseKartTuru.YetkiKontrolu(YetkiTuru.Ekleyebilir)) return;
                FarkliKaydet();
            }
            else if (e.Item == btnGerial)
            {
                Gerial();
            }
            else if (e.Item == btnSil)
            {
                //if (!BaseKartTuru.YetkiKontrolu(YetkiTuru.Silebilir)) return;
                EntityDelete();
            }
            else if (e.Item == btnUygula)
            {
                FiltreUygula();
            }
            else if (e.Item == btnTaksitOlustur)
            {
                TaksitOlustur();
            }
            else if (e.Item == btnYazdir)
            {
                Yazdir();
            }
            else if (e.Item == btnBaskiOnizleme)
            {
                BaskiOnizleme();
            }
            else if (e.Item == btnCikis)
            {
                Close();
            }
            else if (e.Item == btnSifreSifirla)
            {
                SifreSifirla();
            }
            else if (e.Item == btnGiris)
            {
                Giris();
            }

            Cursor.Current = DefaultCursor;
        }

        private void BaseEditForm_LocationChanged(object sender, EventArgs e)
        {
            formSablonKayitEdilecek = true;
        }

        private void BaseEditForm_SizeChanged(object sender, EventArgs e)
        {
            formSablonKayitEdilecek = true;
        }

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
            GuncelNesneOlustur();
            SablonYukle();
            ButtonGizleGoster();

            if (FarkliDonemIslemi)
            {
                Messages.UyariMesaji("İşlem yapılan kart çalışılan şube veya dönemde olmadığı için yapılan değişiklikler kayıt edilemez.");
            }
        }

        protected virtual void BaseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SablonKaydet();

            if (btnKaydet.Visibility == BarItemVisibility.Never || !btnKaydet.Enabled) return;

            if (!Kaydet(true))
            {
                e.Cancel = true;
            }
        }

        protected virtual void BaseEditForm_Shown(object sender, EventArgs e) { }
        protected virtual void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if (sender is MyButtonEdit edit)
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete when e.Control && e.Shift:
                        edit.Id = null;
                        edit.EditValue = null;
                        break;

                    case Keys.F4:
                    case Keys.Down when e.Modifiers == Keys.Alt:
                        SecimYap(edit);
                        break;
                }
            }
        }

        protected virtual void Control_GotFocus(object sender, EventArgs e)
        {
            var type = sender.GetType();

            if (type == typeof(MyButtonEdit) || type == typeof(MyGridView) || type == typeof(MyPictureEdit) || type == typeof(MyComboboxEdit) || type == typeof(MyDateEdit) || type == typeof(MyCalcEdit) || type == typeof(MyColorPickEdit))
            {
                statusBarKisaYol.Visibility = BarItemVisibility.Always;
                statusBarKisaYolAciklama.Visibility = BarItemVisibility.Always;

                statusBarAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarAciklama;
                statusBarKisaYol.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYol;
                statusBarKisaYolAciklama.Caption = ((IStatusBarKisaYol)sender).StatusBarKisaYolAciklama;
            }
            else if (sender is IStatusBarAciklama ctrl)
            {
                statusBarAciklama.Caption = ctrl.StatusBarAciklama;
            }
        }

        private void Control_Leave(object sender, EventArgs e)
        {
            statusBarKisaYol.Visibility = BarItemVisibility.Never;
            statusBarKisaYolAciklama.Visibility = BarItemVisibility.Never;
        }

        protected virtual void Control_Enter(object sender, EventArgs e) { }
        protected virtual void Control_EditValueChanged(object sender, EventArgs e)
        {
            if (!IsLoaded) return;

            GuncelNesneOlustur();
        }

        protected virtual void Control_SelectedValueChanged(object sender, EventArgs e) { }
        protected virtual void Control_IdChanged(object sender, IdChangedEventArgs e)
        {
            if (!IsLoaded) return;

            GuncelNesneOlustur();
        }

        protected virtual void Control_EnabledChange(object sender, EventArgs e) { }
        private void Control_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SecimYap(sender);
        }

        private void Control_DoubleClick(object sender, EventArgs e)
        {
            SecimYap(sender);
        }

        protected virtual void Control_LostFocus(object sender, EventArgs e) { }
        protected virtual void Control_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e) { }
        protected virtual void Control_CellValueChanged(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e) { }
        protected virtual void Control_FocusedRowChanged(object sender, DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventArgs e) { }

        #endregion
    }
}