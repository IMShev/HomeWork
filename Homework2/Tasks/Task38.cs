// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
//            значением элементов массива. Длина массива задается с терминала.

// 1. Создать массив из N элементов
Console.WriteLine("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double[N];

// 2. Заполнить его случайными числами 
FillArray(array);  // например, от -100 до 100

// 3. Вывести массив 
PrintArray(array);

// 4. Найти разницу между максимальным и минимальным значением элементов массива
double max = Max(array);
double min = Min(array);
double dif = max - min;
Console.WriteLine($"Pазницa между максимальным ({max}) и минимальным ({min}) значением равна {dif}");

// метод "заполнениe массива"
void FillArray(double[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = random.NextDouble() * 200 - 100;//гененрирование случ. веществ. чисел в диапазоне от - 100 до 100  
}
//метод "вывести массив"
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine($"arr[{i}] = {arr[i]}");
}

// Метод поиска min элемента массива
double Min(double[] arr)
{
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
    }
    return min;
}
// Метод поиска max элемента массива
double Max(double[] arr)
{
    double max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}