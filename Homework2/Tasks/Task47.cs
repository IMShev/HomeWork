// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m,n];

FillArray(arr);

PrintArray(arr);

void FillArray(double[,] array)
{
    Random rnd= new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        array [i,j] = rnd.NextDouble()*200-100;

}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
       { for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i,j]:0.00}\t");
        Console.WriteLine();
       }
}
