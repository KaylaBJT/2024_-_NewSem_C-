//Напишите программу, которая по заданному номеру четверти показывет диапазон вохможных координат
//точек в этой четверти (X и Y)
Console.WriteLine("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());
int x_min = 0;
int x_max = 0;
int y_min = 0;
int y_max = 0;

if (quarter == 1)
{
    x_min = 1;
    x_max = int.MaxValue;
    y_min = 1;
    y_max = int.MaxValue;
}

if (quarter == 2)
{
    x_min = int.MinValue;
    x_max = -1;
    y_min = 1;
    y_max = int.MaxValue;
}

if (quarter == 3)
{
    x_min = int.MinValue;
    x_max = -1;
    y_min = -1;
    y_max = int.MinValue;
}

if (quarter == 4)
{
    x_min = 1;
    x_max = int.MaxValue;
    y_min = -1;
    y_max = int.MinValue;
}

Console.WriteLine($"Диапазон возможных координат: x:({x_min}, {x_max}), y:({y_min}, {y_max})");