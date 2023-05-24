//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine($"{num1} больше, чем {num2}");
        }
        else if (num1 < num2)
        {
            Console.WriteLine($"{num2} больше, чем {num1}");
        }
        else
        {
            Console.WriteLine("Оба числа равны");
        }

        Console.ReadKey();
    }
}