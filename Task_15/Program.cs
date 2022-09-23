using static System.Console;


Clear();
WriteLine("Введите число от 1 до 7:  ");
int num = Convert.ToInt32(ReadLine());
if(num == 1)
{
    WriteLine("Сегодня понедельник, рабочий день");
}
if(num == 2)
{
    WriteLine("Сегодня вторник, рабочий день");
}  
if(num == 3)
{
    WriteLine("Сегодня среда, рабочий день");
}
if(num == 4)
{
    WriteLine("Сегодня четверг, рабочий день");
}
if(num == 5)
{
    WriteLine("Сегодня пятница, рабочий день");
}
if(num == 6)
{
    WriteLine("Ура, сегодня суббота, выходной");
}
if(num == 7)
{
    WriteLine("Ура, сегодня воскресенье, выходной");
}

else
{
    WriteLine("Введите число в диапазоне от 1 до 7");
}