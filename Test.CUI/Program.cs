using System;
using static Task1.WorkingWithArrays;
using static Task2.WorkingWithString;
using static Task3.WorkingWithBinaryOperations;

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

            Console.WriteLine("Task2:");
            string a = "xyaabbbccccdefww";
            string b = "xxxxyyyyabklmopq";
            Console.WriteLine(Longest(a, b));

            a = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine(Longest(a, a));

            Console.WriteLine("Task3:");
            int g = 8, h = 15, x = 0, y = 0;
            Console.WriteLine(Insert(g, h, x, y));
            g = 15;
            h = int.MaxValue;
            x = 3;
            y = 5;
            Console.WriteLine(Insert(g, h, x, y));
            g = 0;
            h = 15;
            x = 30;
            y = 30;
            Console.WriteLine(Insert(g, h, x, y));
            Console.ReadKey();
        }
    }
}
