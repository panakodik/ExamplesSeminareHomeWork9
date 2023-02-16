// Написать программу вычисления функции Аккермана

Console.WriteLine("Введите начальное число M:");
double M = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите начальное число N:");
double N = double.Parse(Console.ReadLine()!);

///Метод вычисления функции Аккермана:
double AckermannFunction (double M, double N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return AckermannFunction(M - 1, 1);
    if (M > 0 && N > 0) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
return AckermannFunction(M, N);
}

Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {AckermannFunction(M, N)}");