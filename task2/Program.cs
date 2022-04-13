// Написать программу вычисления функции Аккермана

Console.Write($"Введите первый параметр функции (m): ");
long parameterM = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите второй параметр функции (n): ");
long parameterN = Convert.ToInt32(Console.ReadLine());

long AckermannFunction(long m, long n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.WriteLine($"Функция Аккермана({parameterM}, {parameterN}) = {AckermannFunction(parameterM, parameterN)}.");
