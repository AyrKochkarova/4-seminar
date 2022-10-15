// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите в какую степень нужно возвести:");
int b = Convert.ToInt32(Console.ReadLine());

while (b <= 0)
{
    Console.WriteLine("Число должно быть натуральным. Повторите ввод:");
    b = Convert.ToInt32(Console.ReadLine());
}

int degreeOfNum = DegreeOfNum(a, b);
Console.WriteLine($"{a} в степени {b} -> {degreeOfNum}");

int DegreeOfNum(int num, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
    result = result * num;
    }
    return result;
}
