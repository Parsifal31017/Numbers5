using System;

namespace Numbers5
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число и текст через запятую: ");
            string[] tokens = Console.ReadLine().Split(',');
            string text1 = tokens[1].Trim();
            int number1 = int.Parse(tokens[0]);
            Console.Write("Введите число и текст через запятую: ");
            string[] token = Console.ReadLine().Split(',');
            string text2 = token[1].Trim();
            int number2 = int.Parse(token[0]);
            for (var i = 1; i <= 100; i++)
            {
                var dividesBy3 = i % number1 == 0;
                var dividesBy5 = i % number2 == 0;

                if (dividesBy3 && dividesBy5)
                    Console.WriteLine(text1 + text2);
                else if (dividesBy3)
                    Console.WriteLine(text1);
                else if (dividesBy5)
                    Console.WriteLine(text2);
                else
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
