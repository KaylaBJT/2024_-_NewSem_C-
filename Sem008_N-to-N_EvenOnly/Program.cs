﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число: ");

int N = int.Parse(Console.ReadLine());

for (int i = 2; i <= N; i += 2)
{
    if (i == N) { Console.Write($"{i} "); }
    else Console.Write($"{i}, ");
}