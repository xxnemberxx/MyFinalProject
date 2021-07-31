using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    // Data Access Layer (DAL), Data Access Object (DAO)
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}

// Code Refactoring