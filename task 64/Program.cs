int printNumbers(int a, int b)
{
    if (a == b)
        return a;
    Console.Write($"{printNumbers(a, b + 1)}, ");
    return b;
}


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int m = 1;
Console.WriteLine(printNumbers(n, m));