using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> integers = new List<int> { 2, 4, 6, 8, 10 };
                Console.WriteLine("Please enter a number to divide a list of numbers by:");
                int input = Convert.ToInt32(Console.ReadLine());

                foreach (int integer in integers)
                {
                    Console.WriteLine(Convert.ToString(integer / input));
                }
            }
 
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number, do not type out the word format of the number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please dont divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
 }

