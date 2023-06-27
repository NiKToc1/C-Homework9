int printNumbers(int a, int b)
{
    if (a == b)
        return b;
    return (b + printNumbers(a, b - 1));
}

Console.Clear();
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(printNumbers(m, n));