////Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
// Задаем произвольную строку
string inputString = "radar";
// Проверяем, является ли строка палиндромом
bool isPalindrome = IsPalindrome(inputString);
// Выводим результат
Console.WriteLine($"Строка \"{inputString}\" является палиндромом: {isPalindrome}");

static bool IsPalindrome(string str)
{
    int i = 0;
int j = str.Length - 1;
while (i < j)
{
    if (str[i] != str[j])
    {
        return false;
    }
    i++;
    j--;
}
return true;
}