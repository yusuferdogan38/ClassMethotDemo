using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethotDemo
{
    internal class CustomerManager
    {

        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.CustomerName +customer.CustomerSurname+ "eklendi");
        }

        public  void RemoveCustomer(Customer customer)
        {
            Console.WriteLine( customer.Id + customer.CustomerName + customer.CustomerSurname, "silindi");

        }


        public void ListCustomer(Customer customer) {

            Console.WriteLine( "Listelendi "+customer.Id +"  "+customer.CustomerName);
        }


        
    
    
    
    
    }
}
