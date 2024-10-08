using System;

namespace project
{
    class Task_1 //  №1.2  наибольшее и след по величине число из 10
    {
        static void Main()
        {
            Console.WriteLine("type 10 numbers ");
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("number " + (i+1) + ": ");
                int chislo = Convert.ToInt32(Console.ReadLine());
                array[i] = chislo;
            }

            Array.Sort(array);
            Console.WriteLine(array[array.Length-1]);
            Console.WriteLine(array[array.Length - 2]);
        }
    }
}