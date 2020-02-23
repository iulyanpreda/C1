using System;

namespace Ex2T3_minMaxVector
{
    class Program
    {
        static void Main(string[] args)
         {
            int[] v = new int[] { 15, 6, 17, 19, 25, 3, 2, 6, 5, 89, 78, 35 };
            int min = v[0];
            int max = v[0];
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < min)
                    min = v[i];
                if (v[i] > max)
                    max = v[i];
            }
            Console.WriteLine("Valoare minima a vectorului este " +min);
            Console.WriteLine("Valoarea maxima a vectorului este " +max);

        }
    }
}
