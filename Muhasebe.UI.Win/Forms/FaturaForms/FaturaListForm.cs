using DevExpress.XtraGrid.Views.Grid;
using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.Common.Messages;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Forms.GeneralForms;
using Muhasebe.UI.Win.Functions;
using Muhasebe.UI.Win.Show;
using System.Drawing;
using System.Windows.Forms;

namespace Muhasebe.UI.Win.Forms.FaturaForms
{
    public partial class FaturaListForm : BaseListForm
    {
        public FaturaListForm()
        {
            InitializeComponent();
            Bll = new FaturaBll();
        }

        #region Functions

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Fatura;
            FormShow = new ShowEditForms<FaturaEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((FaturaBll)Bll).List(null);
        }

        protected override void EntityDelete()
        {
            if (Messages.HayirSeciliEvetHayir("Seçili olan 'Fatura' ve faturanın bağlı olduğu tüm 'Stok Bilgileri' ve 'Cari Hesap Hareketleri' silinecektir. Onaylıyor musunuz?", "Silme Onayı") != DialogResult.Yes) return;
            base.EntityDelete();
        } 

        #endregion

        #region Events

        protected override void Tablo_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName != "Iskonto") return;
            e.Appearance.BackColor = Color.FromArgb(240, 240, 240);
            e.Appearance.FillRectangle(e.Cache, e.Bounds);
            e.Info.AllowDrawBackground = false;
        } 

        #endregion
    }
}