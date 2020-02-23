using System;

namespace Ex4T3_stringToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Ana are mere";
            int len = s.Length;
            char[] v = new char[len];
            for (int i = 0; i < len ; i++)
            {
                    v[i] = s[i];
                    Console.Write(v[i]);
            }

        }
    }
} // din ce am gasit pe net mai este char[] v = s.toCharArray().....
