//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя)
//4 -> 16
//-3 -> 9
//-7 -> 49

Console.WriteLine("Введите число А");

int numberA = int.Parse(Console.ReadLine());

double result = Math.Pow(numberA, 2);
string s = $"квадрат от числа {numberA} равен {result}";
Console.WriteLine(s);