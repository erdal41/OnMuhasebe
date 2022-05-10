using Muhasebe.Model.Entities.Base;
using System.Collections.Generic;

namespace Muhasebe.Bll.Interfaces
{
    public interface IBaseHareketGenelBll
    {
        bool Insert(IList<BaseHareketEntity> entities);
        bool Update(IList<BaseHareketEntity> entities);
        bool Delete(IList<BaseHareketEntity> entities);
    }
}