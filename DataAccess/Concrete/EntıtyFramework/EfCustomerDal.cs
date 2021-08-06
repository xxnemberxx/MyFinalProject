using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntıtyFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, NorthwindContext>, ICustomerDal
    {
        public List<CustomerOrdersDto> GetCustomerOrders()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from c in context.Customers
                             join o in context.Orders
                             on c.CustomerId equals o.CustomerId
                             select new CustomerOrdersDto
                             {
                                 CustomerId = c.CustomerId,
                                 OrderId = o.OrderId,
                                 CustomerName = c.CompanyName, 
                                 OrderDate = o.OrderDate,
                                 City = c.City,                                 
                             };

                return result.ToList();
            }
        }
    }
}
