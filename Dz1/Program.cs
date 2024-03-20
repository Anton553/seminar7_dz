// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Вывод натуральных чисел от M до N: ");
void NatChisMdoN(int m, int n)
{
    if (m > n)  return;
    Console.Write($"{m} ");
    NatChisMdoN(m + 1, n);
}

NatChisMdoN(m, n);