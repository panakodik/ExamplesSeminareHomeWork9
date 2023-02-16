// Показать натуральные числа от N до 1 включительно, N задано.

void recursion(int n)
{
    if(n == 0) return;
    Console.WriteLine(n);
    recursion(n - 1);
}

recursion(10);
