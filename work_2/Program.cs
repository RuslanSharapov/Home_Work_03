﻿// Подсчитать сумму цифр в числе

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sum = 0;

while (number > 0)
{
    int digit = number % 10;
    sum = sum + digit;
    number = number / 10;
}

Console.WriteLine($"Сумма равна {sum}");