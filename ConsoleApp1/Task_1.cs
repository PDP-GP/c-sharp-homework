using System;

namespace project
{
    class Task_1 //№1.1     простые числа до заданного числа включительно
    {
        static void Main()
        {
            Console.Write("type a number ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int number = 2; number<=n; number++)
            {
                bool ok = true;
                for (int divider = 2; divider <= Math.Sqrt(number); divider++)
                {
                    if (number % divider == 0)
                    {
                        ok = false;
                        break;
                    }

                    
                }

                if (ok == true)
                {
                    Console.WriteLine(number);
                }

               
            }
            
            
        }
    }
}