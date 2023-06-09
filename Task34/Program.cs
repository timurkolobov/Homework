﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System;

class Program {
    static void Main() {
        int[] arr = new int[4]; // создаем массив на 4 элемента
        Random rnd = new Random(); // создаем экземпляр класса Random

        // заполнение массива случайными трехзначными числами
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = rnd.Next(100, 1000);
            Console.Write(arr[i] + " "); // выводим элементы массива на экран
        }

        Console.WriteLine(); // перевод каретки на новую строку

        // подсчет количества четных чисел в массиве
        int count = 0;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] % 2 == 0) { // проверяем, является ли число четным
                count++;
            }
        }

        // вывод результата
        Console.WriteLine("Количество чётных чисел в массиве: " + count);
    }
}