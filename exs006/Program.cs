// Написать программу вычисления значения функции y = f(x), где f(x)= 3х*2+9sqrх

double f(double x)
{
    return 3 * Math.Pow(2, x) + 9 * Math.Sqrt(x);
}
int x = 2;

double result = 0;
while (x <= 10)
{
    result = result + f(x);
    x++;
}

Console.Write("Результат: ");
Console.WriteLine(result);

