// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;

namespace SumOfNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число M: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите число N: ");
            int n = int.Parse(Console.ReadLine());

            int sum = Sum(m, n); // вызов рекурсивной функции

            Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {sum}");
        }

        static int Sum(int m, int n)
        {
            if (m == n)
            {
                return m; // базовый случай
            }
            else
            {
                return m + Sum(m + 1, n); // рекурсивный случай
            }
        }
    }
}