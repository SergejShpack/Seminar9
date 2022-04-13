// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

int RecSequence(int a, int b, int n)
{
    if (n == 1) return a;
    else if (n == 2) return b;
    else return RecSequence(a, b, n - 1) + (RecSequence(a, b, n - 2));
}

Console.Write($"Введите количество элементов в последовательности: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите первый элимент: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите второй элимент: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write($"Первые {number} элементов последовательности: \n{firstNumber} {secondNumber} ");

for (int i = 3; i <= number; i++)
    Console.Write($"{RecSequence(firstNumber, secondNumber, i)} ");