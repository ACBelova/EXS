﻿// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((a%100)/10);