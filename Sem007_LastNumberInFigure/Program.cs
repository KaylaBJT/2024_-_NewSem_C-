//Напишите программу, которая гна вход принимает трёхзначное число и на выходе показываетп оследнюю цифру этого числа
//456 -> 6
//782 -> 2
//918 -> 8

Console.Write("Введите трёхзначное число: ");
if (int.TryParse(Console.ReadLine(), out int n))
{
    if (n >= 100 && n < 1000)
    {
        int x = (n % 10);
        Console.WriteLine($"Последняя цифра вашего числа {x}");
    }
    else
    {
        System.Console.WriteLine("Вы ввели не трёхзначное число!");
    }
}
else
{
    System.Console.WriteLine("Вы ввели не число!");
}