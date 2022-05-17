//Задача 54: Задайте двумерный массив. Напишите программу, 
//          которая упорядочит по убыванию элементы каждой строки двумерного массива

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

FillArray(arr, 0, 100);
PrintArray(arr);
SortRowsElements(arr);
PrintArray(arr);

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
    Console.WriteLine();
}

void SortRowsElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int temporaryMax = array[i, j];
            int k = 0;
            for (k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    temporaryMax = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temporaryMax;
                }
            }
        }
    }
}
