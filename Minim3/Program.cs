using System;

namespace Minim3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter value for a :");
            string x = Console.ReadLine();
            int a = int.Parse(x);
            Console.WriteLine("Enter value for b :");
            string y = Console.ReadLine();
            int b = int.Parse(y);
            Console.WriteLine("Enter value for c :");
            string z = Console.ReadLine();
            int c = int.Parse(z);
            if (a < b && a < c)
            {
                Console.WriteLine("a " + a + " is minim");
            }
            else
            {
                if (b < c && b < a)
                {
                    Console.WriteLine("b " + b + " is minim");
                }
                else
                {
                    Console.WriteLine("c " + c + " is minim");

                }

            }

            Console.Read();
        }


    }
}
