using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "mustafa";
            customer.Surname = "güler";

            manager.Add(customer);

            manager.List();

            Console.ReadLine();
        }

    }
}