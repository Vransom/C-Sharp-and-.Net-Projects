using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Divide output = new Divide(); //instantiate
            Console.WriteLine("Please enter a number to be divided by 2:");
            int input = Convert.ToInt32(Console.ReadLine());
            output.Division(input); //displayed output of user entered number

            Console.WriteLine("\nPlease enter a new number to have math operations done on it:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            output.Math(input2, out int divided, out int added); //output parameters

            Console.WriteLine("\nNow please enter a new number for more math:");
            int input3 = Convert.ToInt32(Console.ReadLine());
            output.Math(input2, input3); //overloaded

            Console.WriteLine("\nNow please enter one final number for an operation:");
            int input4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input4 + " plus 400 is " + Divide.Addition(input4)); //static

            Console.ReadLine();
        }
    }
}
