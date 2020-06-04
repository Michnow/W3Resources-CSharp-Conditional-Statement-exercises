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
            /* 5)
            Console.Write("Enter your age: ");
            int first = int.Parse(Console.ReadLine());
            Test(first);
            static void Test(int a)
            {
                if (a < 21)
                {
                    Console.WriteLine("You can't vote yet.");
                }
                else
                {
                    Console.WriteLine("Congratulation! You are eligible for casting your vote.");
                }
            }
            */
            /* 6)
            Console.Write("Enter number: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine(Test(first));
            static int Test(int a)
            {
                if (a >= 1)
                {
                    return 1;
                }
                else if ( a==0)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            */
            /* 7)
            Console.Write("Enter your height [cm] : ");
            int height = int.Parse(Console.ReadLine());
            Test(height);
            static void Test(int a)
            {
                if (a <= 140)
                {
                    Console.WriteLine("Hello small guy");
                }
                else if (a <= 185 || a >= 141)
                {
                    Console.WriteLine("Hello guy");
                }
                else
                {
                    Console.WriteLine("Hello big guy");
                }
            }
            */
            /* 8)
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int third= int.Parse(Console.ReadLine());
            Test(first, second, third);
            static void Test(int a, int b, int c)
            {
                if (a > b && a > c) Console.WriteLine("Biggest number is {0}", a);
                else if (b > a && b > c) Console.WriteLine("Biggest number is {0}", b);
                else Console.WriteLine("Biggest number is {0}", c);
            }
            */
            /* 9)
            Console.Write("Enter x coordinate: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter y coordingate: ");
            int second = int.Parse(Console.ReadLine());
            Test(first, second);
            static void Test(int x, int y)
            {
                if (x < 0 && y < 0) Console.WriteLine("Third Quadrant.");
                else if (x < 0 && y > 0) Console.WriteLine("Second Quadrant.");
                else if (x > 0 && y > 0) Console.WriteLine("First Quadrant.");
                else if (x == 0 && y == 0) Console.WriteLine("Center");
                else Console.WriteLine("Fourth Quadrant.");
            }
            */

        }
    }
}
