// Удалить вторую цифру трёхзначного числа, *и вывести это число в консоль

Console.WriteLine("Введите трехзначное число ");
var n = Math.Abs(Convert.ToInt64(Console.ReadLine()));
int y = int.Parse(n.ToString().Remove(1, 1));
Console.WriteLine(y);