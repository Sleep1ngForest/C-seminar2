﻿// Задача №10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
//Пример:
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
string numberS = Math.Abs(number).ToString();
Console.WriteLine(numberS.Length == 3 ? $"{number} -> {numberS[1]}" : "Вы ввели не трехзначное число");