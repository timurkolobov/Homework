// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

using System;

namespace ArrayElement
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] arr = { { 1.0, 2.0, 3.0 }, { 4.0, 5.0, 6.0 } };
            int row, col;

            Console.WriteLine("Введите позицию элемента массива:");

            Console.Write("Строка: ");
            row = int.Parse(Console.ReadLine());

            Console.Write("Столбец: ");
            col = int.Parse(Console.ReadLine());

            if (row >= arr.GetLength(0) || col >= arr.GetLength(1) || row < 0 || col < 0)
            {
                Console.WriteLine("Такого элемента в массиве нет");
            }
            else
            {
                Console.WriteLine("Значение элемента: {0}", arr[row, col]);
            }

            Console.ReadKey();
        }
    }
}