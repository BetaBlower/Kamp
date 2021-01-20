using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 750;
            product1.UnitsInStock = 10;

            Product product2 = new Product { ID = 2, CategoryId = 3, UnitsInStock = 1000, ProductName = "kalem", UnitPrice = 1 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
