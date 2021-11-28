// Показать четные числа от 1 до N
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
if (i % 2 == 0) Console.Write("{0}, ", i);