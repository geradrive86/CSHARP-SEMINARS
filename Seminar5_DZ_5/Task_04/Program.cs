// Задание 4: Замена отрицательных элементов в двумерном массиве
// Описание: Задайте двумерный массив. Замените все отрицательные числа на их
// абсолютные значения

int[,] matrix = {
            {-1, 2, -3},
            {4, -5, 6},
            {-7, 8, -9}
        };
int rows = matrix.GetLength(0);
int columns = matrix.GetLength(1);
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (matrix[i, j] < 0) // Если элемент отрицательный
        {
            matrix[i, j] = Math.Abs(matrix[i, j]); // Заменяем его абсолютным значением
        }
    }
}
Console.WriteLine("Матрица с абсолютными значениями отрицательных чисел:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}