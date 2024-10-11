//Урок 2. Простые Алгоритмы
//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

Console.WriteLine("Введите целое число от 10 до 99:");
int num = Convert.ToInt32(Console.ReadLine());

int firstDigit = num / 10;
int secondDigit = num % 10;
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;

Console.WriteLine($"Наибольшая цифра: {maxDigit}");