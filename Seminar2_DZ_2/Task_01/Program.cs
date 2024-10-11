//Урок 2. Простые Алгоритмы
//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.Write("Введите число: ");
string input = Console.ReadLine();
if (int.TryParse(input, out int num))
{
    string result = (num % 7 == 0 && num % 23 == 0) ?
                    "Число кратно 7 и 23." :
                    "Число не кратно 7 и 23.";
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Пожалуйста, введите допустимое целое число.");
}