using Muhasebe.Bll.Functions;
using Muhasebe.Bll.Interfaces;
using Muhasebe.Common.Enums;
using Muhasebe.Common.Functions;
using Muhasebe.Common.Messages;
using Muhasebe.Dal.Interfaces;
using Muhasebe.Model.Attributes;
using Muhasebe.Model.Entities.Base;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Muhasebe.Bll.Base
{
    public class BaseBll<T, TContext> : IBaseBll where T : BaseEntity where TContext: DbContext
    {
        #region  Variables

        private readonly Control _ctrl;
        private IUnitOfWork<T> _unitOfWork;

        #endregion

        protected BaseBll() { }

        protected BaseBll(Control ctrl)
        {
            _ctrl = ctrl;
        }

        #region Functions

        private bool Validation(IslemTuru islemTuru, BaseEntity oldEntity, BaseEntity newEntity, Expression<Func<T, bool>> filter)
        {
            var errorControl = GetValidationErrorControl();

            if (errorControl == null) return true;

            _ctrl.Controls[errorControl].Focus();

            return false;

            string GetValidationErrorControl()
            {
                string MukerrerKod()
                {
                    foreach (var property in typeof(T).GetPropertyAttributesFromType<Kod>())
                    {
                        if (property.Attribute == null) continue;
                        if ((islemTuru == IslemTuru.EntityInsert || oldEntity.Kod == newEntity.Kod) && islemTuru == IslemTuru.EntityUpdate) continue;
                        if (_unitOfWork.Rep.Count(filter) < 1) continue;

                        Messages.MukerrerKayitHataMesaji(property.Attribute.Description);

                        return property.Attribute.ControlName;
                    }
                    return null;
                }

                string HataliGiris()
                {
                    foreach (var property in typeof(T).GetPropertyAttributesFromType<ZorunluAlan>())
                    {
                        if (property.Attribute == null) continue;

                        var value = property.Property.GetValue(newEntity);

                        if (property.Property.PropertyType == typeof(long))
                        {
                            if ((long)value == 0)
                            {
                                value = null;
                            }
                        }

                        if (!string.IsNullOrEmpty(value?.ToString())) continue;

                        Messages.HataliVeriMesaji(property.Attribute.Description);

                        return property.Attribute.ControlName;
                    }
                    return null;
                }
                return HataliGiris() ?? MukerrerKod();
            }
        }

        protected TResult BaseSingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Find(filter, selector);
        }

        protected IQueryable<TResult> BaseList<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Select(filter, selector);
        }

        protected bool BaseInsert(BaseEntity entity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);

            if (!Validation(IslemTuru.EntityInsert, null, entity, filter)) return false;

            _unitOfWork.Rep.Insert(entity.EntityConvert<T>());
            return _unitOfWork.Save();
        }

        protected bool BaseUpdate(BaseEntity oldEntity, BaseEntity newEntity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);

            if (!Validation(IslemTuru.EntityUpdate, oldEntity, newEntity, filter)) return false;

            var degisenAlanlar = oldEntity.DegisenAlanlariGetir(newEntity);

            if (degisenAlanlar.Count == 0) return true;

            _unitOfWork.Rep.Update(newEntity.EntityConvert<T>(), degisenAlanlar);
            return _unitOfWork.Save();
        }

        protected bool BaseDelete(BaseEntity entity, KartTuru kartTuru, bool mesajVer = true)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);

            if (mesajVer)
                if (Messages.SilmeMesaji(kartTuru.ToName()) != DialogResult.Yes) return false;

            _unitOfWork.Rep.Delete(entity.EntityConvert<T>());
            return _unitOfWork.Save();
        }

        protected string BaseYeniKodVer(KartTuru kartTuru, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.YeniKodVer(kartTuru, filter, where);
        } 

        #endregion

        #region Dispose

        public void Dispose()
        {
            _ctrl?.Dispose();
            _unitOfWork?.Dispose();
        }

        #endregion
    }
}