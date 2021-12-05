// Найти кубы чисел от 1 до N
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    Console.WriteLine($"Куб числа {i} = {Math.Pow(i,3)}");

}

