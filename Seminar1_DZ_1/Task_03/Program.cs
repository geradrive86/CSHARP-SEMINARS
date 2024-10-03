// Задача №3
// Напишите метод, который на вход принимает число и выводит, является ли
// оно положительным (больше нуля), отрицательным (меньше нуля) или нулём.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
Console.WriteLine("положительное");
} 
else if (num < 0)
{
Console.WriteLine("отрицательное");
} 

else
{
Console.WriteLine("ноль");
}
