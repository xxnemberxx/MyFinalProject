using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete; 

namespace DataAccess.Concrete.EntıtyFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, NorthwindContext>, IOrderDal
    {
    }
}
