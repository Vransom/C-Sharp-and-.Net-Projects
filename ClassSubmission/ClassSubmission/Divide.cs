using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public class Divide
    {
        public void Division(int input)
        {
            int answer = input/2;
            Console.WriteLine(input + " divided by 2 is " + answer);
        }

        public void Math( int input2, out int divided, out int added)
        {
            divided = input2 / 2;
            added = input2 + 100;
            Console.WriteLine(input2 + " divided by 2 is " + divided + ", and " + input2 + " plus 100 is " + added);
        }

        public void Math(int input2, int input3)
        {
            int result = input2 + input3;
            Console.WriteLine(input2 + "(the previous number you entered) plus " + input3 + " is " + result);
        }

        public static int Addition(int input4)
        {
            return input4 + 400;
        }
    }
}
