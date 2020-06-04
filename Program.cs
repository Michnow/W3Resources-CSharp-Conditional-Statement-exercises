using System;

namespace CSharp_Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1)
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int second = int.Parse(Console.ReadLine());
            Test(first, second);
            static void Test(int a, int b)
            {
                if (a==b)
                {
                    Console.WriteLine($"{a} and {b} are equal");
                }
                else
                {
                    Console.WriteLine($"{a} and {b} are not equal");
                }
            }
            */
            /* 2)
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Test(first);
            static void Test(int a)
            {
                if ( a%2 != 0)
                {
                    Console.WriteLine($"{a} is odd integer");
                }
                else
                {
                    Console.WriteLine($"{a} is even integer");
                }
            }
            */
            /* 3)
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Test(first);
            static void Test(int a)
            {
                if (a < 0)
                {
                    Console.WriteLine($"{a} is negative integer");
                }
                else
                {
                    Console.WriteLine($"{a} is positive integer");
                }
            }
            */
            /* 4)
            Console.Write("Enter the year: ");
            int first = int.Parse(Console.ReadLine());
            Test(first);
            static void Test(int a)
            {
                if (a%4 == 0)
                {
                    Console.WriteLine($"{a} is leap year");
                }
                else
                {
                    Console.WriteLine($"{a} is not leap year");
                }
            }
            */
        }
    }
}
