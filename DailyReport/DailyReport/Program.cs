using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \n Student Daily Report");
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string Course = Console.ReadLine();
            Console.WriteLine("What page Number?");
            string PageNumber = Console.ReadLine();
            int PageNum = Convert.ToInt32(PageNumber);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string TrueFalse = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you'd like to share? Plase give specifics.");
            string Experience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string Feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int Hours = Convert.ToInt32(hoursStudied);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
