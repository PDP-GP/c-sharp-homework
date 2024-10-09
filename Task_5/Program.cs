using System;

namespace project
{
    class Task_1 //  №2.2 про факториал и фибоначчи
    {
        public static int Fact_Iterative(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                int result = 1;
                for (int i = 1; i <= x; i++)
                {
                    result *= i;
                }
                return result;
            }
            
        }

        public static int FactRecursive(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * FactRecursive(x - 1);
            }
        }

        public static int FibonacciIterative(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temporary = a;
                a = b;
                b = temporary + b;
            }
            return a;
        }

        public static int FibonacciRekursive(int n)
        {
            if (n == 0 || n == 1) return n;

            return FibonacciRekursive(n - 1) + FibonacciRekursive(n - 2);
        }

        static void Main()
        {
            Console.WriteLine("insert an integer number");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("Your number is NOT an integer number");
            } else
            {
                Console.WriteLine(x + "! = " + Fact_Iterative(x) + " (iterative)");
                Console.WriteLine(x + "! = " + FactRecursive(x) + " (recursive)");
            }
            Console.WriteLine("type a number of the Fibonacci sequence");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Try to start at one or more");
            }
            else {
                Console.WriteLine("Fibonacci: " + FibonacciIterative(n) + " (iterative)");
                Console.WriteLine("Fibonacci: " + FibonacciRekursive(n) + " (recursive)");
            }
            

        }
    }
}