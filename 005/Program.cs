// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

Console.Clear();
Console.Write("Задайте количество отображаемых чисел ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Задайте первое число последовательности ");
int p1 = int.Parse(Console.ReadLine()!);
Console.Write("Задайте второе число последовательности ");
int p2 = int.Parse(Console.ReadLine()!);

int FibonachiUser(int n, int p1, int p2) 
        {
            if (n <= 1) return p1;
            int p;
            for (int j = 2; j < n; j++) 
            {
                p = p1;
                p1 = p2;
                p2 = p2 + p;
                Console.Write($" {p2} ");
            }
            return p2;
        }

Console.Write("Пользовательский ряд Фибоначчи из " + n + " чисел: " + p1 + "  " + p2 + " ");       
FibonachiUser(n,p1,p2);
