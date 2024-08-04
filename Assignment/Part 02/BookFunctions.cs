using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part_02
{
    public delegate string BookFuncDelegate(Book B);
    static class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;    
        }

        public static string GetAuthers(Book B)
        {
            if(B is not null && B.Authors is not null)
            {
                for(int i = 0; i < B.Authors.Length; i++)
                {
                    return B.Authors[i];
                }
            }
            return string.Empty;
        }

        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }
    }
}
