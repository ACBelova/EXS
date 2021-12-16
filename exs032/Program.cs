// ## Почувствуй себя сеньором*
// Задать массив из 8 элементов и вывести их на экран 
int[] arr = { 1, 8, 9, 5, 7, 5, 4, 6 };
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
