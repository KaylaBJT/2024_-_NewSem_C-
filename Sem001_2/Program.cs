//Напишите программу, которая на вход принимает дв ачисла и проверяет, является ли первое число квадратом второго
//a=25, b=5 -> да
//a=2, b=10 -> нет
//a=9, b=-3 -> да
//a=-3, b=9 -> нет
Console.WriteLine("Введите число А");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int numberB = int.Parse(Console.ReadLine());

double result = Math.Pow(numberB, 2);
string s = "";

if (numberA == result)
{
    s = "да";
}
else
{
    s = "нет";
}

System.Console.WriteLine(s);