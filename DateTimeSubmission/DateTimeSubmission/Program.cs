using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();

            Console.WriteLine("Please enter a number in integer format:");
            int x = Convert.ToInt32(Console.ReadLine());

            DateTime hoursLater = DateTime.Now.AddHours(x);
            Console.WriteLine("In " + x + " hours it will be " + hoursLater);
            Console.ReadLine();

        }
    }
}
