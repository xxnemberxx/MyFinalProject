using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        private List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product { CategoryId = 1, ProductId = 1, ProductName = "cup", UnitPrice = 15, UnitsInStock = 100},
                new Product { CategoryId = 2, ProductId = 2, ProductName = "phone", UnitPrice = 1500, UnitsInStock = 38},
                new Product { CategoryId = 3, ProductId = 3, ProductName = "Camera", UnitPrice = 500, UnitsInStock = 4},
                new Product { CategoryId = 4, ProductId = 4, ProductName = "Mouse", UnitPrice = 59.99M, UnitsInStock = 26},
                new Product { CategoryId = 5, ProductId = 5, ProductName = "Keyboard", UnitPrice = 150, UnitsInStock = 50},
            };
        }
        public InMemoryProductDal(List<Product> products)
        {
            _products = products;
        }
        public void Add(List<Product> products)
        {
            _products.AddRange(products);
        }

        public void Delete(List<Product> products)
        {
            _products.RemoveAll(p => products.Any(pr => pr.ProductId == p.ProductId));
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        //public List<Product> GetAllByCategory(int CategoryId)
        //{
        //    return _products.Where(p => p.CategoryId == CategoryId).ToList();
        //}

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
