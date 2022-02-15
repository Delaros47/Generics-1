using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utilities utilities = new Utilities();
            IList<string> result = utilities.BuildList<string>("Ankara", "Izmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName="Ahmet"},new Customer { FirstName="Murat"});

            foreach (var item in result2)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Customer
    {
        public string FirstName { get; set; }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
}
