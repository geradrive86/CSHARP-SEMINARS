// Задание 3. Задайте массив из 10 целых чисел. Найдите среднее значение элементов
// массива.

// Задаем массив из 10 целых чисел
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// Вычисляем среднее значение элементов массива
double average = array.Average();
// Выводим результат
Console.WriteLine($"Среднее значение: {average}");

////////второй вариант
///// int[] array = { 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
///// double sum = 0;
///// foreach (int number in array)
///// {
/////     sum += number;
///// }
///// double average = sum / array.Length;
///// Console.WriteLine("Среднее значение: " + average);