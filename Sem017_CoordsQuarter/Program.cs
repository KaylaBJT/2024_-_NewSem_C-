//напишите программу, которая на вход принимает координаты точки (X и Y), причём X не равно 0, и Y не равно 0,
//и выдаёт номер четверти плоскости, в которой находится эта точка
Console.Write("Input x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Input y: ");
int y = int.Parse(Console.ReadLine());

int quarter = 0;

if (x > 0)
{
    if (y > 0)
    {
        quarter = 1;
    }
    else
    {
        quarter = 4;
    }
}
else
{
    if (y > 0)
    {
        quarter = 2;
    }
    else
    {
        quarter = 3;
    }
}
Console.WriteLine($"(X {x}, Y {y}) is {quarter} quarter!");