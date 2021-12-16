// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
for (int i = x; i <= y; i++)
{
  if (i%2==0) Console.WriteLine($"{Math.Pow(i,3)}");
}

