// Удалить вторую цифру трёхзначного числа
// 123 -> 13
//Главная задача - разобрать главный алгорит, как вытащить цифру
//Какие подзадачи могут потребоваться
//1. Откуда берутся данные (что, сели 012, 001?). Мы принимаем условие 100 =< n =<999
// Число, которое вводит юзер
//как выводить результат 
//123
//13
//123 -> 13
//012
//-214: Abs(-214) = 214 -> 24
//-214: Abs(-214) = 214 -> -24
//2. 
//2.1. Метод, который -> Ввод числа
//2.2. Метод, который -> Проверка числа на валидность
//2.3. Метод, который -> Отковырять вторую цифру !
//2.4. Метод, который -> Распечатать результат
//2.52 Метод, который -> Декоратор для вывода результата
//
//3.
//
//abc = a*100 + b*10 + c
//456 = 4*100 + 5*10 + 6
//
//ac = a*10 + c
//
//
//Деление Целочисленное         14 div 5 => 2            int / int => int
//        Обычное               14 / 5 => 2.8            double / int => double
//                                                       int / double => double
//                                                       double / double => double
//        Деление с остатком    14 mod 5 => 4 (остаток)  int % int => int
//
// abc => value
// a = value div 100               456 div 100 = 4  
// b = (value div 10) mod 10       (456 div 10) mod 10 = 5
// c = value mod 10                456 mod 10 = 6
//
//

//2.1. Метод, который -> Ввод числа
int GetNumberFromUser()  //ничего не принимает, но возвращает число (int)
{
    System.Console.WriteLine("Введите число от 100 до 999: ");
    int temp = int.Parse(Console.ReadLine()!); // temp - непонятное чис ло, которое мы потом вернём, ! значит, что у нас точно будут данные (ещё лучше удалить   <Nullable>enable</Nullable>)
    return temp;
}

//2.2. Метод, который -> Проверка числа на валидность
bool IsValid(int number)  //int number принимает число, bool логический тип
{
    // and -> &&
    return number >= 100 && number <= 999;
    //if (number ≥ 100)
    //{
    //    if (number ≤ 999)
    //    {
    //        return true;
    //    }
    //}
    //return false;
}

//2.3. Метод, который -> Отковырять вторую цифру !
int GetNumber(int value)   //это метод
{
    int a = value / 100;
    int b = (value / 10) % 10;
    int c = value % 10;

    return a * 10 + c;
}
//System.Console.WriteLine(GetNumber(456));
//2.4. Метод, который -> Распечатать результат
string GetText(int input, int output)  //getText вместо print
{
    return input + " -> " + output;
}
//2.5 Метод, который -> Декоратор для вывода результата

int value = GetNumberFromUser();
if (IsValid(value))
{
    int result = GetNumber(value);
    //System.Console.WriteLine(GetText(value, result));
    Decorator2(GetText(value, result));
}
else
{
    System.Console.WriteLine("число кривое");
}

string Decorator(string text)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    return text;
}


void Decorator2(string text)
{
    Console.Clear();
    System.Console.WriteLine("***********");
    ConsoleColor old = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine(text);
    Console.ForegroundColor = old;
    System.Console.WriteLine("***********");
}