// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел
//            и выводит их на экран. Диапазон - любое целое число.

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10000,10000); // если написать .Next() - диапазон будет произвольным 
    if (i==0)
        Console.Write("Это массив из восьми случайных чисел - [" + array[i] + ", ");
    else if (i==array.Length-1)
        Console.WriteLine(array[i] + "]");
    else 
        Console.Write(array[i] + ", ");
}

