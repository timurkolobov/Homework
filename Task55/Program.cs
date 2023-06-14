// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

using System;

class Program {
    static void Main(string[] args) {
        int rows = 3; 
        int cols = 4; 
        
        
        int[,] arr = new int[rows, cols] {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };
        
        
        Console.WriteLine("Изначальный массив:");
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                Console.Write("{0} ", arr[i, j]);
            }
            Console.WriteLine();
        }
        
        
        int[,] transposedArr = new int[cols, rows];
        
        
        if (rows == cols) {
            
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    transposedArr[j, i] = arr[i, j];
                }
            }
            
            
            Console.WriteLine("Измененный массив:");
            for (int i = 0; i < cols; i++) {
                for (int j = 0; j < rows; j++) {
                    Console.Write("{0} ", transposedArr[i, j]);
                }
                Console.WriteLine();
            }
        } else {
            
            Console.WriteLine("Замена строк на столбцы невозможна!");
        }
    }
}
