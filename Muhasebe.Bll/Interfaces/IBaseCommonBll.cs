using Muhasebe.Model.Entities.Base;

namespace Muhasebe.Bll.Interfaces
{
    public interface IBaseCommonBll
    {
        bool Delete(BaseEntity entity);
    }
}