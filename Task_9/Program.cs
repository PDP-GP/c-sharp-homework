using System;


namespace project
{
    class Task_9
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите число");
            var chislo = Convert(Console.ReadLine());
            Console.WriteLine($"Ваше число: {chislo}");
        }

        public static int Convert(string input)
        {
            try
            {
                return System.Convert.ToInt32(input);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Число или слишком большое, или слишком маленькое");
                throw;
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число");
                throw;
            }
        }

    }

}