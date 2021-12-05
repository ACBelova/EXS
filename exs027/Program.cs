// Возведите число А в натуральную степень B используя цикл

// Console.WriteLine("Введите значение числа А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение степени: ");
// int stepenB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.Pow(A, stepenB));

Console.WriteLine("Введите значение числа А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение степени: ");
int stepenB = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = 1; i <= stepenB; i++);
 {
    result *= A;
    Console.WriteLine($"Число {A} в степени {stepenB}:   {result}");

 }
