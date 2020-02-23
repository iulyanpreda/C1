using System;

namespace Ex3T3_VectoNegPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[] { 15, 6, 17, 19, -25, 3, 2, 6, 5, 89, 78, 35 };
            int negPos = v[0];
            
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < 0)
                    negPos = i;          
            }
            Console.WriteLine("elementul negativ este la pozitia " + negPos + " a vectorului");
        }
    }
}
