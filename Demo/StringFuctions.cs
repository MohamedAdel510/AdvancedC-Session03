using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //step 0: Delegate Declaration
    public delegate int StringFuncDelegate (string s);
    internal class StringFuctions
    {
        public static int GetCountOfUpperChars(string str)
        {
            int count = 0;
            if(str is not null )
            {
                for(int i = 0; i < str.Length; i++)
                {
                    if (char.IsUpper(str[i]))
                        count++;
                }
            }
            return count;
        }

        public static int GetCountOfLowerChars(string str)
        {
            int count = 0;
            if (str is not null)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsLower(str[i]))
                        count++;
                }
            }
            return count;
        }
    }
}
