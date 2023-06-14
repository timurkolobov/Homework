// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] CreateFillMatrix(int m, int n, int min, int max)
{
int[,] arr = new int[m, n];
var rnd = new Random();
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
arr[i, j] = rnd.Next(min, max + 1);
}
}
return arr;
}

void PrintMatrix(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{

for (int j = 0; j < arr.GetLength(1); j++)
{
Console.Write($"{arr[i, j],4}");
}

Console.WriteLine();
}
}

int[] FindMin(int[,] matr)
{
int[] minIndexes = new int[2];
int minElem = matr[0, 0];
for (int i = 0; i < matr.GetLength(0); i++)
}