// Задать номер четверти, показать диапазоны для возможных координат
// I четверть   (10+,10+)
// II четверть  (-10,+10)
// III четверть (-10,-10)
// IV четверть  (10+,-10)
Console.WriteLine("Введите число от 1 до 4: ");
double x = Convert.ToDouble(Console.ReadLine());
if (x == 1)
{
    Console.Write("(x < 0) , (y > 0)");
}
else if (x == 2)
{
    Console.Write("(x < 0) , (y > 0)");
}
else if (x == 3)
{
    Console.Write("(x < 0) , (y < 0)");
}
else if (x == 4)
{
    Console.Write("(x > 0) , (y < 0)");
}
else 
{
    Console.WriteLine("Вы ввели не правильное число!");
}