using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Testing
    {
        public static bool test01(int X)
        {
            return X > 0;
        }

        public static string test02(int X)
        {
            return X.ToString();
        }
        public static void test03()
        {
            Console.WriteLine("Hello, world!");
        }

        public static void test04(string s)
        {
            Console.WriteLine(s);
        }
    }
}
