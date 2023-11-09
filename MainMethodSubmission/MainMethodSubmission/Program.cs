using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperator output = new MathOperator();

            Console.WriteLine("Please enter an integer to perform a math operation on that integer:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input + " plus 100 is " + output.Addition(input));

            Console.WriteLine("\n Now please enter a decimal number to add:");
            decimal dec = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(dec + " (rounded to the nearest integer) plus 200 is " + output.Decimal(dec));

            Console.WriteLine("\n Now please enter an integer in word format:");
            string str = Console.ReadLine();
            Console.WriteLine(str + "(reformatted so the computer can understand it) plus 100 is " + output.String(str));

            Console.ReadLine();
        }
    }
}
