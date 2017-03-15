using System;
using static Task1.Class1;


namespace Test.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1:");
            int[] arr = { 1, 2, 3, 4, 3, 2, 1 };
            Console.WriteLine(ReturnIndex(arr));

            int[] arr1 = { 1, 100, 50, -51, 1, 1 };
            Console.WriteLine(ReturnIndex(arr1));

            int[] arr2 = { 1, 100, 50, 5, 1, 1 };
            Console.WriteLine(ReturnIndex(arr2));
            Console.ReadKey();
        }
    }
}
