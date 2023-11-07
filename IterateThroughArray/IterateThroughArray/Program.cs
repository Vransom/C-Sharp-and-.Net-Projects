using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterateThroughArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment Part 1
            string[] stringArray = new string[] {"brown", "blue", "green"};
            Console.WriteLine("Please add an animal to the end of each color");
            for (int i=0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
                stringArray[i]=stringArray[i]+ " "+Console.ReadLine(); //user input
            }
            foreach (var item in stringArray)
            {
                Console.WriteLine(item);//second loop that prints off the updated array
            }
            //Assignment Part 2
            while (true)
            {
                Console.WriteLine("\n Those are your animals and their colors. \n");
                break; //the break fixed the infinite loop
            }
            //Assignment Part 3
            int x = 0;
            while (x<3)
            {
                Console.WriteLine("We have almost hit the limit: "+ x);
                x++;
            }

            int y = 0;
            while (y<=3)
            {
                Console.WriteLine("We have hit the limit: "+ y);
                y++;
            }

            //Assignment Part 4
            List<string> fruits = new List<string>() { "apple", "banana", "pear", "orange" };
            Console.WriteLine("\n Please enter a fruit (singular form) to see if it is on the list: ");
            string input = Console.ReadLine(); //user input
            foreach (string fruit in fruits)
            {
                if (fruits.Contains(input))
                {
                    Console.WriteLine("You have selected: " + input);
                    break; //if user types in a fruit that is on the list this will appear and break the loop
                }
                else
                {
                    Console.WriteLine("Sorry, that fruit is not in the list");
                    break; //if user types in something not on the list this will appear and break the loop
                }
            }

            //Assignment Part 5
            List<string> fruits2 = new List<string>() { "apple", "banana", "pear", "orange", "orange" };
            Console.WriteLine("\n Please enter a fruit (singular form) to see if it is on the list: ");
            string input2 = Console.ReadLine();
            
          
            for (int i = 0; i < fruits2.Count; i++)
            {
                if (fruits2[i]==input2)
                {
                    Console.WriteLine("Your selection: " + input2+ ", has an index of"+ i);
         
                    
                }
                else if (!fruits2.Contains(input2))
                {
                    Console.WriteLine("Sorry, that fruit is not in the list");
                    break;
                }
            }

            //Assignment 6
            List<string> fruits3 = new List<string>() { "apple", "banana", "pear", "orange", "orange" };
            Console.WriteLine("\n See which fruits are duplicates ");

            for (int t = 0; t < fruits3.Count; t++)
            {
                if (fruits3.LastIndexOf(fruits3[t]) >= t && fruits3.IndexOf(fruits3[t]) == t)
                {
                    Console.WriteLine(fruits3[t] + " is original."); //if fruit is not a duplicate this will appear
                }
                else
                {
                    Console.WriteLine(fruits3[t] + " is a duplicate."); //if fruit is a duplicate this will appe
                }
            }


            Console.ReadLine();


        }
    }
}
