// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] array = { 2, 3, 5, -5, 9, 9, -4, 1 , 6, 4, 9, 2};
int sumarray = 0;
for (int j = 0; j < array.Length; j++)
    if (array[j] < 0)
        sumarray += array[j];
        Console.WriteLine($"Сумма отрицательных элементов {sumarray} ");
     for (int i = 0; i < array.Length; i++)
     if (array[i] > 0)
        sumarray += array[i];
        Console.WriteLine($"Сумма положительных элементов {sumarray} ");

