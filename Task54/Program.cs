// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
        
        
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols - 1; j++) {
                for (int k = j + 1; k < cols; k++) {
                    if (arr[i, k] > arr[i, j]) {
                        int temp = arr[i, k];
                        arr[i, k] = arr[i, j];
                        arr[i, j] = temp;
                    }
                }
            }
        }
        
        
        Console.WriteLine("Измененный массив:");
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                Console.Write("{0} ", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}
