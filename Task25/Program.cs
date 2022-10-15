// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите в какую степень нужно возвести:");
// int b = Convert.ToInt32(Console.ReadLine());

// while (b <= 0)
// {
//     Console.WriteLine("Число должно быть натуральным. Повторите ввод:");
//     b = Convert.ToInt32(Console.ReadLine());
// }

// int degreeOfNum = DegreeOfNum(a, b);
// Console.WriteLine($"{a} в степени {b} -> {degreeOfNum}");

// int DegreeOfNum(int num, int degree)
// {
//     int result = 1;
//     for (int i = 1; i <= degree; i++)
//     {
//     result = result * num;
//     }
//     return result;
// }

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите в какую степень нужно возвести:");
int b = Convert.ToInt32(Console.ReadLine());

if (b == 0 || a == 0 && b == 0)
    Console.WriteLine($"{a} в степени 0 -> 1");

else if (a == 0)
    Console.WriteLine($"0 в степени {b} -> 0");

else if (b < 0)
{
    double degreeOfNum = Math.Round(NegativeDegreeOfNum(a, b), 10, MidpointRounding.ToZero);
    Console.WriteLine($"{a} в степени {b} -> {degreeOfNum}");
}
else
{
    int degreeOfNum = DegreeOfNum(a, b);
    Console.WriteLine($"{a} в степени {b} -> {degreeOfNum}");
}


int DegreeOfNum(int num, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result = result * num;
    }
    return result;
}


double NegativeDegreeOfNum(int num, int degree)
{
    int myInt = System.Math.Abs(degree);
    double result = 1;
    for (int i = 1; i <= myInt; i++)
    {
        result = result * num;
    }
    result = 1 / result;
    return result;
}
