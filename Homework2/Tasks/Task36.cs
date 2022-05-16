//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//           Найдите сумму элементов, стоящих на нечётных позициях. Длина массива задается с терминала.

// 1. Создать массив из N элементов
Console.WriteLine("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

// 2. Заполнить его случайными числами 
FillArray(array, 0, 1000);

// 3. Вывести массив 
PrintArray(array);

// 4. Найти сумму элементов массива, стоящих на нечётных позициях
int sum = SumNechet(array);
Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях равна {sum}");

// метод "заполнениe массива"
void FillArray(int[] arr, int minValue, int maxValue)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = random.Next(minValue, maxValue + 1);
}

//метод "вывести массив"
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine($"arr[{i}] = {arr[i]}");
}

//Метод поиска суммы элементов массива, стоящих на нечётных позициях
int SumNechet(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 > 0)
            sum += arr[i];
    }
    return sum;
}