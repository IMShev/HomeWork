// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
//            Напишите программу, которая покажет количество чётных чисел в массиве.
//            Длина массива задается с терминала.

// 1. Создать массив из N элементов
Console.WriteLine("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

// 2. Заполнить его случайными числами положительными трёхзначными числами
FillArray(array, 0, 999);

// 3. Вывести массив 
PrintArray(array);

// 4. Найти количество чётных чисел в массиве
int count = CountChetn(array);
Console.WriteLine($"количество чётных чисел в массиве = {count}");

// метод "заполнениe массива"
void FillArray(int[] arr, int minValue, int maxValue)
{
    Random random = new Random();
    for (int i=0; i< arr.Length; i++)
         arr[i] = random.Next(minValue, maxValue + 1);
}

//метод "вывести массив"
void PrintArray(int[] arr)
{
    for (int i=0; i< arr.Length; i++)
        Console.WriteLine($"arr[{i}] = {arr [i]}");
}

// Метод "поиск количества четных элементов"
int CountChetn(int[] arr)
{
    int count = 0;
    for (int i=0; i< arr.Length; i++)
        {
            if (arr[i]%2 == 0)
            count++;
        }
    return count;
}
