// Задача 1: Вывод натуральных чисел в промежутке от M до N
// Описание: Напишите программу, которая выведет все натуральные числа в
// промежутке от M до N. Используйте рекурсию и не используйте циклы.

int M = 9;
int N = 10;
PrintNaturalNumbers(M, N);

static void PrintNaturalNumbers(int current, int end)
{
    if (current <= end)
    {
        Console.WriteLine(current);
        PrintNaturalNumbers(current + 1, end);
    }
}