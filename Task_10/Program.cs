using static System.Console;

Clear();
Write("Введите трехзначное число:  ");
int number = Convert.ToInt32(ReadLine());

if(number >= 100)
{
if(number <= 999)
{
    int num = number / 10;
    int num1 = num % 10;
    WriteLine($"{num1}");
}
}
else
{
    WriteLine($"Введите число больше 100 и меньше 999");
}
