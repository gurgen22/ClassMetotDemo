using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 12345678;
            customer1.Name = "Ahmet";
            customer1.Surname = "YILDIZ";

            Customer customer2 = new Customer();
            customer2.Id = 12345687;
            customer2.Name = "Buse";
            customer2.Surname = "YILDIZ";

            Customer[] customers = new Customer[] { customer1, customer2 };

            foreach (var c in customers)
            {
                Console.WriteLine(c.Id);
                Console.WriteLine(c.Name);
                Console.WriteLine(c.Surname);
            }


            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);

            customerManager.DeleteCustomer(customer1);
            customerManager.DeleteCustomer(customer2);

            customerManager.ListCustomer(customer1);
            customerManager.ListCustomer(customer2);
        }
    }
}
