Console.WriteLine("Введите число от 1 до 7 ");

int day = int.Parse(Console.ReadLine());

string s = "Не день недели!";  //можно оставить пустые кавычки, тогда выведется пустота после цифры

if (day == 1)
{
    s = "Понедельник";
}
else if (day == 2)
{
    s = "Вторник";
}
else if (day == 3)
{
    s = "Среда";
}
else if (day == 4)
{
    s = "Четверг";
}
else if (day == 5)
{
    s = "Пятница";
}
else if (day == 6)
{
    s = "Суббота";
}
else if (day == 7)
{
    s = "Воскресенье";
}
Console.WriteLine(s);