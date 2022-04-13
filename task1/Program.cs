// Найти сумму цифр числа

int SumNumber(int num)
{
    if (num == 0) return 0;
    else return (num % 10) + SumNumber(num / 10);
}

Console.Write($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа = {SumNumber(number)}.");