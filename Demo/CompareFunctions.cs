using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public delegate bool CompareFuncDelegate<T>(T A, T B);
    internal class CompareFunctions
    {
        public static bool CompareGrt(int x, int y)
        {
            return x > y;
        }

        public static bool CompareLess(int x, int y)
        {
            return x < y;
        }
        
        public static bool CompareStringAsc(string X, string Y)
        {
            return X?.Length > Y?.Length;
        }

        public static bool CompareStringDec(string X, string Y)
        {
            return X?.Length < Y?.Length;
        }
    }
}
