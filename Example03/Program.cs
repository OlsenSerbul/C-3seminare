﻿// Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 2D
Console.Write("Введите координаты первой точки: X = ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты первой точки: Y = ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты второй точки: X = ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты второй точки: Y = ");
int Y2 = Convert.ToInt32(Console.ReadLine());

double FindDistance( int X1, int Y1, int X2, int Y2)
{
    double distance = 0;
    distance = Math.Sqrt(Math.Pow(X2-X1, 2) + Math.Pow(Y2-Y1, 2));
    return distance;

}


double distance = FindDistance( X1, Y1, X2, Y2);
Console.WriteLine(distance);

