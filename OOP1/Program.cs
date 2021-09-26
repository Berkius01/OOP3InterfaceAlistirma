using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Productü product1 = new Productü();
            product1.Id = 1;
            product1.CategorId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Productü product2 = new Productü() { Id = 2, CategorId = 5, UnitsInStock = 5,
                UnitPrice = 10, ProductName = "kalem" };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
