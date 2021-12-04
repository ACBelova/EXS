// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// X  Y  X∨Y ¬X∨Y	¬X	¬Y	¬X∧¬Y  ¬X∨Y≡¬X∧¬Y
// 0  0	 0  	1	 1   1	  1	     1
// 0  1  1  	0	 1   0	  0	     1
// 1  0  1  	0    0	 1	  0	     1
// 1  1	 1  	0    0	 0	  0	     1

Console.Write("Введите значение x true или false: ");
bool x = bool.Parse(Console.ReadLine());
Console.Write("Введите значение y true или false: ");
bool y = bool.Parse(Console.ReadLine());
bool a =!(x||y) == !x ^ !y;
Console.WriteLine(a);