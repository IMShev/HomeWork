// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//            Даны два неотрицательных числа m и n. 
//              m = 2, n = 3 -> A(m,n) = 29

int M = InputNaturalNumber("Введите число M (от 0 до 13): "); //ограничение искусственное, для наглядности
int N = InputNaturalNumber("Введите число N (от 0 до 3): ");  //если n > 3, переполнение стека и зависание

if ((M > 13) || (N > 3))
{
    Console.WriteLine($"Значение функции Аккермана c такими параметрами слишком велико!");
}
else
{
    int A = Akkerman(N, M); // пришлось поменять местами, чтобы значения соответствовали примеру 
                            // и таблице из википедии
    Console.WriteLine($"Значение функции Аккермана А({M},{N}) = {A}");
}


int InputNaturalNumber(string element)
{
    int number;
    Console.Write(element);
    while (!int.TryParse(Console.ReadLine(), out number) || (number < 0))
    {
        Console.WriteLine("Ошибка! Введите неотрицательное число:");
        Console.Write(element);
    }
    return number;
}

int Akkerman(int m, int n)
{

    if (m == 0)
    {
        return n + 1;
    }

    else if (n == 0)
    {
        return Akkerman(m - 1, 1);
    }

    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }

}
