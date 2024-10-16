// Задание 3: Транспонирование двумерного массива
// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
// транспонирует массив (меняет строки и столбцы местами).

int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };
int[,] transposed = new int[array.GetLength(1), array.GetLength(0)]; // Новый массив для транспонированных данных
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        transposed[j, i] = array[i, j]; // Перестановка строк и столбцов
    }
}
PrintArray(transposed); // Выводим транспонированный массив
static void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}