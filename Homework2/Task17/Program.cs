//Задача 52: Задайте двумерный массив из целых чисел.
//           Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(); 

int[,] arr = new int[m, n];

FillArray(arr, -10, 10);
PrintArray(arr);
Console.WriteLine();
Average(arr);
Console.WriteLine();

void FillArray(int[,] array, int min, int max)
{
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max);

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)

    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}


void Average(int[,] array)
{
    double avg = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double a = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            a = a + array[i, j];

            avg = a / array.GetLength(0);
        }
        Console.WriteLine($"Среднее арифметическое столбца {j} = {avg}");
    }
}