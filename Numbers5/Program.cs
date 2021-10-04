using System;

namespace Numbers5
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите текст: ");
            string text1 = Console.ReadLine();
            Console.Write("Введите число: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Введите текст: ");
            string text2 = Console.ReadLine();
            Console.Write("Введите число: ");
            int number2 = int.Parse(Console.ReadLine());
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
