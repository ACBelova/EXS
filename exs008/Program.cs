// Показать числа от -N до N
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = -N; i <=N; i++)
{
    Console.Write("{0}, ", (i));
}
