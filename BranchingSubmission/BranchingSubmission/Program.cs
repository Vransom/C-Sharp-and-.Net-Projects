using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("What is your package weight?");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            else if (weight <= 50)
            {
                Console.WriteLine("What is the package width?");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package height?");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                int length = Convert.ToInt32(Console.ReadLine());
                
                if (width+height+length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }

                else if (width+height+length <= 50)
                {
                    int Total = (width * height * length * weight)/100;
                    int total = Convert.ToInt32(Total);
                    Console.WriteLine("Your estimated total for shipping this package is:$" + total);
                    Console.WriteLine("Thank you!");
                }
            }
            Console.ReadLine();

        }
    }
}
