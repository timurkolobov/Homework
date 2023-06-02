// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System;

class Program {
    static void Main() {
        int[] arr1 = new int[] {1, 2, 5, 7, 19}; // создаем массив arr1
        int[] arr2 = new int[] {6, 1, 33}; // создаем массив arr2
        
        PrintArray(arr1); // выводим arr1 на экран
        PrintArray(arr2); // выводим arr2 на экран
    }

    static void PrintArray(int[] arr) {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++) {
            if (i == arr.Length - 1) {
                Console.Write(arr[i]);
            } else {
                Console.Write(arr[i] + ", ");
            }
        }
        Console.WriteLine("]");
    }
}