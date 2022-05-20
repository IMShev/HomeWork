// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
//            сумму натуральных элементов в промежутке от M до N.

int M = InputNaturalNumber("Введите натуральное число M: ");
int N = InputNaturalNumber("Введите натуральное число N: ");
int sum = SumNaturalNumbers(M, N);

Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} = {sum}");

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

int SumNaturalNumbers(int m, int n)
{
    int s = 0;
    if (m == n)
        return n;
    else if (m < n)
    {
        s = n + SumNaturalNumbers(m, n - 1);
        return s;
    }
    else
    {
        s = m + SumNaturalNumbers(m - 1, n);
        return s;
    }

}

