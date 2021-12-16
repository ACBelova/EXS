// Определить, присутствует ли в заданном массиве, некоторое число 
int chislo, n, c = 0;
            string s;
         
 
            int[] x = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("-> ");
                x[i] = Convert.ToInt32(Console.ReadLine());
                c = x[i];
            }
            Console.Write("Введите число какое вы хотите проверть, находится ли он в массиве или нет: ");
            chislo = Convert.ToInt32(Console.ReadLine());
        
            if (chislo != c)
            {
                Console.WriteLine("Такого числа нет!!!");
                Console.ReadKey();
                return;
            }
            foreach (int a in x)
                if (a == c)
                {
                    Console.WriteLine("Да ваше число совпадает с числом из массива!");
                    Console.WriteLine(c + " = " + chislo);
                }