using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntıtyFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        public void Add(List<Category> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<Category> entities)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entityId)
        {
            throw new NotImplementedException();
        }
    }
}
