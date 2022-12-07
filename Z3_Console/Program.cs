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

            int A = -999, B = 999;

            for (int i = A; i <= B; i++)
            {
                if (Math.Abs(i).ToString().Length != 3) continue;
                numbers.Add(i);
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
