﻿//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int num3 = int.Parse(Console.ReadLine());

        int max = num1;

        if (num2 > max)
        {
            max = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }

        Console.WriteLine($"Максимальное число: {max}");
        Console.ReadKey();
    }
}
