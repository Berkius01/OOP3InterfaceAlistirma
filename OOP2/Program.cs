using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer realCustomer = new RealCustomer();
            realCustomer.Id = 1;
            realCustomer.CustomerNo = "1517";
            realCustomer.Name = "berk";
            realCustomer.SurName = "sağlıcak";
            realCustomer.TCNo = "2222222";


            LegalCustomer legalCustomer = new LegalCustomer();
            legalCustomer.Id = 1;
            legalCustomer.CustomerNo = "54321";
            legalCustomer.CompanyName = "cbr";
            legalCustomer.TaxNo = "4545";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(legalCustomer);

            customerManager.Add(realCustomer);

        }
    }
}
