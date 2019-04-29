using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operations
    {
        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        public static decimal Add(decimal n1, decimal n2)
        {
            return n1 + n2;
        }

        public static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        public static decimal Subtract(decimal n1, decimal n2)
        {
            return n1 - n2;
        }

        public static int Multiply(int n1, int n2)
        {
            return n1*n2;
        }

        public static decimal Multiply(decimal n1, decimal n2)
        {
            return n1 * n2;
        }

        public static int Divide(int n1, int n2)
        {
            return n1/n2;
        }

        public static decimal Divide(decimal n1, decimal n2)
        {
            return n1 / n2;
        }

        public static decimal Factorial(decimal i)
        {
            if (i <= 1)
            {
                return 1;
            }
            return i * Factorial(i - 1);
        }
    }
}
