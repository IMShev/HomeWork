// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//            которая будет находить строку с наименьшей суммой элементов.

// если сумма элементов в строках совпадает - программа выдает первую строку с минимальным значением

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

FillArray(arr, -50, 50);
PrintArray(arr);
MinSumRowsElements(arr);


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

void MinSumRowsElements(int[,] array)
{
    int minSum = 0;
    int row = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];

        //Console.WriteLine($"Сумма строки {i + 1} = {sum}"); // проверка для наглядности

        if (i == 0) minSum = sum;
        else
         if (sum < minSum)
        {
            minSum = sum;
            row = i;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов равна {minSum} в строке {row + 1}");

}




