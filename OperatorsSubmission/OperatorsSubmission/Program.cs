using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.FirstName = "Victoria";
            employee1.LastName = "Ransom";
            employee1.ID = 1;
            employees.Add(employee1);

            Employee employee2 = new Employee();
            employee1.FirstName = "John";
            employee1.LastName = "Smith";
            employee1.ID = 2;
            employees.Add(employee2);

            Console.WriteLine(employee1 == employee2);
            Console.ReadLine();
        }
    }
}
