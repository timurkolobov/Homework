// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;

namespace AverageInColumn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 2, 3, 4 }, { 5, 6, 7 }, { 8, 9, 10 } };
            
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            for (int i = 0; i < cols; i++)
            {
                int sum = 0;
                for (int j = 0; j < rows; j++)
                {
                    sum += arr[j, i];
                }

                double average = (double)sum / rows;
                
                Console.WriteLine("Среднее арифметическое столбца {0}: {1}", i + 1, average);
            }

            Console.ReadKey();
        }
    }
}
