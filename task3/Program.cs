
// Написать программу возведения числа А в целую стень B

int RecPower(int a, int b)
{
    if (b == 0) return 1;
    else return a * RecPower(a, b - 1);
}

Console.Write($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите степень: ");
int power = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number}^{power} = {RecPower(number, power)}.");