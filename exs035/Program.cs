﻿// Написать программу замену элементов массива на противоположные   

int[] array = { 2, 3, 5, -5, 9, 9, -4, -7 };

    for (int i = 0; i < array.Length; i++)
    {
      Console.Write($"{array[i]*-1} ");
    }
    
