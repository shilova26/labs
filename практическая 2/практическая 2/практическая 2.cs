using System;

namespace практическая_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите n:");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine( Rez(x, n));
            Console.ReadLine();
        }

        public static double Rez(double x, double n)
        {
            double c=1, s=0;
            for (int i=0; i<=n; i++)
            {
                c = c / (x + i);
                s += c;
            }
            return s;
        }
      
    }
}
        
