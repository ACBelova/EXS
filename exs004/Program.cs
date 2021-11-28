// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите порядковый номер дня недели ");
int num = Convert.ToInt32(Console.ReadLine());

string[] dayofWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

int n = dayofWeek.Length;
Console.WriteLine(dayofWeek[num-1]);

