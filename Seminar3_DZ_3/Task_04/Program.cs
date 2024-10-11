// Задание 4: Задайте массив целых чисел. Напишите программу, которая удаляет все
// отрицательные числа из массива и возвращает новый массив, содержащий только
// неотрицательные числа.


// Задаем массив целых чисел
int[] array = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 };
// Удаляем отрицательные числа
int[] positiveArray = array.Where(n => n >= 0).ToArray();
// Выводим новый массив
Console.WriteLine("Массив с только неотрицательными числами:");
Console.WriteLine(string.Join(", ", positiveArray));


/////Второй вариант
///// int[] array = { -5, 3, -2, 7, -1, 4, 0, -6, 8, 10 };
///// int[] nonNegativeArray = array.Where(number => number >= 0).ToArray();
///// Console.WriteLine("Массив без отрицательных чисел: " + string.Join(", ", nonNegativeArray));