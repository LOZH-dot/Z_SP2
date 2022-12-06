using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x0 = 0, y0 = 0;

            while (true)
            {
                try
                {
                    Console.Write("Введите первую координату точки (x): ");
                    x0 = double.Parse(Console.ReadLine());

                    Console.Write("Введите вторую координату точки (y): ");
                    y0 = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }

            if (Math.Abs(x0) < y0 && x0 < 0 && x0 > -23 && y0 < 23 && y0 > 0)
                Console.WriteLine("Точка находится внутри");
            else if (x0 > y0 || y0 < 0 || y0 > 23)
                Console.WriteLine("Точка находится снаружи");
            else
                Console.WriteLine("Точка находится на границе");
        }
    }
}
