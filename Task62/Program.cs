// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

sing System;

class Program {
  static void Main(string[] args) {
    int[,] array = new int[4, 4];
    PopulateSpiralArray(array);

    for (int i = 0; i < array.GetLength(0); i++) {
      for (int j = 0; j < array.GetLength(1); j++) {
        Console.Write(array[i, j] + " ");
      }
      Console.WriteLine();
    }   
  }

  static void PopulateSpiralArray(int[,] array) {
    int value = 1;
    int size = array.GetLength(0);
    int row = 0;
    int col = -1;
    int dx = 1;
    int dy = 0;

    while (size > 0) {
      for (int i = 0; i < size; i++) {
        col += dx;
        array[row, col] = value++;
      }
      size--;
      for (int i = 0; i < size; i++) {
        row += dy;
        array[row, col] = value++;
      }
      dx = -dx;
      dy = -dy;
    }
  }
}