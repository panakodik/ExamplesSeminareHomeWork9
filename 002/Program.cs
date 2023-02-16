// Показать натуральные числа от M до N, N и M заданы.

int m = 5;
int n = 10;

void recursion(int n)
{
    if(n == m) return;
    recursion(n - 1);
    Console.WriteLine(n);
}

recursion(n);
