using System;

namespace Class_Metot_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 12412412;
            customer1.Name = "Ali";
            customer1.Surname = "Alioğlu";
            customer1.Age = 42;
            customer1.Working_Status = true;

            Customer customer2 = new Customer();
            customer2.Id = 89173459;
            customer2.Name = "Veli";
            customer2.Surname = "Velioğlu";
            customer2.Age = 37;
            customer2.Working_Status = true;

            Customer customer3 = new Customer();
            customer3.Id = 123412475;
            customer3.Name = "Ahmet";
            customer3.Surname = "Ahmetoğlu";
            customer3.Age = 26;
            customer3.Working_Status = false;

            Console.WriteLine("<<<< Kişi Listesi >>>>");
            Console.WriteLine(" ");

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.Age);
                Console.WriteLine(customer.Working_Status);
                Console.WriteLine(" ");
            }

            Console.WriteLine("<<<< Kişi Durumu >>>>");
            Console.WriteLine(" ");

            Customer_Manager customer_manager = new Customer_Manager();
            customer_manager.Add(customer1);

            customer_manager.Cancelled(customer3);
        }
    }
}
