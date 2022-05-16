// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//            и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите номер строки массива: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца массива: ");
int column = Convert.ToInt32(Console.ReadLine());

const int m = 6;
const int n = 6;

int[,] arr = new int[m, n];

FillArray(arr, -100, 100);

PrintArray(arr);

if (row > m || column > n)
    Console.WriteLine("\nТакого элемента в массиве нет!\n");
else 
    Console.WriteLine($"\nЭлемент массива на позиции [{row}, {column}] равен {arr[row, column]}\n");
 

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
