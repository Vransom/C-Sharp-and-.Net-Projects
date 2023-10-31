using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //prints title
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string Rate1 = Console.ReadLine();
            int HourlyRate1 = Convert.ToInt32(Rate1); //inserts person 1 hourly rate and converts to string
            Console.WriteLine("Hours Worked Per Week?");
            string Hours1 = Console.ReadLine();
            int PerWeek1 = Convert.ToInt32(Hours1); //inserts person 1hours per week and converts to string
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string Rate2 = Console.ReadLine();
            int HourlyRate2 = Convert.ToInt32(Rate2); //inserts person 2 hourly rate and converts to string
            Console.WriteLine("Hours Worked Per Week?");
            string Hours2 = Console.ReadLine();
            int PerWeek2 = Convert.ToInt32(Hours2); //inserts person 2 hours per week and converts to string
            Console.WriteLine("Annual Salary of Person 1:");
            int total1 = HourlyRate1 * PerWeek1 * 52;
            Console.WriteLine(total1.ToString()); //calculates annual salary of person 1 and converts to string
            Console.WriteLine("Annual Salary of Person 2:"); 
            int total2 = HourlyRate2 * PerWeek2 * 52;
            Console.WriteLine(total2.ToString()); //calculates annual salary of person 2 and converts to string
            Console.Write("Does Person 1 make more money than Person 2?\n");
            bool TrueOrFalse = total1 > total2;
            Console.Write(TrueOrFalse.ToString()); //compares annual salaries of person 1 and person 2 and says if true or false that person 1 makes more
            Console.ReadLine();
        }
    }
}
