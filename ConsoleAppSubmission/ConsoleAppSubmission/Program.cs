using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSubmission
{
    class Program
    {
      

        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature?");
            int temp = Convert.ToInt32(Console.ReadLine());

            while (temp < 72)
            {
                Console.WriteLine("Temp is less than 72");
                temp = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Guess the temperature");
            int temp1 = Convert.ToInt32(Console.ReadLine());

            bool Guess = temp1 == 72;
            do
            {
                switch (temp1)
                {
                    case 72:
                        Console.WriteLine("You guessed 72! That is correct!");
                        Guess = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess the temperature");
                        temp1 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!Guess);

            Console.ReadLine();
        }
    }
}
