int AkkermanFunc(int a, int b)
{
    if (a == 0)
        return b + 1;
    if (a > 0 && b == 0)
        return AkkermanFunc(a - 1, 1);
    else return AkkermanFunc(a - 1, AkkermanFunc(a, b - 1));
}

Console.Clear();
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"A(m, n) = {AkkermanFunc(m, n)}");