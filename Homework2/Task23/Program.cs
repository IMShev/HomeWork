// Задача 64: Задайте значения M и N. 
//            Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

int M = InputNaturalNumber("Введите натуральное число M: ");
int N = InputNaturalNumber("Введите натуральное число N: ");
NaturalNumberSeries(M, N);
Console.WriteLine();

int InputNaturalNumber(string element)
{
    int number;
    Console.Write(element);
    while (!int.TryParse(Console.ReadLine(), out number) || (number <= 0))
    {
        Console.WriteLine("Ошибка! Введите натуральное число больше 0: ");
        Console.Write(element);
    }
    return number;
}

void NaturalNumberSeries(int m, int n)
{
    if (m < n)
    {
        if (m == n)
            Console.Write(n + " ");
        else
        {
            NaturalNumberSeries(m, n - 1);
            Console.Write(n + " ");
        }
    }
    else
    {
        if (n == m)
            Console.Write(n + " ");
        else
        {
            NaturalNumberSeries(m, n + 1);
            Console.Write(n + " ");
        }
    }
}