using System;

namespace Numbers5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i++ <= 99)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
                else if (i % 3 == 0 & i % 5 == 0)
                {
                    Console.WriteLine("OuuMay");
                }
                else
                {
                    if (i % 3 == 0)
                        Console.WriteLine("Ouu");
                    if (i % 5 == 0)
                        Console.WriteLine("May");
                }
            }
            Console.ReadKey();
        }
    }
}
