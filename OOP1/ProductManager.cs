using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Productü product) 
        {
            Console.WriteLine(product.ProductName+" eklendi.");
        }

        public void Update(Productü product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

    }
}
