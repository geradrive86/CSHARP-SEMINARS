﻿// Задача №4 Напишите метод, который на вход принимает число (number), 
// а на выходе выводит все нечетные числа от 1 до number (включительно), 
// после каждого числа должен быть знак пробела.
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    PrintOddNumbers(number);
}
static void PrintOddNumbers(int number)
{
    for (int i = 1; i <= number; i++)
    {
        if (i % 2 != 0) // Проверка на нечетное число
        {
            Console.Write(i + " "); // Выводим число и пробел
        }
    }
    Console.WriteLine(); // Переход на новую строку после вывода всех чисел
}