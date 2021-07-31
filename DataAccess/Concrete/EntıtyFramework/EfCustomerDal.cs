using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Concrete.EntıtyFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, NorthwindContext>, ICustomerDal
    {
    }
}
