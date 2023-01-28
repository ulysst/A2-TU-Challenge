using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            int result = a + b; return result;
        }

        public static bool IsMajeur(int age)
        {
            if (age >= 18) return true; else return false;
        }

        public static bool IsEven(int a)
        {
            return ((a & 1) == 0);
        }

        public static bool IsDivisible(int a, int b)
        {
            return ((b + a & 1) == 0);
        }
        public static int Power2(int a)
        {
            return a * a;
        }

        public static int Power(int a, int b)
        {
            int result = a;
            for (int i = 1; i < b; i++)
            {
                result = result * a;
            }
            return result;
        }
        public static int IsInOrder(int a, int b)
        {
            if (a < b)
            {
                return 1;
            }
            else if (a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }

        }
    }
}
