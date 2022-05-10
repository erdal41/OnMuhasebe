using Muhasebe.Model.Entities.Base;

namespace Muhasebe.Bll.Interfaces
{
    public interface IBaseGenelBll
    {
        bool Insert(BaseEntity entity);
        bool Update(BaseEntity oldEntity, BaseEntity newEntity);
        string YeniKodVer();
    }
}