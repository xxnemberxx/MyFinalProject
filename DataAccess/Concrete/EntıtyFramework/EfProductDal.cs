using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntıtyFramework
{
    //NuGet
    public class EfProductDal : IProductDal
    {
        public void Add(List<Product> entities)
        {
            // Garbage Collecter, using bitince çalışır
            // IDisposable pattern implementation of c# 
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entities); // referansını getir
                addedEntity.State = EntityState.Added; // ekleme işlemi olacak
                context.SaveChanges(); // İşlemleri gerçekleştir
            }
        }

        public void Delete(List<Product> entities)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entities); // referansını getir
                deletedEntity.State = EntityState.Deleted; // Silme işlemi olacak
                context.SaveChanges(); // İşlemleri gerçekleştir
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return (filter == null)
                    ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity); // referansını getir
                updatedEntity.State = EntityState.Modified; // Güncelleme işlemi olacak
                context.SaveChanges(); // İşlemleri gerçekleştir
            }
        }
    }
}
