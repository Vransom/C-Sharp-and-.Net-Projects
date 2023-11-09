using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer to perform three predetermined math operations on that integer:");
            int input = Convert.ToInt32(Console.ReadLine());
            int output = MathOperations.Addition(input);
            Console.WriteLine(input + " plus 100 is " + output);
            int output2 = MathOperations.Subtraction(input);
            Console.WriteLine(input + " minus 100 is " + output2);
            int output3 = MathOperations.Multiplication(input);
            Console.WriteLine(input + " times 100 is " + output3);
            Console.ReadLine();
        }
    }
}
