using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubmission
{
    class Program
    {
        public enum daysoftheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the current day of the week:");
            string input = Console.ReadLine();

            try
            {

                Console.WriteLine(Enum.Parse(typeof(daysoftheWeek), input));

            }

            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
    }
}
