using System;

namespace factorial
{
	public class Program
	{
		public static void Main(string[] args)
        {
            int fact = 1;
            Console.WriteLine("Enter value for n :");
            string x = Console.ReadLine();
            int n = int.Parse(x) ;
            if ( n > 13 || n < 0)
            {
                Console.WriteLine("Enter a number beetween 0 and 13");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                    {
                    fact = fact * i;
                    }
                Console.WriteLine("N factorial is: " + fact);

            }

            Console.Read();
        }


    }
}

