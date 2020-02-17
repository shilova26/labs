

using System;

namespace практическая_4
{
    class Program
    {

        public static int Fact(int n)
        {
            int fact = 1;
            if (n != 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
            }
            return fact;
        }

        static void Main(string[] args)
        {
            int k;
            int a;
            int sumC=0;
            for (k = 100; k <= 998; k+=2)
            {
                a = k;
                while (a > 0)
                {
                    int l = a % 10;
                    sumC += Fact(l);
                    a /= 10;
                }
                if (k==sumC && k%2==0)
                {
                    Console.WriteLine(k);
                }
            }
            }
           
        }
    }


