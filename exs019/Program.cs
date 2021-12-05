// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// X  Y  X∨Y ¬X∨Y	¬X	¬Y	¬X∧¬Y  ¬X∨Y≡¬X∧¬Y
// 0  0	 0  	1	 1   1	  1	     1
// 0  1  1  	0	 1   0	  0	     1
// 1  0  1  	0    0	 1	  0	     1
// 1  1	 1  	0    0	 0	  0	     1

bool [] x= {false, true};
bool [] y= {false, true };
int count = 0;
for (int f = 0; f < x.Length; f++)
{
    for (int d = 0; d < y.Length; d++)
    {
        Console.WriteLine($"{x[f]}, {y[d]}");
        if ((!(x[f] || y[d])) == (!x[f] && !y[d])) count++;
    }
}
if (count==4) Console.WriteLine("Утверждение верно");
else
{
    Console.WriteLine("Утверждение ложно");
}
