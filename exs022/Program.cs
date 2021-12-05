// Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x <99999 & x>10000)
{
    int num = x/1000;
    int num1 = num/10;
    int num2 = num%10;
    int num3 = x/1000;
    int num4 = num3/10;
    int num5 = num3%10;

     if ((num1 == num5) & (num2 == num4))
     {
    Console.WriteLine("Это число палиндром!");
     }
    else
     {
    Console.WriteLine("Это число НЕ палиндром!");
     }
}
else
{
    Console.WriteLine("Ввели неверное число!");
}