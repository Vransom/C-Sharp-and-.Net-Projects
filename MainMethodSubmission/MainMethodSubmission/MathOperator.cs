using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    public class MathOperator
    {
        public int Addition(int input)
        {
            return input + 100;
        }

        public int Decimal(decimal dec)
        {
            return Convert.ToInt32(dec) + 200;
        }

        public int String(string str)
        {
            return Convert.ToInt32(str) + 100;
        }
    }
}
