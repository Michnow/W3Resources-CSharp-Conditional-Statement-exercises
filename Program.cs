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
            /* 10)
            Console.Write("Input the marks obtained in Physics: ");
            bool res = int.TryParse(Console.ReadLine(), out int physics );
            Console.Write("Input the marks obtained in Chemistry: ");
            res = int.TryParse(Console.ReadLine(), out int chem);
            Console.Write("Input the marks obtained in Mathematics: ");
            res = int.TryParse(Console.ReadLine(), out int math);
            Test(physics, chem, math);
            static void Test(int p, int c, int m)
            {
                if (p >= 55 && m >= 65 && c >=50 && (p+m+c >= 180 || p + m >= 140) )
                {
                    Console.WriteLine("The candidate is eligible for admission.");
                }
                else Console.WriteLine("The candidate is not eligible for admission.");
            }
            */
            /* 11)
            Console.Write("Input the value of a :");
            bool res = int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Input the value of b :");
            res = int.TryParse(Console.ReadLine(), out int b);
            Console.Write("Input the value of c :");
            res = int.TryParse(Console.ReadLine(), out int c);
            Test(a, b, c);
            static void Test(int a, int b, int c)
            {
                int d = b * b - 4 * a * c;
                if (d==0)
                {
                    Console.WriteLine("Both roots are equal");
                    Console.WriteLine($"First root {-b * (2 * a)}, Second Root {-b*(2*a)}");
                }
                else if ( d > 0)
                {
                    var root1 = (-b + Math.Sqrt(d)) / 2 * a;
                    var root2 = (-b - Math.Sqrt(d)) / 2 * a;
                    Console.WriteLine($"First root:{root1}, and second root: {root2}");
                }
                else
                {
                    Console.WriteLine("Roots are imaginary");
                }
            }
            */
            /* 12)
            Console.Write("Input the Roll number of student:");
            bool res = int.TryParse(Console.ReadLine(), out int roll);
            Console.Write("Input the name of the student:");
            string name = Console.ReadLine();
            Console.Write("Input the marks of physics: ");
            res = int.TryParse(Console.ReadLine(), out int physics);
            Console.Write("Input the marks of chemistry: ");
            res = int.TryParse(Console.ReadLine(), out int chemistry);
            Console.Write("Input the marks of Computer Application: ");
            res = int.TryParse(Console.ReadLine(), out int computerApplication);

            Test(roll, name, physics, chemistry, computerApplication);
            static void Test(int r, string n, double p, double c, double ca)
            {
                double percentage = (p + c + ca) / 3;
                Console.WriteLine("Roll number: {0}",r);
                Console.WriteLine("Name of student: {0}", n);
                Console.WriteLine("Marks in Physics: {0}, Marks in Chemistry: {1}, Marks in Computer Application: {2}", p, c, ca);
                Console.WriteLine("Total marks: {0}", p + c + ca);
                Console.WriteLine("Percentage: {0}", percentage);
                if (percentage >= 60) Console.WriteLine("First division");
                else if (percentage < 60 && percentage >= 48) Console.WriteLine("Second division");
                else if (percentage < 48 && percentage >= 36) Console.WriteLine("Pass");
                else Console.WriteLine("Fail");
            }
            */
            /* 13)
            Console.Write("Enter temperature [oC]: ");
            int.TryParse(Console.ReadLine(), out int temp);
            Test(temp);
            static void Test(int a)
            {
                if (a < 0) Console.WriteLine("Freezing weather.");
                else if (a < 10) Console.WriteLine("Very cold weather.");
                else if (a < 20) Console.WriteLine("Cold weather.");
                else if (a < 30) Console.WriteLine("Normal in temp.");
                else if (a < 40) Console.WriteLine("It's hot.");
                else Console.WriteLine("It's very hot.");
            }
            */
            /* 14)
            Console.Write("Enter lenght of the first side of the triangle: ");
            int.TryParse(Console.ReadLine(), out int first);
            Console.Write("Enter lenght of the second side of the triangle: ");
            int.TryParse(Console.ReadLine(), out int second);
            Console.Write("Enter lenght of the third side of the triangle: ");
            int.TryParse(Console.ReadLine(), out int third);
            Test(first, second, third);
            static void Test(int a, int b, int c)
            {
                if (a == b && b == c) Console.WriteLine("It is equilateral triangle."); 
                else if (a == b || a == c || b == c) Console.WriteLine("It is isoceles triangle.");
                else Console.WriteLine("It is scalene triangle.");
            }
            */
            /* 15)
            Console.Write("Enter lenght of the first edge of the triangle: ");
            int.TryParse(Console.ReadLine(), out int first);
            Console.Write("Enter lenght of the second edge of the triangle: ");
            int.TryParse(Console.ReadLine(), out int second);
            Console.Write("Enter lenght of the third edge of the triangle: ");
            int.TryParse(Console.ReadLine(), out int third);
            Test(first, second, third);
            static void Test(int a, int b, int c)
            {
                if (a + b + c == 180) Console.WriteLine("The triangle is valid.");
                else Console.WriteLine("The triangle is invalid.");
            }
            */
            /* 16)
            Console.Write("Enter the character: ");
            string character = Console.ReadLine();
            Test(character);
            static void Test(string a)
            {
                switch (a)
                {
                    case "a": Console.WriteLine("Vovel"); break;
                    case "e": Console.WriteLine("Vovel"); break;
                    case "i": Console.WriteLine("Vovel"); break;
                    case "o": Console.WriteLine("Vovel"); break;
                    case "u": Console.WriteLine("Vovel"); break;
                    case "y": Console.WriteLine("Vovel"); break;
                    default: Console.WriteLine("Consonant"); break;
                }
            }
            */
            /* 17)
            Console.Write("Input buy price: ");
            int.TryParse(Console.ReadLine(), out int buy);
            Console.Write("Input sell price: ");
            int.TryParse(Console.ReadLine(), out int sell);
            Test(buy, sell);
            static void Test(int b, int s)
            {
                if (b > s) Console.WriteLine($"Your loss is {b - s}.");
                else if (b == s) Console.WriteLine($"No profit, no loss.");
                else Console.WriteLine($"Your profit is {s - b}.");
            }
            */
            /* 18)
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your customer ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter unit consumed: ");
            int.TryParse(Console.ReadLine(), out int unit);
            Test(name, id, unit);
            static void Test(string n, string i, int u)
            {
                double charge = 0;
                double surcharge = 0;

                if (u < 100)
                {
                    u = 100;
                    charge = 1.2;
                }
                else if (u < 200) charge = 1.2;
                else if (u < 400) charge = 1.5;
                else if (u < 600)
                {
                    charge = 1.8;
                    surcharge = 0.15;
                }
                else
                {
                    charge = 2;
                    surcharge = 0.15;
                }

                Console.WriteLine("\nCustomer ID number: {0}.", i);
                Console.WriteLine("Customer name: {0}.", n);
                Console.WriteLine("Unit consumed: {0}.", u);
                Console.WriteLine("Amount charges @{0} per unit: {1}", charge, charge * u);
                Console.WriteLine("Surcharge amount: {0}", charge*u*surcharge);
                Console.WriteLine("Net amount paid by customer: {0}", charge * u + charge * u * surcharge);
            }
            */
            /* 19)
            Console.Write("Input the grade: ");
            string grade = Console.ReadLine().ToUpper();
            Console.WriteLine("You have chosen: {0}",Grader(grade));
            static string Grader(string g)
            {
                switch (g)
                {
                    case "E": return "Excellent";
                    case "V": return "Very good";
                    case "G": return "Good";
                    case "A": return "Average";
                    case "F": return "Fail";
                    default: return "incorrect grade";
                }
            }
            */
            /* 20)
            Console.Write("Input the number 1-7: ");
            int.TryParse(Console.ReadLine(), out int day);
            Console.WriteLine(Test(day));
            static string Test(int d)
            {
                switch (d)
                {
                    case 1: return "Monday";
                    case 2: return "Tuesday";
                    case 3: return "Wednesday";
                    case 4: return "Thursday";
                    case 5: return "Friday";
                    case 6: return "Saturday";
                    case 7: return "Sunday";
                    default: return "incorrect number";
                }
            }
            */
            /* 21)
            Console.Write("Input the number 1-9: ");
            int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine(Test(number));
            static string Test(int n)
            {
                switch (n)
                {
                    case 1: return "One";
                    case 2: return "Two";
                    case 3: return "Three";
                    case 4: return "Four";
                    case 5: return "Five";
                    case 6: return "Six";
                    case 7: return "Seven";
                    case 8: return "Eight";
                    case 9: return "Nine";
                    default: return "incorrect number";
                }
            }
            */
            /* 22)
            Console.Write("Input the number 1-12: ");
            int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine(Test(number));
            static string Test(int n)
            {
                switch (n)
                {
                    case 1: return "January";
                    case 2: return "February";
                    case 3: return "March";
                    case 4: return "April";
                    case 5: return "May";
                    case 6: return "June";
                    case 7: return "July";
                    case 8: return "August";
                    case 9: return "September";
                    case 10: return "October";
                    case 11: return "November";
                    case 12: return "December";
                    default: return "incorrect number";
                }
            }
            */
            /* 23)
            Console.Write("Input the month 1-12: ");
            int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine("Month has {0} days.", Test(number));
            static string Test(int n)
            {
                switch (n)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: return "31";
                    case 2: return "28";
                    case 4:
                    case 6:
                    case 9:
                    case 11: return "30";

                    default: return "incorrect number";
                }
            }
            */

        }
    }
}
