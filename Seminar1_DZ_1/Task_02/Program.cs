// Задача №2
// Напишите метод, который принимает на вход три числа и возвращает
// среднее из этих чисел (то есть не самое большое и не самое маленькое).



Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());


if ((num1 >= num2 && num1 <= num3) || (num1 >= num3 && num1 <= num2))
{
    Console.WriteLine("Среднее число:" + num1);
    return num1;
}
else if ((num2 >= num1 && num2 <= num3) || (num2 <= num1 && num2 >= num3))
{
    Console.WriteLine("Среднее число:" + num2);
    return num2;
}
else
{ 
    Console.WriteLine("Среднее число:" + num3);
    return num3;
}