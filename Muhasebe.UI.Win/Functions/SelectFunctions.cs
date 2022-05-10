using Muhasebe.Common.Enums;
using Muhasebe.Model.Dto;
using Muhasebe.Model.Entities;
using Muhasebe.UI.Win.Forms.BirimForms;
using Muhasebe.UI.Win.Forms.CariForms;
using Muhasebe.UI.Win.Forms.IlceForms;
using Muhasebe.UI.Win.Forms.IlForms;
using Muhasebe.UI.Win.Forms.OzelKodForms;
using Muhasebe.UI.Win.Forms.UlkeForms;
using Muhasebe.UI.Win.UserControls.Controls;
using OgrenciTakip.UI.Win.Show;
using System;

namespace Muhasebe.UI.Win.Functions
{
    public class SelectFunctions : IDisposable
    {
        #region Variables

        private MyButtonEdit _btnEdit;
        private MyButtonEdit _prmEdit;
        private KartTuru _kartTuru;
        private MyTextEdit _cariAdi;
        private MyTextEdit _vergiDairesi;
        private MyTextEdit _vergiNo;
        private MyMemoEdit _adres;

        #endregion

        #region Functions

        public void Sec(MyButtonEdit btnEdit)
        {
            _btnEdit = btnEdit;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, KartTuru kartTuru)
        {
            _btnEdit = btnEdit;
            _kartTuru = kartTuru;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, MyButtonEdit prmEdit)
        {
            _btnEdit = btnEdit;
            _prmEdit = prmEdit;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, MyTextEdit cariAdi, MyTextEdit vergiDairesi, MyTextEdit vergiNo, MyMemoEdit Adres)
        {
            _btnEdit = btnEdit;
            _cariAdi = cariAdi;
            _vergiDairesi = vergiDairesi;
            _vergiNo = vergiNo;
            _adres = Adres;
            SecimYap();
        }

        public void Sec(MyButtonEdit btnEdit, MyTextEdit cariAdi)
        {
            _btnEdit = btnEdit;
            _cariAdi = cariAdi;
            SecimYap();
        }

        private void SecimYap()
        {
            switch (_btnEdit.Name)
            {
                case "txtUlke":
                    {
                        var entity = (Ulke)ShowListForms<UlkeListForm>.ShowDialogListForm(KartTuru.Ulke, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.UlkeAdi;
                        }
                    }
                    break;
                case "txtIl":
                    {
                        var entity = (Il)ShowListForms<IlListForm>.ShowDialogListForm(KartTuru.Il, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlAdi;
                        }
                    }
                    break;
                case "txtIlce":
                    {
                        var entity = (Ilce)ShowListForms<IlceListForm>.ShowDialogListForm(KartTuru.Ilce, _btnEdit.Id, _prmEdit.Id, _prmEdit.Text);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.IlceAdi;
                        }
                    }
                    break;
                case "txtOzelKod1":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod1, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;
                case "txtOzelKod2":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod2, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;
                case "txtOzelKod3":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod3, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;
                case "txtOzelKod4":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod4, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;
                case "txtOzelKod5":
                    {
                        var entity = (OzelKod)ShowListForms<OzelKodListForm>.ShowDialogListForm(KartTuru.OzelKod, _btnEdit.Id, OzelKodTuru.OzelKod5, _kartTuru);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.OzelKodAdi;
                        }
                    }
                    break;
                case "txtBirim":
                    {
                        var entity = (Birim)ShowListForms<BirimListForm>.ShowDialogListForm(KartTuru.Birim, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.BirimAdi;
                        }
                    }
                    break;
                case "txtCari":
                    {
                        var entity = (CariList)ShowListForms<CariListForm>.ShowDialogListForm(KartTuru.Cari, _btnEdit.Id, _cariAdi, _vergiDairesi, _vergiNo, _adres);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.Kod;
                            _cariAdi.Text = entity.CariAdi;
                            _vergiDairesi.Text = entity.VergiDairesi;
                            _vergiNo.Text = entity.VergiNo;
                            _adres.Text = entity.Adres;
                        }
                    }
                    break;
                case "txtHesapKodu":
                    {
                        var entity = (CariList)ShowListForms<CariListForm>.ShowDialogListForm(KartTuru.Cari, _btnEdit.Id, _cariAdi);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.Kod;
                            _cariAdi.Text = entity.CariAdi;
                        }
                    }
                    break;
            }
        }

        #endregion

        #region Dispose

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        } 

        #endregion
    }
}