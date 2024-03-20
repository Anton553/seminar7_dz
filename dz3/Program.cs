//  Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = { 7, 6, 44, 3, 4 };


void PrintElements(int[] array, int len)
{
    if (len > 0)
    {
        Console.Write(array[len] + " ");
        PrintElements(array, len - 1);
    }
    else
    {
        Console.WriteLine(array[0]);
    }

}

Console.WriteLine($"Выводим массив в обратном порядке: ");
PrintElements(array, array.Length - 1);