using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            string x = Console.ReadLine();
            int n = int.Parse(x);
            if (n % 2 == 0)
            {
                Console.WriteLine("The number " + n + "  is even");
            }
            else
            {
                Console.WriteLine("The number " + n + " is odd");
            }
        }
    }
}
