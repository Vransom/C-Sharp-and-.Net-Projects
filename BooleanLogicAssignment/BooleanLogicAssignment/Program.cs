using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string Age = Console.ReadLine();
            int age = Convert.ToInt32(Age);
            Console.WriteLine("Have you ever had a dui? Please answer true or false");
            string DUI = Console.ReadLine();
            bool dui = Convert.ToBoolean(DUI);
            Console.WriteLine("How many speeding tickets do you have?");
            string Tickets = Console.ReadLine();
            int tickets = Convert.ToInt32(Tickets);
            Console.WriteLine("Qualified?");
            Console.WriteLine(dui==false && tickets<3 && age>15);
            Console.ReadLine();
        }
    }
}
