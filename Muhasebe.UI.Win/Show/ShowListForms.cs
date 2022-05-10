﻿using Muhasebe.Common.Enums;
using Muhasebe.Model.Entities.Base;
using Muhasebe.Model.Entities.Base.Interfaces;
using Muhasebe.UI.Win.Forms.BaseForms;
using Muhasebe.UI.Win.Functions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Win.Show
{
    public class ShowListForms<TForm> where TForm : BaseListForm
    {
        //Buradaki kartturu gonderimi yetki kontrolu için
        public static void ShowListForm(KartTuru kartTuru)
        {
            //if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return;

            var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;
            frm.Yukle();
            frm.Show();
        }

        public static void ShowListForm(KartTuru kartTuru, long? seciliGelecekId, params object[] prm)
        {
            //if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return;

            var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm);
            frm.SeciliGelecekId = seciliGelecekId;
            frm.MdiParent = Form.ActiveForm;
            frm.Yukle();
            frm.Show();
        }

        public static BaseEntity ShowDialogListForm(KartTuru kartTuru, params object[] prm)
        {
            //if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return null;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.Yukle();

                if (!frm.IsDisposed)
                {
                    frm.ShowDialog();
                }

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntity : null;
            }
        }

        public static BaseEntity ShowDialogListForm(KartTuru kartTuru, long? seciliGelecekId, params object[] prm)
        {
            //if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return null;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.SeciliGelecekId = seciliGelecekId;
                frm.Yukle();

                if (!frm.IsDisposed)
                {
                    frm.ShowDialog();
                }

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntity : null;
            }
        }

        public static void ShowDialogListForm()
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.AktifPasifButtonGoster = true;
                frm.Yukle();
                frm.ShowDialog();
            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru, IList<long> listeDisiTutulacakKayitlar, bool multiselect, params object[] prm)
        {
            //if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return null;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
                frm.MultiSelect = multiselect;
                frm.Yukle();
                frm.RowSelect = new SelectRowFunctions(frm.Tablo);

                if (frm.EklenebilecekEntityVar)
                {
                    frm.ShowDialog();
                }

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogListForm(IList<long> listeDisiTutulacakKayitlar, bool multiselect, params object[] prm)
        {
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.ListeDisiTutulacakKayitlar = listeDisiTutulacakKayitlar;
                frm.MultiSelect = multiselect;
                frm.Yukle();
                frm.RowSelect = new SelectRowFunctions(frm.Tablo);

                if (frm.EklenebilecekEntityVar)
                {
                    frm.ShowDialog();
                }

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }
        }

        public static IEnumerable<IBaseEntity> ShowDialogListForm(KartTuru kartTuru, bool multiselect, params object[] prm)
        {
            //if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return null;

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm), prm))
            {
                frm.MultiSelect = multiselect;
                frm.Yukle();
                frm.RowSelect = new SelectRowFunctions(frm.Tablo);
                frm.ShowDialog();

                return frm.DialogResult == DialogResult.OK ? frm.SelectedEntities : null;
            }
        }
    }
}
