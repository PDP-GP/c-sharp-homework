using System;

namespace project
{
    class Task_6  //пузырьковая сортировка
    {
        public static void Bubble(int[] array1)
        {
            PrintArray(array1);
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array1.Length-1; j++)
                {
                    if (array1[j] > array1[j + 1])
                    {
                        int temporary = array1[j];
                        array1[j] = array1[j + 1];
                        array1[j + 1] = temporary;
                    }
                }
                PrintArray(array1);
            }
        }
        public static void PrintArray(int[] anArray)
        {
            for (int i = 0; i < anArray.Length; i++)
            {
                Console.Write(anArray[i] + " ");
            }
            Console.WriteLine("\n");
        }

            static void Main()
        {
            int[] anArray = new int[] { 1, 5, 4, 3, 8, 2, 6, 9, 7, 0 };

            Bubble(anArray);
            
        }
    }
}