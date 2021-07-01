using System;

namespace EvenNumberConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool BitwiseMethod=false;
            while (true)
            {
                Console.WriteLine("Введите число");
                string output = Console.ReadLine();
                int number;
                bool success = Int32.TryParse(output, out number);
                if (success)
                {
                    if (BitwiseMethod)
                    {
                        Console.WriteLine(IsEvenBitwise(number)? "Число четное": "Число нечетное");
                        BitwiseMethod = false;
                    }
                    else
                    {
                        Console.WriteLine(IsEven(number) ? "Число четное" : "Число нечетное");
                        BitwiseMethod = true;
                    }
                }
                else
                {
                    Console.WriteLine($"Вы ввели неверное значение: {output}. Попробуйте еще раз");
                }
            }
        }
        private static bool IsEven(int number)
        {
            return (number % 2) == 0;
        }
        private static bool IsEvenBitwise(int number)
        {
            return (number & 1) == 0;
        }
    }
}
