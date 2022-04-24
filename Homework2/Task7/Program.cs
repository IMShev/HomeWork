// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 

int a;
int b;

Console.WriteLine("Введите натуральное целое число А: ");
while (!int.TryParse(Console.ReadLine(), out a) || a < 0)
{
    Console.WriteLine("Неверно! Пожалуйста введите натуральное целое число А:");
}
Console.WriteLine("Введите натуральное целое число В: ");
while (!int.TryParse(Console.ReadLine(), out b) || b < 0)
{
    Console.WriteLine("Неверно! Пожалуйста введите натуральное целое число B:");
}
int result = a;
if (b == 1)
    result = a;
if (b == 0)
    result = 1;
else
    while (b > 1)
    {
        result = result * a;
        b--;
    }

Console.WriteLine($"Число А в степени В равно {result}.");