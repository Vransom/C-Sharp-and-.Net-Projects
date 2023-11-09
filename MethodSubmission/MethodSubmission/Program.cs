using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            operation output = new operation();

            Console.WriteLine("Please enter one number in integer form:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you wish, please enter another number in integer form:");
            int input2;
            int result;
            if (int.TryParse(Console.ReadLine(), out input2))
            {
                result = output.twoNumbers(input1, input2);
                Console.WriteLine("We have added " + input1 + " and " + input2 + " to equal " + result);
            }
            else
            {
                result = output.oneNumber(input1);
                Console.WriteLine("We have added 100 to " + input1 + " to get " + result);
            }

            Console.ReadLine();
        }
    }
}
