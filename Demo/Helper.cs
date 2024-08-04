using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    static class Helper
    {
        #region non Genaric
        //public static List<int> GetNumbersBasedOnCondition(List<int> list, ConditionalFuncDelegate<int> conditionalFunc)
        //{

        //    List<int> result = new List<int>();
        //    if (list is not null && conditionalFunc is not null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (conditionalFunc(list[i]))
        //            {
        //                result.Add(list[i]);
        //            }
        //        }
        //    }
        //    return result;
        //}
        #endregion

        #region Genaric
        public static List<T> GetElementsBasedOnCondition<T>(List<T> list, ConditionalFuncDelegate<T> conditionalFunc)
        {

            List<T> result = new List<T>();
            if (list is not null && conditionalFunc is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (conditionalFunc(list[i]))
                    {
                        result.Add(list[i]);
                    }
                }
            }
            return result;
        }
        #endregion

        //public static List<int> GetEvenNumbers(List<int> list)
        //{

        //    List<int> result = new List<int>();
        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 2 == 0)
        //            {
        //                result.Add(list[i]);
        //            }
        //        }
        //    }
        //    return result;
        //}

        //public static List<int> GetNnumberDivisableBy7(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 7 == 0)
        //            {
        //                result.Add(list[i]);
        //            }
        //        }
        //    }
        //    return result;
        //}

        //public static List<int> GetNnumberDivisableBy10(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 10 == 0)
        //            {
        //                result.Add(list[i]);
        //            }
        //        }
        //    }
        //    return result;
        //}
    }
}
