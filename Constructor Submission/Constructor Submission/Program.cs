using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Victoria");
            const string Hotel = "Hilton";
            Console.WriteLine("Welcome to the {0} Hotel, {1} {2}", Hotel, person.FirstName, person.LastName);
            Console.ReadLine();
        }
    }
}
