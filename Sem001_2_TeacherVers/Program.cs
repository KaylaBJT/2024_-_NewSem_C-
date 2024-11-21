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