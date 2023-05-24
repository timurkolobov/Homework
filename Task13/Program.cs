// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int thirdDigit = (number / 100) % 10;
        
        if (thirdDigit > 0)
        {
            Console.WriteLine($"Третья цифра числа {number} равна {thirdDigit}");
        }
        else
        {
            Console.WriteLine($"Третьей цифры числа {number} нет");
        }
    }
}