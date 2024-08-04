using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
using System.Xml.Linq;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Part01 What is Delegat
            ////Console.WriteLine(StringFuctions.GetCountOfLowerChars("Mohamed Adel"));
            ////Console.WriteLine(StringFuctions.GetCountOfUpperChars("Mohamed Adel"));

            ////public delegate int StringFuncDelegate(string Str);

            //// New Class [Delegate]
            //// Any Reference From This Delegate Can Refer To 
            //// Function Or More [Pointer To Function]
            //// This Function May be Static Function [Class Member Function]
            //// This Function May be Non Static Function [Object Member Function]
            //// But These Functions Must be with the Same Signature of The Delegate 
            //// Regardless Function Name & Access Modifier

            ////0.Delegate Declaration

            ////1.Declare Reference From Delegate
            //StringFuncDelegate Ref;

            ////2.Initialize Reference From Delegate[Pointer To Function]
            //// Ref = new StringFuncDelegate(StringFuctions.GetCountOfLowerChars);
            //// Syntax Suger 
            //Ref = StringFuctions.GetCountOfLowerChars;
            //Ref += StringFuctions.GetCountOfUpperChars;
            //Ref -= StringFuctions.GetCountOfUpperChars;

            ////3.Use Delegate Reference[Call Method]
            //Console.WriteLine(Ref.Invoke("Moahmed"));
            #endregion

            #region Example 02
            //int[] arr = { 3, 6, 9, 2, 4, 1 };

            //SortingAlgorithm<int>.BubbleSort(arr, CompareFunctions.CompareLess);
            ////SortingAlgorithm.BubbleSort(arr, CompareFunctions.CompareGrt);
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Ex 02 using genaric
            //string[] Names = { "Mohamed", "Nourhan", "Sara", "Esraa" };

            //SortingAlgorithm<string>.BubbleSort(Names, CompareFunctions.CompareStringAsc);
            //foreach (string name in Names)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region Ex 03 without Genarics
            //List<int> Numbers = Enumerable.Range(1, 100).ToList();

            //Console.WriteLine("Odd Numbers");
            //List<int> OddNumbers = Helper.GetNumbersBasedOnCondition(Numbers, ConditionalFunctions.CheckOdd);
            //foreach (int num in OddNumbers)
            //{
            //    Console.Write($"{num}\t");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Even Numbers");
            //List<int> EvenNumbers = Helper.GetNumbersBasedOnCondition(Numbers, ConditionalFunctions.CheckEven);
            //foreach (int num in EvenNumbers)
            //{
            //    Console.Write($"{num}\t");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Divisable By 7");
            //List<int> DivisalbeBy7 = Helper.GetNumbersBasedOnCondition(Numbers, ConditionalFunctions.CheckDivisableBy7);
            //foreach (int num in DivisalbeBy7)
            //{
            //    Console.Write($"{num}\t");
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Divisable By 10");
            //List<int> DivisalbeBy10 = Helper.GetNumbersBasedOnCondition(Numbers, ConditionalFunctions.CheckDivisableBy10);
            //foreach (int num in DivisalbeBy10)
            //{
            //    Console.Write($"{num}\t");
            //}
            #endregion

            #region Wx 03 with Genaric
            //List<string> Names01 = new List<string>(){ "Moahmed", "Adel", "Sara", "Nour" };
            //List<string> Res = Helper.GetElementsBasedOnCondition<string>(Names01, ConditionalFunctions.GetStringMoreThan4);

            //foreach (string name in Res)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region Built in Delegete Examples
            //// 1- Predicate
            //Predicate<int> predicate;
            //predicate = Testing.test01;
            //Console.WriteLine(predicate(5));

            //// 2- Func
            //Func<int, string> func;
            //func = Testing.test02;
            //Console.WriteLine(func(5));

            //// 3- Action non Genaric
            //Action a = Testing.test03;
            //a();

            //Action<string> act = Testing.test04;
            //act("Moahmed");
            #endregion

            #region Lamda Expression and Anonymous Method
            //// Anonymous Method:
            ////------------------
            //// 1- Predicate
            //Predicate<int> predicate;
            //predicate = delegate (int x) { return x > 0; };
            //Console.WriteLine(predicate(5));

            //// 2- Func
            //Func<int, string> func;
            //func = delegate (int x) { return x.ToString(); };
            //Console.WriteLine(func(5));

            //// 3- Action non Genaric
            //Action a = delegate () { Console.WriteLine("Hello, World!"); };
            //a();

            //Action<string> act = delegate (string Name) { Console.WriteLine($"Hello, {Name}"); };
            //act("Moahmed");

            //////Using Lamda Expression
            ////-----------------------
            //// 1- Predicate
            //Predicate<int> predicate;
            //predicate =  (x) => { return x > 0; };
            //Console.WriteLine(predicate(5));

            //// 2- Func
            //Func<int, string> func;
            //func = (x) => { return x.ToString(); };
            //Console.WriteLine(func(5));

            //// 3- Action non Genaric
            ////        input                 output
            //Action a =  () => { Console.WriteLine("Hello, World!"); };
            //a();

            //Action<string> act =  (Name) => { Console.WriteLine($"Hello, {Name}"); };
            //act("Moahmed");
            #endregion
        }
    }
}
