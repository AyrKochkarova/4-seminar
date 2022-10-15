// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number <= 0)
{
    Console.WriteLine("Вы ввели некорректное значение! Пожалуйста, введите натуральное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе {number} = {sumNumbers}");

int SumNumbers(int num)
{
    int sum = default;
    int lastNumber = default;

    while (num > 0)
    {
        lastNumber = num % 10;
        sum += lastNumber;
        num = num / 10;
    }
    return sum;
}
