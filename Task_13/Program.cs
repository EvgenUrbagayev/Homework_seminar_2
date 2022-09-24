using static System.Console;

Clear();
WriteLine("Введите трехзначное число:  ");
int num = Convert.ToInt32(ReadLine());

if (num < 100)
{
    WriteLine("Третьей цифры нет");
}

if(num > 99 && num < 999)
{
    int num1 = num % 10;
    WriteLine(num1);
}

if (num > 999 && num < 9999)
{
    int num1 = (num % 100) / 10;
    WriteLine(num1);
}

if (num > 9999 && num < 99999)
{
    int num1 = (((num % 1000) / 10) / 10);
    WriteLine(num1);
}