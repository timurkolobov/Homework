// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

using System;

class Program {
  static void Main(string[] args) {
    int[,,] array = new int[9, 3, 2];
    int count = 10;
    for (int i = 0; i < 9; i++) {
      for (int j = 0; j < 3; j++) {
        for (int k = 0; k < 2; k++) {
          array[i, j, k] = count++;
        }
      }
    }

    for (int i = 0; i < 9; i++) {
      for (int j = 0; j < 3; j++) {
        Console.Write($"{i},{j},0:00} = {array[i, j, 0]} ");
        Console.Write($"{i},{j},1:00} = {array[i, j, 1]} ");
        Console.WriteLine();
      }
    }
  }
}