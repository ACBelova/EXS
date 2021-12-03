// Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
Console.Write("Введите число обозначающее день недели ");
try
{
    int a = Convert.ToInt32(Console.ReadLine());
    switch (a)
    {
        case 1:
            Console.WriteLine("Рабочий день");
            break;
        case 2:
            Console.WriteLine("Рабочий день");
            break;
        case 3:
            Console.WriteLine("Рабочий день");
            break;
        case 4:
            Console.WriteLine("Рабочий день");
            break;
        case 5:
            Console.WriteLine("Рабочий день");
            break;
        case 6:
            Console.WriteLine("Выходной день");
            break;
        case 7:
            Console.WriteLine("Выходной день");
            break;
        default:
            Console.WriteLine("Такого номер дня недели нет");
            break;
    }
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}