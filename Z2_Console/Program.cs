﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Z2_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;

            while (true)
            {
                Console.Write("Выберите признак фигуры (к - круг, п - прямоугольник, т - трегольник): ");

                try
                {
                    str = Console.ReadLine();

                    if (str.Length != 1) throw new Exception("Ожидается один символ!");
                    if (str[0] != 'к' && str[0] != 'п' && str[0] != 'т') throw new Exception("Ожидается один из символов (к, п или т)!");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }

            switch (str)
            {
                case "к":
                    Console.WriteLine("Фигура круг успешно выбрана!");
                    double round_radius = 0.0;
                    while (true)
                    {
                        try
                        {
                            Console.Write("Введите радиус круга для расчета периметра и площади: ");
                            round_radius = double.Parse(Console.ReadLine());

                            if (round_radius <= 0) throw new Exception("Радиус круга не может быть меньше или равен нулю!");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка: {ex.Message}");
                        }
                    }

                    Console.WriteLine($"Периметр круга равен: {2 * Math.PI * round_radius}, площадь круга равна: {Math.PI * round_radius * round_radius}");
                    break;
                case "п":
                    Console.WriteLine("Фигура прямоугольник успешно выбрана!");
                    double square_side1 = 0.0;
                    double square_side2 = 0.0;

                    while (true)
                    {
                        try
                        {
                            Console.Write("Введите величину первой стороны прямоугольника для расчета периметра: ");
                            square_side1 = double.Parse(Console.ReadLine());

                            Console.Write("Введите величину второй стороны прямоугольника для расчета периметра: ");
                            square_side2 = double.Parse(Console.ReadLine());

                            if (square_side1 <= 0 || square_side2 <= 0)
                                throw new Exception("Стороны прямоугольника не могут быть меньше или равны нулю!");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка: {ex.Message}");
                        }
                    }

                    Console.WriteLine($"Периметр прямоугольника равен: {square_side1 * 2 + square_side2 * 2}, площадь прямоугольника равна: {square_side1 * square_side2}");
                    break;
                case "т":
                    Console.WriteLine("Фигура треугольник успешно выбрана!");
                    double triangle_side1 = 0.0;
                    double triangle_side2 = 0.0;
                    double triangle_side3 = 0.0;

                    double triangle_coreSide = 0.0;
                    double triangle_height = 0.0;
                    while (true)
                    {
                        try
                        {
                            Console.Write("Выберите по какому признаку искать периметр и площадь:\n1 - По трем сторонам и высоте\n" +
                                "2 - По двум сторонам и высоте\nВведите действие: ");
                            str = Console.ReadLine();
                            if (str.Length != 1) throw new Exception("Ожидается один символ!");
                            if (str[0] != '1' && str[0] != '2') throw new Exception("Ожидается один из символов (1 или 2)!");
                            if (str[0] == '1')
                            {
                                Console.Write("Введите величину первой стороны треугольника для расчета периметра: ");
                                triangle_side1 = double.Parse(Console.ReadLine());

                                Console.Write("Введите величину второй стороны треугольника для расчета периметра: ");
                                triangle_side2 = double.Parse(Console.ReadLine());

                                Console.Write("Введите величину третьей стороны треугольника для расчета периметра: ");
                                triangle_side3 = double.Parse(Console.ReadLine());


                                Console.Write("Введите высоту треугольника для расчета площади: ");
                                triangle_height = double.Parse(Console.ReadLine());

                                Console.Write("Введите величину основания треугольника для расчета площади: ");
                                triangle_coreSide = double.Parse(Console.ReadLine());

                                if (triangle_side1 <= 0 || triangle_side2 <= 0 || triangle_side3 <= 0) throw new Exception("Стороны треугольника не могут быть меньше или равны нулю!");
                                if (triangle_height <= 0 || triangle_coreSide <= 0) throw new Exception("Основание треугольника или его высота не могут быть меньше или равны нулю!");
                                Console.WriteLine($"Периметр треугольника равен: {triangle_side1 + triangle_side2 + triangle_side3}, площадь треугольника равна: {(triangle_coreSide * triangle_height) / 2}");
                            }
                            else if (str[0] == '2')
                            {
                                Console.Write("Введите величину основания треугольника: ");
                                double triangle_base = double.Parse(Console.ReadLine());

                                Console.Write("Введите величину боковой стороны треугольника для расчета периметра: ");
                                double triangle_aside = double.Parse(Console.ReadLine());

                                Console.Write("Введите высоту треугольника для расчета площади: ");
                                triangle_height = double.Parse(Console.ReadLine());

                                if (triangle_base <= 0 || triangle_aside <= 0 || triangle_height <= 0) throw new Exception("Стороны треугольника не могут быть меньше или равны нулю!");
                                Console.WriteLine($"Периметр треугольника равен: {2 * triangle_aside + triangle_base}, площадь треугольника равна: {(triangle_base * triangle_height) / 2}");
                            }
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка: {ex.Message}");
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
