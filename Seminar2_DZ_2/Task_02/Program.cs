//Урок 2. Простые Алгоритмы
//Задача 2:Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
//в которой находится эта точка.

// Console.Write("Введите координату X (X ≠ 0): ");
// int x = int.Parse(Console.ReadLine());
// Console.Write("Введите координату Y (Y ≠ 0): ");
// int y = int.Parse(Console.ReadLine());
// if (x > 0 && y > 0)
//     Console.WriteLine("Точка находится в первой четверти.");
// else if (x < 0 && y > 0)
//     Console.WriteLine("Точка находится во второй четверти.");
// else if (x < 0 && y < 0)
//     Console.WriteLine("Точка находится в третьей четверти.");
// else if (x > 0 && y < 0)
//     Console.WriteLine("Точка находится в четвертой четверти.");
// else
//     Console.WriteLine("Ошибка: X и Y не должны быть равны нулю.");

Console.WriteLine("Введите координату X (не равное 0):");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y (не равное 0):");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
    Console.WriteLine("Точка находится в первой четверти");
else if (x < 0 && y > 0)
    Console.WriteLine("Точка находится во второй четверти");
else if (x < 0 && y < 0)
    Console.WriteLine("Точка находится в третьей четверти");
else if (x > 0 && y < 0)
    Console.WriteLine("Точка находится в четвертой четверти");