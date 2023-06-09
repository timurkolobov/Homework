// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите числа через запятую: ");
        string inputStr = Console.ReadLine();
        string[] inputArr = inputStr.Split(',');
        int count = 0;

        foreach (string number in inputArr)
        {
            int parsedNumber = int.Parse(number.Trim());
            
            if (parsedNumber > 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество чисел, больших 0: {count}");
        Console.ReadLine();
    }
}
