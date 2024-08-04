using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    
    internal class SortingAlgorithm<T>
    {
        public static void Swap(ref T X, ref T Y)
        {
            T Tmp = X;
            X = Y;
            Y = Tmp;
        }

        public static void BubbleSort(T[] Array, CompareFuncDelegate<T> compareFunc)
        {
            if(Array is not null)
            {
                for(int  i= 0; i < Array.Length; i++)
                {
                    for(int j =0; j <  Array.Length - i - 1; j++)
                    {
                        if (compareFunc(Array[j], Array[j+1]))
                            Swap(ref Array[j], ref Array[j+1]);
                    }
                }
            }
        }

        //public static void BubbleSortDec(int[] Array, char op) // > , < 
        //{
        //    if (Array is not null)
        //    {
        //        for (int i = 0; i < Array.Length; i++)
        //        {
        //            for (int j = 0; j < Array.Length - i - 1; j++)
        //            {
        //                if (CompareFunctions.CompareLess(Array[j], Array[j + 1]))
        //                    Swap(ref Array[j], ref Array[j + 1]);
        //            }
        //        }
        //    }
        //}
    }
}
