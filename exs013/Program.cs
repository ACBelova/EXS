// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число ");
var n = Math.Abs(Convert.ToInt64(Console.ReadLine()));
        while (n >= 100)
        {
            n /= 10;
        }
        var r = n % 10;
        Console.WriteLine("Вторая цифра ");
        Console.WriteLine(r);