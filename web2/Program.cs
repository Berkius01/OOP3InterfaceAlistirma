using System;

namespace web2
{
    class Program
    {
        static void Main(string[] args)
        {
            product product1 = new product();
            product product2 = new product();
            product product3 = new product();

            product1.Adi = "elma";
            product1.açıklama = "güzel";
            product1.Id = 1;
            product1.fiyat = 5;


            product2.Adi = "çilek";
            product2.açıklama = "kırmızı";
            product2.Id = 2;
            product2.fiyat = 6;

            product3.Adi = "armut";
            product3.açıklama = "sarı";
            product3.Id = 3;
            product3.fiyat = 4;
            sepetManager sepet = new sepetManager();

            product[] dizi = new product[] {product1,product2,product3 };


            foreach (product item in dizi){
                Console.WriteLine(item.Adi);
                sepet.Ekle(item);
            }

            
            
            

        }
    }
}
