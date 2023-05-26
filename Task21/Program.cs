// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите координаты первой точки (x,y,z): ");
        string point1 = Console.ReadLine();
        string[] coordinates1 = point1.Split(",");
        
        Console.Write("Введите координаты второй точки (x,y,z): ");
        string point2 = Console.ReadLine();
        string[] coordinates2 = point2.Split(",");

        double x1 = double.Parse(coordinates1[0]);
        double y1 = double.Parse(coordinates1[1]);
        double z1 = double.Parse(coordinates1[2]);

        double x2 = double.Parse(coordinates2[0]);
        double y2 = double.Parse(coordinates2[1]);
        double z2 = double.Parse(coordinates2[2]);

        // Расчет расстояния между двумя точками в 3D пространстве
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {distance}");
    }
}
