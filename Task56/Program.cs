// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;

class Program {
    static void Main(string[] args) {
        int rows = 3; 
        int cols = 4; 
        
        
        int[,] arr = new int[rows, cols] {
            {10, 20, 5, 40},
            {15, 35, 25, 45},
            {3, 9, 18, 12}
        };
        
        
        Console.WriteLine("Изначальный массив:");
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                Console.Write("{0} ", arr[i, j]);
            }
            Console.WriteLine();
        }
        
        
        int smallestRowSum = Int32.MaxValue;
        int smallestRowIndex = -1;
        
        for (int i = 0; i < rows; i++) {
            int rowSum = 0;
            for (int j = 0; j < cols; j++) {
                rowSum += arr[i, j];
            }
            if (rowSum < smallestRowSum) {
                smallestRowSum = rowSum;
                smallestRowIndex = i;
            }
        }
        
        
        Console.WriteLine("Строка с наименьшей суммой элементов: {0}", smallestRowIndex);
    }
}