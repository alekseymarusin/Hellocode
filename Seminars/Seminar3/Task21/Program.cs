﻿// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

double Distance()
{
    Console.Write("Введите координату x1 ");
    double x1 = Convert.ToDouble(Console.ReadLine()); 
    Console.Write("Введите координату x2 ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату y1 ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координату y2 ");
    double y2 = Convert.ToDouble(Console.ReadLine());
    double res = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));

    return res;
}
try
{
    Console.WriteLine(Distance());
}
catch
{
    Console.WriteLine("123");
}