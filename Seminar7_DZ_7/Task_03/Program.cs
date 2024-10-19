﻿// Задача 3: Вывод элементов массива в обратном порядке
//Описание: Задайте произвольный массив. Выведите его элементы, начиная с конца.

int[] arr = { 1, 2, 3, 4, 5 };
PrintArrayReverse(arr, arr.Length - 1);

static void PrintArrayReverse(int[] arr, int index)
{
    if (index >= 0)
    {
        Console.WriteLine(arr[index]);
        PrintArrayReverse(arr, index - 1);
    }
}