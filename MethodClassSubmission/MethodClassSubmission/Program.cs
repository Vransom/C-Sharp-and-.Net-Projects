using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            mathoperator output = new mathoperator(); //instantiate
            Console.WriteLine("Please enter one integer:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second integer:");
            int input2 = Convert.ToInt32(Console.ReadLine());

            output.voidOperation(3, 7); //passing in two numbers

            output.voidOperation(integer1: input1, integer2: input2); //passing in parameters by name

            Console.ReadLine();
        }
    }
}
