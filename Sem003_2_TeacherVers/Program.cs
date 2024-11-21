Console.Write("Input number: ");
int i = int.Parse(Console.ReadLine());

switch (i)
{
    case 1: Console.WriteLine("Monday"); break;
    case 2: Console.WriteLine("Tue"); break;
    case 3: Console.WriteLine("Wed"); break;
    case 4: Console.WriteLine("Thu"); break;
    case 5: Console.WriteLine("Fri"); break;
    case 6: Console.WriteLine("Sat"); break;
    case 7: Console.WriteLine("Sun"); break;
    default: Console.WriteLine("It's not a week day"); break;
}