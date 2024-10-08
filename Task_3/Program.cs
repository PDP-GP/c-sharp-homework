using System;

namespace project
{
    class Task_1 //  №1.3  решить квадратное уравнение
    {
        static void Main()
        {
            Console.WriteLine("type a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("type b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("type c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("infinitely many solutions");
                    } else { Console.WriteLine("no solutions"); }
                }
                else
                {
                    double x = (-c) / b;
                    Console.WriteLine("one solution:\nx = " + x);
                }
            }
            else
            {
                if ((Math.Pow(b, 2) - 4 * c * a) < 0)
                {
                    Console.WriteLine("discriminant is negative\nno solutions");
                }
                else
                {
                    double x1 = ((-b) + Math.Sqrt(Math.Pow(b, 2) - 4 * c * a)) / (2 * a);
                    double x2 = ((-b) - Math.Sqrt(Math.Pow(b, 2) - 4 * c * a)) / (2 * a);
                    Console.WriteLine("two solutions:\nx1 = " + x1 + "\nx2 = " + x2);
                    
                }
            }
        }
    }
}





