using System;


namespace project //компл числа
{
    class Task_8
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ComplexNum complexNum1 = new ComplexNum(1, 1);
            ComplexNum complexNum2 = new ComplexNum(2, 2);
            int stepen = 2;


            Console.WriteLine($"комплекные числа: {complexNum1}, {complexNum2}");
            Console.WriteLine("сумма: " + complexNum1.Add(complexNum2));
            Console.WriteLine("разность: " + complexNum1.Deduct(complexNum2));
            Console.WriteLine("произведение: " + complexNum1.Multiply(complexNum2));
            Console.WriteLine("частное: " + complexNum1.Divide(complexNum2));
            Console.WriteLine("возведение в степень: " + complexNum1.Pow(stepen));
            Console.WriteLine("Корень: " + complexNum1.Sqrt());
            Console.WriteLine("Угол: " + complexNum1.Angle());
            Console.ReadKey();
            
        }


    }



    class ComplexNum
    {
        double realPart;
        double imaginaryPart;
        
        
        public ComplexNum(double real, double imaginary)
        {
            realPart = real;
            imaginaryPart = imaginary;
        }

        public ComplexNum Add(ComplexNum num) //сумма
        {
            return new ComplexNum(realPart + num.realPart, imaginaryPart + num.imaginaryPart);
        }

        public ComplexNum Deduct(ComplexNum num) //min
        {
            return new ComplexNum(realPart - num.realPart, imaginaryPart - num.imaginaryPart);
        }

        public ComplexNum Multiply(ComplexNum num) //умнож
        {

            return new ComplexNum(realPart * num.realPart - imaginaryPart * num.imaginaryPart, realPart * num.imaginaryPart + imaginaryPart*num.realPart);
        }

        public ComplexNum Divide(ComplexNum num) //del
        {

            return new ComplexNum((realPart * num.realPart + imaginaryPart * num.imaginaryPart)/(num.realPart* num.realPart + num.imaginaryPart* num.imaginaryPart),
                                    (num.realPart*imaginaryPart - realPart*num.imaginaryPart)/(num.realPart * num.realPart + num.imaginaryPart * num.imaginaryPart));
        }

        public ComplexNum Pow(int k) //степень
        {
            //ComplexNum ans = new ComplexNum(1, 0);//
            ComplexNum ans = this;

            for (int i = 0; i<k; i++)
            {
                ans = Multiply(this);
            }
            return ans;
        }

        public ComplexNum Sqrt()
        {
            double module = Math.Sqrt((realPart * realPart) + (imaginaryPart * imaginaryPart));
            double angle = Math.Atan2(imaginaryPart, realPart);
            
            double sqrtModule = Math.Sqrt(module);
            double halfAngle = angle / 2;
            
            double real = sqrtModule * Math.Cos(halfAngle);
            double imag = sqrtModule * Math.Sin(halfAngle);
            return new ComplexNum(real, imag);
            
        }
        
        public double Angle()
        {
            return Math.Atan2(imaginaryPart, realPart);
        }

        public override string ToString() //чтобы выводился результат
        {
            return $"{realPart} + {imaginaryPart}i";
        }

    }
  
}




