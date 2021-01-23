using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 600, UnitsInStock = 4 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            productManager.Topla2(3,6);

            int toplamaSonucu = productManager.Topla(2, 3);
            Console.WriteLine(toplamaSonucu*2);


        }   
    }
}
