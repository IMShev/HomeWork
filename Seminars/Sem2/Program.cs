// // Задача 53 Задайте двумерный массив. Напишите программу, которая меняет местами 
//              первую и последнюю строки массива


// int m = 3;
// int n = 3;

// int[,] arr = new int[m, n];

// FillArray(arr, 0, 100);

// PrintArray(arr);
// Console.WriteLine();
// ChangeRows(arr);
// PrintArray(arr);


// //fill array with random numbers from min to max

// void FillArray(int[,] array, int min, int max)
// {
//     Random rnd = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = rnd.Next(min, max);

// }



// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]}\t");

//         Console.WriteLine();
//     }
// }


// void ChangeRows(int[,] array)
// {
//     int temp;

//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)

//         {
//             temp = array[0, j];
//             array[0, j] = array[array.GetLength(0) - 1, j];
//             array[array.GetLength(0) - 1, j] = temp;
//         }


// }


// Задача 55 Задайте двумерный массив. Напишите программу которая заменяет строки на столбцы.
// в случае если это невозможно - вывести такое сообщение.

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());



int[,] arr = new int[m, n];

FillArray(arr, 0, 100);

PrintArray(arr);
Console.WriteLine();
ChangeRows(arr);
PrintArray(arr);


//fill array with random numbers from min to max

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


void ChangeRows(int[,] array)
{
    int temp;
 
    if (array.GetLength(0) != array.GetLength(1))
        Console.WriteLine("Поменять элементы невозможно!");

    for (int i = 0; i < array.GetLength(0)-1; i++)
    {

        for (int j = i+1; j < array.GetLength(1); j++)

        {
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }

}




