using System;

namespace Numbers5
{
    internal class Program
    {
        static void Main()
        {
            for (var i = 1; i <= 100; i++)
            {
                var dividesBy3 = i % 3 == 0;
                var dividesBy5 = i % 5 == 0;

                if (dividesBy3 && dividesBy5)
                    Console.WriteLine("OuuMay");
                else if (dividesBy3)
                    Console.WriteLine("Ouu");
                else if (dividesBy5)
                    Console.WriteLine("May");
                else
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
