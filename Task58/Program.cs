// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;

class Program {
  static void Main(string[] args) {
    int[,] matrixA = { { 1, 2 }, { 3, 4 } };
    int[,] matrixB = { { 5, 6 }, { 7, 8 } };
    int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);

    for (int i = 0; i < resultMatrix.GetLength(0); i++) {
      for (int j = 0; j < resultMatrix.GetLength(1); j++) {
        Console.Write(resultMatrix[i, j] + " ");
      }
      Console.WriteLine();
    }   
  }

  static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB) {
    int rowsA = matrixA.GetLength(0);
    int columnsA = matrixA.GetLength(1);
    int rowsB = matrixB.GetLength(0);
    int columnsB = matrixB.GetLength(1);

    if (columnsA != rowsB) {
      throw new Exception("Number of columns in matrixA must match number of rows in matrixB");
    }

    int[,] resultMatrix = new int[rowsA, columnsB];

    for (int i = 0; i < rowsA; i++) {
      for (int j = 0; j < columnsB; j++) {
        for (int k = 0; k < columnsA; k++) {
          resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
        }
      }
    }

    return resultMatrix;
  }
}
