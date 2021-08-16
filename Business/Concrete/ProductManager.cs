﻿using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private ICategoryService _categoryService;
        public ProductManager(IProductDal productDal, ICategoryService categoryService)
        {
            _productDal = productDal;
            _categoryService = categoryService;
        }

        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            IResult result = BusinessRules.Run(
                CheckIfProductCountCategoryCorrect(product.CategoryId),
                CheckIfProductNameAlreadyExists(product.ProductName)
                );

            if(result != null)
            {
                return result;
            }

            _productDal.Add(product);

            return new SuccessResult();
        }
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Update(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult();
        }
        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategory(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal
                .GetAll(p => p.CategoryId == id), Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetByBetweenTwoUnitPrice(int min, int max)
        {
            return new SuccessDataResult<List<Product>>(_productDal
                .GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max), Messages.ProductsListed);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }
        // -- Business Rules
        private IResult CheckIfProductNameAlreadyExists(string productName)
        {
            var result = _productDal.GetAll(p => p.ProductName == productName).Count;
            if (result != 0)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);
            }

            return new SuccessResult();
        }
        private IResult CheckIfProductCountCategoryCorrect(int CategoryId)
        {
            var result = _productDal.GetAll(p => p.CategoryId == CategoryId).Count;
            if (result != 0)
            {
                return new SuccessResult();
            }

            return new ErrorResult(Messages.ProductCountOfCategoryError);
        }
    }
}
