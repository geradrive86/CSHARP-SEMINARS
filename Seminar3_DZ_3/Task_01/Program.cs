// Задание 1: Задайте массив целых чисел. Напишите программу, которая проверяет,
// присутствует ли заданное число в массиве. Программа должна вывести:
// Присутствует/Не присутствует.


///// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };// Задаем массив целых чисел

///// Console.Write("Введите число для поиска: ");// Просим пользователя ввести число для поиска
///// int num = int.Parse(Console.ReadLine());

///// bool exists = Array.Exists(array, element => element == number);// Используем метод Exists для проверки наличия числа в массиве
///// // Выводим результат проверки
///// if (exists)
///// //    Console.WriteLine("Присутствует");
///// // else
///// //     Console.WriteLine("Не присутствует");
///
// Задаем массив целых чисел
int[] array = { 1, 2, 3, 4, 5 };
// Запрашиваем у пользователя число для поиска
Console.WriteLine("Введите число для поиска:");
int searchNumber = Convert.ToInt32(Console.ReadLine());
// Проверяем, содержит ли массив это число
bool isPresent = Array.Exists(array, element => element == searchNumber);
// Выводим результат
if (isPresent)
    Console.WriteLine("Присутствует");
else
    Console.WriteLine("Не присутствует");