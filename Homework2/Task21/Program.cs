// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//            Числа выбираются случайно, при этом проверяется, что такого числа еще не было. 
//            Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



const int x = 2;
const int y = 3;
const int z = 3;

int[,,] arr = new int[x, y, z];


int TotalElements = x * y * z;
int[] ValueElements = new int[TotalElements];

FillValueElements(ValueElements, 10, 100);
//PrintValueElements(ValueElements);  // проверка на повторяемость в одномерном массиве 
FillArray(arr, ValueElements);
PrintArray(arr);

void FillValueElements(int[] arr, int minValue, int maxValue)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(minValue, maxValue);
        if (i > 0)
        {
            for (int j = 0; j < i; j++)
            {
                if (arr[j] == arr[i]) i--;
            }
        }
    }
}

void FillArray(int[,,] array, int[] arr)
{
for (int i = 0; i < arr.Length;)
    for (int a = 0; a < array.GetLength(0); a++)
        for (int b = 0; b < array.GetLength(1); b++)
            for (int c = 0; c < array.GetLength(2); c++)
            
            {
                array[a,b,c] = arr[i];
                i++;
            }

}

void PrintArray(int[,,] array)
{
    int CountElement = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"array[{i},{j},{k}] = {array[i, j, k]}");
                CountElement++;
            }
    Console.WriteLine($"Total elements = {CountElement}");
    Console.WriteLine();
}

// void PrintValueElements(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         Console.WriteLine($"arr[{i}] = {arr[i]}");
// }
