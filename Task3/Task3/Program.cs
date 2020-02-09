using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число элементов ряда Фибоначчи n: ");
            string N = Console.ReadLine();

            if (int.TryParse(N, out int n) && n > 0)
            {
                ulong[] array = new ulong[n + 2];
                array[0] = 0;
                array[1] = 1;
                for (int i = 0; i <= n - 1; i++)
                {
                    array[i + 2] = array[i] + array[i + 1];
                    Console.WriteLine(array[i]);
                }
                Console.Write("\nВведите номер интересующего элемента ряда Фибоначчи: ");
                string number = Console.ReadLine();
                
                if (int.TryParse(number, out int Number) && Number > 0 && Number <= n)
                {
                    Console.WriteLine($"\n{number} элемент ряда Фибоначчи: {array[Number - 1]}");
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
    }
}
