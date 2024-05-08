using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer customer1  = new Customer();
            customer1.Id = 1;
            customer1.CustomerName = "ahmet";
            customer1.CustomerSurname = "kılıç";
            customer1.Eposta = "ahmet@gmail.com";

            Customer customer2 = new Customer();
            customer1.Id = 2;
            customer1.CustomerName = "mehmet";
            customer1.CustomerSurname = "taş";
            customer1.Eposta = "mehmet@gmail.com";

            Customer customer3 = new Customer();
            customer1.Id = 3;
            customer1.CustomerName = "fatma";
            customer1.CustomerSurname = "demir";
            customer1.Eposta = "fatma@gmail.com";

            Customer[] customers =new Customer[] {customer1, customer2, customer3};

            foreach (var customer in customers)
            {
                Console.WriteLine("dizideye eklendi " +customer.CustomerName );
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.ListCustomer(customer1);
            customerManager.RemoveCustomer(customer1);

            customerManager.AddCustomer(customer2);
            customerManager.ListCustomer(customer2);
            customerManager.RemoveCustomer(customer2);

            customerManager.AddCustomer(customer3);
            customerManager.ListCustomer(customer3);
            customerManager.RemoveCustomer(customer3);

              


            Console.ReadLine();
        }

        

    }
}
