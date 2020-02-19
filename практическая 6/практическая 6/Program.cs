using System;


namespace практическая_6
{
    class Program
    {

        static void Main(string[] args)
        {
            int n=10;
            int m=15;
            int[,] a = CreateArray(n, m, 10);
            ShowArray(a, n, m);
            int[] b = new int[m];
            int []c = new int[n];
            int []meanValue = new int[n];
            for (int i = 0; i < n; i++)
            {
                int s = 0;
                int p = 1;
                for (int j = 0; j <m ; j++)
                {
                    p *= a[i, j];
                    s += a[i, j];
                    c[i] = p;
                    meanValue[i] = s / m;
                }
             Console.WriteLine("znacheniya: " + b[i]+ ", "+c[i]+ ", "+meanValue[i]);
            }
            for (int i = 0; i < n; i++)
            {
                int s = 0;
                for (int j = 0; j < m; j++)
                {
                    b[j]+= a[i, j];

                }
                b[i] = s;

            }
        }
        static int[,] CreateArray(int n, int m, int value)
        {
            int[,] a = new int[n, m];
            var rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rand.Next(value);
                }
            }
            return a;
        }
        static void ShowArray(int[,] a, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
