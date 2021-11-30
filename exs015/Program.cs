// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число ");
int a;
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a>99 ? a.ToString()[2] : "третьей цифры нет");
