using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please select a number 0-4 to display an animal");
        string[] stringArray = new string[] { "lion", "tiger", "bear", "parrot", "snake" };
        string selection = Console.ReadLine();
        int userselection = Convert.ToInt32(selection);

        if (userselection >= 0 && userselection <= 4)
        {
            Console.WriteLine("You have chosen " + stringArray[userselection]);
        }
        else
        {
            Console.WriteLine("You have not selected a number 0-4");
        }


        Console.WriteLine("\n Please select a number 0-4 to display an integer");
        int[] intArray = new int[] { 17, 41, 6000, 12312, 21324 };
        int userselection1 = Convert.ToInt32(Console.ReadLine());

        if (userselection1 >= 0 && userselection1 <= 4)
        {
            Console.WriteLine("You have chosen " + intArray[userselection1]);
        }
        else
        {
            Console.WriteLine("You have not selected a number 0-4");
        }


        Console.WriteLine("\n Please select a number 0-4 to display a food");
        List<string> intList =new List<string> { "apple", "banana", "orange", "grape", "lemon" };
        string selection2 = Console.ReadLine();
        int userselection2 = Convert.ToInt32(selection2);

        if (userselection2 >= 0 && userselection2 <= 4)
        {
            Console.WriteLine("You have chosen " + intList[userselection2]);
        }
        else
        {
            Console.WriteLine("You have not selected a number 0-4");
        }
        Console.ReadLine();

    }
}

