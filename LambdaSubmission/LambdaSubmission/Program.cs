using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
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
            employee2.FirstName = "Joe";
            employee2.LastName = "Smith";
            employee2.ID = 2;
            employees.Add(employee2);

            Employee employee3 = new Employee();
            employee3.FirstName = "Joe";
            employee3.LastName = "Rodgers";
            employee3.ID = 3;
            employees.Add(employee3);

            Employee employee4 = new Employee();
            employee4.FirstName = "Kyleigh";
            employee4.LastName = "Westgarth";
            employee4.ID = 4;
            employees.Add(employee4);

            Employee employee5 = new Employee();
            employee5.FirstName = "Kalina";
            employee5.LastName = "Lalova";
            employee5.ID = 5;
            employees.Add(employee5);

            Employee employee6 = new Employee();
            employee6.FirstName = "Lizzy";
            employee6.LastName = "Mondani";
            employee6.ID = 6;
            employees.Add(employee6);

            Employee employee7 = new Employee();
            employee7.FirstName = "Nick";
            employee7.LastName = "Soto";
            employee7.ID = 7;
            employees.Add(employee7);

            Employee employee8 = new Employee();
            employee8.FirstName = "Katie";
            employee8.LastName = "Eidam";
            employee8.ID = 8;
            employees.Add(employee8);

            Employee employee9 = new Employee();
            employee9.FirstName = "Waleed";
            employee9.LastName = "Noury";
            employee9.ID = 9;
            employees.Add(employee9);

            Employee employee10 = new Employee();
            employee10.FirstName = "Bill";
            employee10.LastName = "Trees";
            employee10.ID = 10;
            employees.Add(employee10);

            List<Employee> joeList = new List<Employee>();
            foreach (Employee joe in employees)
            {
                if (joe.FirstName == "Joe")
                {
                    joeList.Add(joe);
                }
            }

            foreach (Employee Joe in joeList)
            {
                Console.WriteLine(Joe.FirstName + " " + Joe.LastName);
                Console.ReadLine();
            }

            List<Employee> employees2 = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee joe2 in employees2)
            {
                Console.WriteLine(joe2.FirstName + " " + joe2.LastName);
                Console.ReadLine();
            }

            List<Employee> greaterthan5 = employees.Where(x => x.ID > 5).ToList();
            foreach (Employee greater in greaterthan5)
            {
                Console.WriteLine(greater.FirstName + " " + greater.LastName);
                Console.ReadLine();
            }
        }
    }
}
