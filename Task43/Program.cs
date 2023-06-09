﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение k1: ");
        double k1 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение b1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение k2: ");
        double k2 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение b2: ");
        double b2 = double.Parse(Console.ReadLine());

        if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны, точки пересечения нет");
        }
        else
        {
            double x = (b2 - b1) / (k1 - k2); // находим значение x
            double y = k1 * x + b1; // находим соответствующее значение y

            Console.WriteLine($"Точка пересечения: ({x:N1}; {y:N1})");
        }

        Console.ReadLine();
    }
}