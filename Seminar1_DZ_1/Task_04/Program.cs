// Задача №4 Напишите метод, который на вход принимает число (number), 
// а на выходе выводит все нечетные числа от 1 до number (включительно), 
// после каждого числа должен быть знак пробела.


static void PrintOddNumbers(int number)
{
    for (int i = 1; i <= number; i += 2)
    {
        Console.Write(i + " ");
    }
}
PrintOddNumbers(30);