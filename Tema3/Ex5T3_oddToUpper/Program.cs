using System;

namespace Ex5T3_oddToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] v = new char[] { 'a', 'a', 'b','b', 'c', 'c', 'd', 'd', 'e', 'e', 'f', 'f' };
            char[] v1 = new char[v.Length];
            for (int i = 0; i < v.Length; i++)
            {
                if (i % 2 == 0)
                {
                    v1[i] = char.ToUpper(v[i]);
                    // Console.WriteLine(char.ToUpper(v[i]));
                        }
                else
                {
                    v1[i] = v[i];
                    //Console.WriteLine(v[i]);
                }

                    Console.WriteLine(v1[i]);

                


            }
        }
    }
}
