//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;

public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Введите число: "); // запрос на ввод числа
    int number = int.Parse(Console.ReadLine()); // считываем число
    int sum = 0;
    while (number != 0) {
        int digit = number % 10; // получаем последнюю цифру числа
        sum += digit; // добавляем её к сумме цифр
        number /= 10; // отбрасываем последнюю цифру числа
    }
    Console.WriteLine("Сумма цифр в числе: " + sum); // выводим результат
  }
}