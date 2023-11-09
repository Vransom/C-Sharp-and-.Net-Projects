using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    public class operation
    {
        public int twoNumbers(int input1, int input2)
        {
            return input1 + input2;
        }

        public int oneNumber(int input1, int? input2 = null)
        {
            return input1 + 100;
        }
    }
}
