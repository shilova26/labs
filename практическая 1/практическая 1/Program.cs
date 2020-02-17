using System;

namespace практическая_1
{
    class Program
    {
        static void Main(string[] args)
        {
                double a;
                double b;
                Console.WriteLine("Введите два числа");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                if ((a < 0) && (b < 0))
                {
                    a = Math.Abs(a);
                    b = Math.Abs(b);
                }
            
                else if ((a < 0) || (b < 0))
                {
                    a = a + 0.5;
                    b = b + 0.5;
                }
                else if (((a >= 2) || (a <= 0.5)) && ((b >= 2) || (b <= 0.5)))
                {
                    a = a / 10;
                    b = b / 10;
                }

                Console.WriteLine(a + b);

            }
        }
}
