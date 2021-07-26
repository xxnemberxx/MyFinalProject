using System;
using Business.Concrete;
using DataAccess.Concrete.EntıtyFramework;

namespace ConsoleUI
{
    class Program
    {
        // SOLID
        // Open Closed Principle
        // Yaptığın yazılıma yeni bir özellik ekliyorsan, mevcuttaki hiçbir koduna dokunamazsın.
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var c in categoryManager.GetAll())
            {
                Console.WriteLine($"{c.CategoryName}");
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var i in productManager.GetAllByCategory(5))
            {
                Console.WriteLine($"{i.CategoryId}, {i.ProductId}, {i.ProductName}, {i.UnitPrice}$, {i.UnitsInStock}");
            }
        }
    }
}
