// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;

class Program {
    static void Main() {
        int[] arr1 = new int[] {3, 7, 23, 12};
        int[] arr2 = new int[] {-4, -6, 89, 6};
        
        int sum1 = GetSumOfOddIndexElements(arr1);
        Console.WriteLine(sum1); // выводим сумму элементов, стоящих на нечетных позициях массива arr1

        int sum2 = GetSumOfOddIndexElements(arr2);
        Console.WriteLine(sum2); // выводим сумму элементов, стоящих на нечетных позициях массива arr2
    }

    static int GetSumOfOddIndexElements(int[] arr) {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++) {
            if (i % 2 != 0) { // если индекс элемента нечетный, то добавляем его значение к сумме
                sum += arr[i];
            }
        }
        return sum;
    }
}