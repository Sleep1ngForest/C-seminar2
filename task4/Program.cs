﻿// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8



Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 1000 && N > 99)
{
int ost = N % 10; //  456 / 10 = 45.6  23%7 = 
Console.Write(ost);
}
else
{
Console.Write("введите трехзначное число");
}

// Console.WriteLine(56%21);