using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("New customer is Id: "+customer.Id);
            Console.WriteLine("New customer is name: "+customer.Name);
            Console.WriteLine("New customer is surname: "+customer.Surname);

        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Delete customer is Id: "+customer.Id);
            Console.WriteLine("Delete customer is name: "+customer.Name);
            Console.WriteLine("Delete customer is surname: "+customer.Surname);
        }
        public void ListCustomer(Customer customer)
        {
            Console.WriteLine(customer.Id+" "+customer.Name+" "+customer.Surname);
        }

    }
}
