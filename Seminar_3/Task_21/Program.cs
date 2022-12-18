﻿// Задача №21.Работа в группах
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 2D пространстве.
// ● A (3,6); B(2, 1)-> 5,09
// ● A(7, -5); B(1, -1)-> 7,21

Console.Write("Введите координаты точки A (x): ");
double coordinateAx = double.Parse(Console.ReadLine());
Console.Write("Введите координаты точки A (y): ");
double coordinateAy = double.Parse(Console.ReadLine());

Console.Write("Введите координаты точки B (x): ");
double coordinateBx = double.Parse(Console.ReadLine());
Console.Write("Введите координаты точки B (y): ");
double coordinateBy = double.Parse(Console.ReadLine());

double length = Math.Sqrt(Math.Pow((coordinateBx - coordinateAx), 2) + 
Math.Pow((coordinateAy - coordinateBy), 2));

Console.WriteLine(length);