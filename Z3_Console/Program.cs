using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Введите числа или введите 0, чтобы остановить ввод: ");
            while (true)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());

                    if (number == 0) break;

                    numbers.Add(number);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }


            Console.Write("Трехзначные числа, в которых хотя бы две цифры повторяются: ");

            foreach(int number in numbers)
            {
                if (Math.Abs(number).ToString().Length != 3) continue;

                int abs_number = Math.Abs(number);

                int first = abs_number / 100;
                int second = abs_number % 100 / 10;
                int third = abs_number % 100 % 10;

                if (first == second || second == third || third == first)
                    Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
