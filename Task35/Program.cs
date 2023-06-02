﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArrayRndInt(int size, int min, int max)
{
Random rnd = new Random();
int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
arr[i] = rnd.Next(min, max + 1);
}
return arr;
}

void PrintArray(int[] arr)
{
Console.WriteLine("");
Console.Write("[");
for (int i = 0; i < arr.Length - 1; i++)
{
Console.Write($"{arr[i]}, ");
}
Console.Write($"{arr[arr.Length - 1]}]");
}

int CountTwoDig(int[] arr)
{
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
if (arr[i] >= 10 && arr[i] <= 99) count += 1;
}
return count;
}

int[] array = CreateArrayRndInt(10, 0, 100);
PrintArray(array);
int count = CountTwoDig(array);
Console.WriteLine($" -> {count}");