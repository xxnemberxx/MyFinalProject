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
            ProductManager productManager = new ProductManager(new EfProductDal());
            Console.WriteLine("[CategoryId, ProductId, ProductName, UnitPrice, UnitInStock]");
            Console.WriteLine("\n  [Ürün Liste]");
            foreach (var i in productManager.GetAllByCategory(5))
            {
                Console.WriteLine($"{i.CategoryId}, {i.ProductId}, {i.ProductName}, {i.UnitPrice}$, {i.UnitsInStock}");
            }                

            Console.ReadLine();
        }

    }
}
