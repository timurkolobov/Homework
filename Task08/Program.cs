//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Четные числа от 1 до N: ");
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write($"{i} ");
            }
        }

        Console.ReadKey();
    }
}