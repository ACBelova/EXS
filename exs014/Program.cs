// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число ");
int a;
a = Convert.ToInt32(Console.ReadLine());
if (a % 3 == 0)
Console.WriteLine("Число {0} кратно 3", a);
   
else Console.WriteLine("Число {0} не кратно 3", a);
