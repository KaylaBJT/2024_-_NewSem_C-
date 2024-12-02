//Напишите программу, которая на вход принимает дв ачисла и проверяет, является ли первое число квадратом второго
//a=25, b=5 -> да
//a=2, b=10 -> нет
//a=9, b=-3 -> да
//a=-3, b=9 -> нет
int i = int.Parse(Console.ReadLine());

if (int.TryParse(Console.ReadLine(), out int j))
{
    if (i == Math.Pow(j, 2))
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
else
{
    Console.WriteLine("It's not a number");
}