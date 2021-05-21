using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class CustomerManager
    {
        private static List<Customer> _customers;

        public CustomerManager()
        {
            _customers = new List<Customer>();
        }

        public void Add(Customer customer)
        {
            _customers.Add(customer);
            Console.WriteLine("Customer Added");
        }

        public List<Customer> List()
        {
            return _customers.ToList();
        }

        public void Delete(Customer customer)
        {
            _customers.Remove(customer);
            Console.WriteLine("Customer deleted");
        }
    }
}
