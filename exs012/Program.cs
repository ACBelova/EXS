// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int x = 0;
int m = 82;
for (; m !=0; m/=10)
 {
  int r = m % 10;
  if (r > x) x = r;
 }
 Console.WriteLine(x);