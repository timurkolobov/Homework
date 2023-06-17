// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


using System;

class Program 
{
    static void Main(string[] args) 
    {
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());
        int sum = 0;

        while (num > 0) 
        {
            sum += num % 10;
            num /= 10;
        }

        Console.WriteLine($"Сумма цифр числа: {sum}");
    }
}