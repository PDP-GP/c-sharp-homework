using System;

namespace project
{
    class Task_1 //  №2.2 про факториал и фибоначчи
    {
        public static int fact_iterativno(int x)
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

        public static int fact_rekursivno(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * fact_rekursivno(x - 1);
            }
        }

        public static int Fibonacci_iterativno(int n)
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

        public static int Fibonacci_rekursivno(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonacci_rekursivno(n - 1) + Fibonacci_rekursivno(n - 2);
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
                Console.WriteLine(x + "! = " + fact_iterativno(x) + " (iterative)");
                Console.WriteLine(x + "! = " + fact_rekursivno(x) + " (recursive)");
            }
            Console.WriteLine("type a number of the Fibonacci sequence");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Try to start at one or more");
            }
            else {
                Console.WriteLine("Fibonacci: " + Fibonacci_iterativno(n) + " (iterative)");
                Console.WriteLine("Fibonacci: " + Fibonacci_rekursivno(n) + " (recursive)");
            }
            

        }
    }
}