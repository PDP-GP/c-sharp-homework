using System;

namespace project
{
    class Task_1 //  №2.3 про гипотезу n/2, n*3+1
    {
        static void Main()
        {
            Console.WriteLine("type an integer number");
            int n = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            while(n!=1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    counter++;
                }
                else
                {
                    n = 3 * n + 1;
                    counter++;
                }
            }
            Console.WriteLine("Number of replacements in order to get '1':   " +  counter);
        }
    }
}