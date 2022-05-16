// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите любое число: ");
int N = Convert.ToInt32(Console.ReadLine());
if ( N > 99 )
    Console.WriteLine("третья цифра этого числа : " + N.ToString()[2]);
else
Console.WriteLine("Третьей цифры нет");
