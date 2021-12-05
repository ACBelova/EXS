// Определить количество цифр в числе
Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int digits = 0; // кол-во цифр
while (A != 0)
{
  digits++;
  A = (int)(A/10);
}
Console.WriteLine($"В этом числе содержится: {digits} цифр ");
