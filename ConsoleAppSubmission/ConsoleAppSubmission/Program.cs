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


            bool Guess = temp == 72;
         

            do
            {
                switch (temp)
                {
                    case 72:
                        Console.WriteLine("You guessed 72! That is correct!");
                        Guess = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess the temperature");
                        temp = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!Guess);

            Console.ReadLine();
        }
    }
}
