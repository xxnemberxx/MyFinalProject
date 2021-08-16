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
            Console.WriteLine("Merhaba");
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var c in categoryManager.GetAll().Data)
            {
                Console.WriteLine($"{c.CategoryName}");
            }
        }

    }
}
