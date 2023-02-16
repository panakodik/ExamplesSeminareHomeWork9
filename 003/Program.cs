// Найти сумму элементов от M до N, N и M заданы.

int m = 3;
int n = 6;
int sum = 0;

void recursion(int n)
{
    if(n == m) return;
    Console.WriteLine(n);
    sum = sum + n;
    recursion(n - 1);
}

recursion(n);
Console.WriteLine($"Сумма элементов равна {sum}");

