// Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Введите число ");
int i;
Int32.TryParse(Console.ReadLine(), out i);
Console.Write((i % 7 == 0) && (i % 23 == 0) ? "кратно 7 и 23" : "не кратно 7 и 23");
Console.ReadLine();





