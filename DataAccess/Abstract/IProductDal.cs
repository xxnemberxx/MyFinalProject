using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    // Data Access Layer (DAL), Data Access Object (DAO)
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
