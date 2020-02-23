using System;

namespace Ex6T3_intPlusDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[] { 4, 5, 6, 7, 8, 9, 23, 45, 68, 79 };
            double d = 2.5;
            double[] dv = new double[v.Length];
            for (int i = 0; i < v.Length; i++)
            {
                dv[i] = v[i] + d;
                Console.WriteLine(dv[i]);
            }
        }
    }
}

