// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: ");

int Number;
while (!int.TryParse(Console.ReadLine(), out Number))
{
    Console.WriteLine("Неверно! Пожалуйста введите число: ");
}
int temp = Number;
int sum = 0;

if (Number < 0)
    Number = -1 * Number;

while (Number > 0)
{
    sum = sum + Number % 10;
    Number = Number / 10;
}
Console.WriteLine($"Сумма цифр в числе {temp} равна {sum} .");