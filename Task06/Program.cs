﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} является четным числом.");
        }
        else
        {
            Console.WriteLine($"{num} не является четным числом.");
        }

        Console.ReadKey();
    }
}