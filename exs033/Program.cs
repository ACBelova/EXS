// Задать массив из 8 элементов, заполненных нулями и единицами и вывести их на экран
int[] arr = { 1, 0, 0, 1, 1, 0, 0, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);