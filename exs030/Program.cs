// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int composition = 1;
for (int i = 1; i <= x; i++)
{
    composition = composition * i;
    Console.Write($"{i} * ");
}
Console.WriteLine($"= " + composition);
