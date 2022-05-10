using Muhasebe.Common.Enums;
using Muhasebe.Data.Contexts;
using Muhasebe.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Muhasebe.Bll.Base
{
    public class BaseGenelBll<T> : BaseBll<T, MuhasebeContext> where T : BaseEntity
    {
        #region Variables

        private readonly KartTuru _kartTuru;

        #endregion

        public BaseGenelBll() { }

        //Buradaki Control tabloda bulunan text vb. araçların boş geçilme durumunu kontrol etmek için kullandık
        public BaseGenelBll(Control ctrl) : base(ctrl) { }

        #region Functions

        public BaseGenelBll(KartTuru kt)
        {
            _kartTuru = kt;
        }

        //Buradaki Control tabloda bulunan text vb. araçların boş geçilme durumunu kontrol etmek için kullandık
        public BaseGenelBll(Control ctrl, KartTuru kt) : base(ctrl)
        {
            _kartTuru = kt;
        }

        public virtual BaseEntity Single(Expression<Func<T, bool>> filter)
        {
            return BaseSingle(filter, x => x);
        }

        public virtual IEnumerable<BaseEntity> List(Expression<Func<T, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, x => x.Kod == entity.Kod);
        }

        public bool Insert(BaseEntity entity, Expression<Func<T, bool>> filter)
        {
            return BaseInsert(entity, filter);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity newEntity)
        {
            return BaseUpdate(oldEntity, newEntity, x => x.Kod == newEntity.Kod);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity newEntity, Expression<Func<T, bool>> filter)
        {
            return BaseUpdate(oldEntity, newEntity, filter);
        }

        public virtual bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, _kartTuru);
        }

        public string YeniKodVer()
        {
            //Database'deki tabloya git kod bölümünü çek ve ona göre yeni kod ver
            return BaseYeniKodVer(_kartTuru, x => x.Kod);
        }

        public string YeniKodVer(Expression<Func<T, bool>> filter)
        {
            //Database'deki tabloya git kod bölümünü çek ve ona göre yeni kod ver
            return BaseYeniKodVer(_kartTuru, x => x.Kod, filter);
        } 

        #endregion
    }
}