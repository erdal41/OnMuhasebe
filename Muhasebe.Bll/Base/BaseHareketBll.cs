using Muhasebe.Bll.Functions;
using Muhasebe.Bll.Interfaces;
using Muhasebe.Dal.Interfaces;
using Muhasebe.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Muhasebe.Bll.Base
{
    public class BaseHareketBll<T, TContext> : IBaseBll, IBaseHareketGenelBll where T : BaseHareketEntity where TContext : DbContext
    {
        #region  Variables

        private IUnitOfWork<T> _unitOfWork;

        #endregion

        #region Functions 

        protected IQueryable<TResult> List<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Select(filter, selector);
        }

        public virtual bool Insert(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);

            _unitOfWork.Rep.Insert(entities.EntityListConvert<T>());
            return _unitOfWork.Save();
        }

        public virtual bool Update(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);

            _unitOfWork.Rep.Update(entities.EntityListConvert<T>());
            return _unitOfWork.Save();
        }

        public bool Delete(IList<BaseHareketEntity> entities)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);

            _unitOfWork.Rep.Delete(entities.EntityListConvert<T>());
            return _unitOfWork.Save();
        } 

        #endregion

        #region Dispose

        public void Dispose()
        {
            _unitOfWork?.Dispose();
        }

        #endregion
    }
}