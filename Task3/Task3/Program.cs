using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число элементов ряда Фибоначчи n: ");
            string N = Console.ReadLine();
            if (int.TryParse(N, out int n))
            {
                if (n >= 0)
                {
                    ulong F0 = 0; // Первое число ряда Фибоначчи
                    ulong F1 = 1; // Второе число ряда фибоначчи
                    ulong sum;
                    Console.WriteLine("\nРяд Фибоначчи:");
                    Console.WriteLine($"{F0}");
                    Console.WriteLine($"{F1}");
                    for (int i = 1; i <= n-2; i++)
                    {
                        sum = F0 + F1;
                        F0 = F1;
                        F1 = sum;
                        Console.WriteLine($"{sum}");
                    }
                }
                else Console.WriteLine("Число элементов не может быть отрицательным");

            }
            else Console.WriteLine("Значение введено неверно");
            Console.ReadKey(true);
        }
    }
}
