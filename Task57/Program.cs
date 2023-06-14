// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.



void CountFrequencies(int[] array)
{
int currentNumber = array[0];
int count = 1;
for (int i = 1; i < array.Length; i++)
{
if (array[i] == currentNumber) count++;
else
{
Console.WriteLine($"Число {currentNumber} встречается {count} раз");
currentNumber = array[i];
count = 1;
}
}
Console.WriteLine($"Число {currentNumber} встречается {count} раз");
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 9);
int[] array = MatrixToArray(array2d);
Array.Sort(array);

PrintMatrix(array2d);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
CountFrequencies(array);