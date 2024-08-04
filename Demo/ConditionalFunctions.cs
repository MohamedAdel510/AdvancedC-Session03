using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate bool ConditionalFuncDelegate<T>(T X);
    internal class ConditionalFunctions
    {
        public static bool CheckOdd(int number)
        {
            return number % 2 == 1;
        }

        public static bool CheckEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool CheckDivisableBy7(int number)
        {
            return number % 7 == 0;
        }

        public static bool CheckDivisableBy10(int number)
        {
            return number % 10 == 0;
        }

        public static bool GetStringLessThan4(string str)
        {
            return str?.Length <= 4;
        }

        public static bool GetStringMoreThan4(string str)
        {
            return str?.Length > 4;
        }
    }
}
