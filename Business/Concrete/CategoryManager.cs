using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IDataResult<List<Category>> GetAll()
        {
            // Business Code
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            // Business Code
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }
    }
}
