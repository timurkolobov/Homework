// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;

namespace Ackermann {
    class Program {
        static void Main(string[] args) {
            Console.Write("Введите m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("A(m,n) = " + Ackermann(m, n));
            Console.ReadKey();
        }
        
        static int Ackermann(int m, int n) {
            if (m == 0) {
                return n + 1;
            }
            else if (n == 0) {
                return Ackermann(m - 1, 1);
            }
            else {
                return Ackermann(m - 1, Ackermann(m, n - 1));
            }
        }
    }
}