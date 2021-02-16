using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Metot_Demo
{
    class Customer_Manager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " kişisi sisteme EKLENDİ.");
        }
        public void Cancelled(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " kişisi sistemden ÇIKARTILDI.");
        }
    }
}
