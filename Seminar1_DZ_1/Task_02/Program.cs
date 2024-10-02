int min = Math.Min(Math.Min(num1, num2), num3);
int max = Math.Max(Math.Max(num1, num2), num3);

if (num1 != min && num1 != max)
{
    return num1;
}
else if (num2 != min && num2 != max)
{
    return num2;
}
else
{
    return num3;
}