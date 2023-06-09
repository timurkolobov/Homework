// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;

namespace RandomArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] arr = new double[3, 4];
            Random rand = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = Math.Round(rand.NextDouble() * 20 - 10, 1);
                }
            }

            // вывод массива на консоль
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,9}", arr[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}