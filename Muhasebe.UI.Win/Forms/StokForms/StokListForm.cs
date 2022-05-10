using Muhasebe.Bll.General;
using Muhasebe.Common.Enums;
using Muhasebe.Common.Messages;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Show;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Muhasebe.UI.Win.Forms.StokForms
{
    public partial class StokListForm : BaseListForm
    {

        #region Variables

        private readonly Expression<Func<Stok, bool>> _filter;

        #endregion

        public StokListForm()
        {
            InitializeComponent();
            Bll = new StokBll();
            _filter = x => x.Durum == AktifKartlariGoster;
        }

        public StokListForm(params object[] prm) : this()
        {
            _filter = x => !ListeDisiTutulacakKayitlar.Contains(x.Id) && x.Durum == AktifKartlariGoster;
        }

        #region Functions

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            BaseKartTuru = KartTuru.Stok;
            FormShow = new ShowEditForms<StokEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            var list = ((StokBll)Bll).List(_filter);
            Tablo.GridControl.DataSource = list;

            if (!MultiSelect) return;
            if (list.Any())  //list te değer veya kayıt var ise
            {
                EklenebilecekEntityVar = true;
            }
            else
            {
                Messages.KartBulunamadiMesaji("Kart");
            }
        } 

        #endregion
    }
}