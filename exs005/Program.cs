// Найти максимальное из трех чисел
Console.WriteLine("Введите первое число ");
double num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
double num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
double num3 = Convert.ToInt32(Console.ReadLine());
double Max = num1;

if (num2 > Max) Max = num2;
if (num3 > Max) Max = num3;

Console.Write("Максимальное ");
Console.WriteLine(Max);
