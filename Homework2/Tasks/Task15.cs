// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

int NumberDay = new Random().Next(1, 8);
Console.WriteLine(NumberDay);

// или
// Console.WriteLine("введите число от 1 до 7"); 
// int NumberDay = Convert.ToInt32(Console.ReadLine());

if ((NumberDay == 7) | (NumberDay == 6))
    Console.WriteLine("Выходной день");
else
    Console.WriteLine("Рабочий день");

