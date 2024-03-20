Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerm(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    else if (m >= 0 && n == 0)
    {
        return akkerm(m - 1, 1);
    }
    else
    {
        return akkerm(m - 1, akkerm(m, n - 1));
    }
}

Console.WriteLine($"Ответ = {akkerm(m, n)}");