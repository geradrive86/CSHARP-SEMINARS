//*Задача 3: Напишите программу, которая перевернёт одномерный массив


int[] array = { 1, 2, 3, 4, 5 }; // Исходный массив
Array.Reverse(array); // Встроенный метод для переворота массива
Console.WriteLine("Перевернутый массив: " + string.Join(", ", array));

///Использование встроенного метода Array.Reverse
///

//Второй вариант 1: Ручной обмен элементов

// int[] array = { 1, 2, 3, 4, 5 }; // Исходный массив
// for (int i = 0; i < array.Length / 2; i++)
// {
//     int temp = array[i]; // Временная переменная для хранения текущего элемента
//     array[i] = array[array.Length - 1 - i]; // Меняем местами элементы
//     array[array.Length - 1 - i] = temp; // Завершаем обмен
// }
// Console.WriteLine("Перевернутый массив: " + string.Join(", ", array));


//Третий вариант Создание нового перевернутого массива

// int[] array = { 1, 2, 3, 4, 5 }; // Исходный массив
// int[] reversedArray = new int[array.Length]; // Новый массив для хранения перевернутых значений
// for (int i = 0; i < array.Length; i++)
// {
//     reversedArray[i] = array[array.Length - 1 - i]; // Заполняем новый массив в обратном порядке
// }
// Console.WriteLine("Перевернутый массив: " + string.Join(", ", reversedArray));