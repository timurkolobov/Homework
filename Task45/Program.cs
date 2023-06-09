// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

void ArrayCopy(int[] arr1, int[] arr2)
{
for (int i = 0; i < arr1.Length; i++)
{
arr2[i] = arr1[i];
}
}

int[] CreateRndArray(int size, int min, int max)
{
int[] array = new int[size];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rnd.Next(min, max + 1);
}
return array;
}

void PrintArray(int[] arr)

{
Console.Write("[");
for (int i = 0; i < arr.Length - 1; i++)
{
Console.Write($"{arr[i]}, ");
}
Console.WriteLine($"{arr[arr.Length - 1]}]");
}

int[] array1 = CreateRndArray(8, 4, 10);
PrintArray(array1);
int[] array2 = CreateRndArray(8, 3, 123);
PrintArray(array2);
ArrayCopy(array1, array2);
PrintArray(array2);