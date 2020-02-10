using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число элементов ряда Фибоначчи n: ");
            string n = Console.ReadLine();

            if (int.TryParse(n, out int parsedN) && parsedN > 0)
            {
                for (int i = 1; i <= parsedN; i++)
                {
                    int numberFibonachi = Fibonachi(i);
                    Console.WriteLine(numberFibonachi);
                }
                Console.Write("\nВведите номер интересующего элемента ряда Фибоначчи: ");
                string number = Console.ReadLine();

                if (int.TryParse(number, out int parsedNumber) && parsedNumber > 0 && parsedNumber <= parsedN)
                {
                    int num = Fibonachi(parsedNumber);
                    Console.WriteLine($"\n{parsedNumber} элемент ряда Фибоначчи: {num}");
                }
                else
                {
                    Console.WriteLine("Значение введено неверно.");
                }
            }
            else
            {
                Console.WriteLine("Значение введено неверно.");
            }
            Console.ReadKey(true);
        }

        static int Fibonachi(int n)
        {
            if (n == 1 || n == 2)
            {
                return n-1;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
    }
}
