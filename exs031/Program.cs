// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
while (x%2==0)
{
  for (int i = 1; i <= x; i++)
{
    Console.WriteLine($"Куб числа {i} = {Math.Pow(i,3)}");

}
}
