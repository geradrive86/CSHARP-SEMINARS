// Урок 2. Простые Алгоритмы
// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите натуральное число N:");
long n = Convert.ToInt64(Console.ReadLine());// можно и по-другому если числа не очень длинные  - int n = Convert.ToInt32(Console.ReadLine());
string result = String.Join(",", n.ToString().ToCharArray());
Console.WriteLine(result);