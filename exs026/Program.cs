﻿// Найти сумму чисел от 1 до А
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= x; i++)
{
    sum += i;
    Console.WriteLine("Сумма чисел от " + 1 + " до " + i + ": " + sum);

}
