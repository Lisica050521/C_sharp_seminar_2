﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
    int a = int.Parse(Console.ReadLine());
    int b = a / 10 % 10;

    if (a <= 100 | a > 999)
{
  Console.Write("Вы ввели не трехзначное число");
}

else {
  Console.WriteLine(b);
}
