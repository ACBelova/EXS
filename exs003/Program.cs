// Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) 
{
    Console.WriteLine(a + " " + b); 

}
else Console.WriteLine(b + " " + a);
