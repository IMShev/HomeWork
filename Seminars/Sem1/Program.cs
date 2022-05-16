// // Семинар 5.
// // Функции и методы
// // Задача 31. Задайте массив из 12 элементовб заполненный случайными числами из промежутка [-9,9].
// //            Найдите сумму отрицательных и положительных элементов массива.

// // 1. Создать массив из 12 элементов
// int[] array = new int[12];
// // 2. Заполнить его случайными числами от -9 до 9
// FillArray(array, -9, 9);
// // 3. Вывести массив 
// PrintArray(array);
// // 4. Найти сумму всех отрицательных элементов и ее вывести
// int sumNegativ = SumNeg(array);
// Console.WriteLine($"Сумма отрицательных элементов массива равна {sumNegativ}");
// // 5. Найти сумму всех положительных элементов и ее вывести
// int sumPositiv = SumPos(array);
// Console.WriteLine($"Сумма положительных элементов массива равна {sumPositiv}");


// //метод для заполнения массива
// void FillArray(int[] arr, int minValue, int maxValue)
// {
//     Random random = new Random();
//     for (int i=0; i< arr.Length; i++)
//          arr[i] = random.Next(minValue, maxValue + 1);
// }

// //метода вывести массив
// void PrintArray(int[] arr)
// {
//     for (int i=0; i< arr.Length; i++)
//         Console.WriteLine($"arr[{i}] = {arr [i]}");
// }

// //Метод поиска суммы отрицательных элементов
// int SumNeg(int[] arr)
// {
//     int sum = 0;
//     for (int i=0; i< arr.Length; i++)
//         {
//             if (arr[i] <0)
//             sum += arr[i];
//         }
//     return sum;
// }

// //Метод поиска суммы положительных элементов
// int SumPos(int[] arr)
// {
//     int sum = 0;
//     for (int i=0; i< arr.Length; i++)
//         {
//             if (arr[i] >= 0)
//             sum += arr[i];
//         }
//     return sum;
// }

// // Задача 32: Замена элементов массива на противоположные по значению
// int[] array = {1, -2, 3, -4, 5, -6};
// for (int i=0; i < array.Length; i++)
// {
//    array[i] = -array[i];
//    Console.Write($"  {array[i]}  ");
// }
// Console.WriteLine();


// // Задача 33: Задать массив в коде и определить присутствует в нем заданное пользователем значение или нет
// int[] array = { 1, -2, 3, -4, 5, -6};
// Console.WriteLine("Введите искомое число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int res = Find(array, N);
// if (res == 1) 
//    Console.WriteLine("Число есть в массиве");
// if (res == 0) 
//     Console.WriteLine("Числа НЕТ в массиве");

// int Find(int[] array, int N) //метод  поиск введенного элемента в массиве
// {
// for (int i = 0; i < array.Length; i++)
//     if (N == array[i])
//     return 1;
//     return 0;
// }


// //Задача 35: Задайте одномерный массив из 123 случайных неотрицательных чисел. 
// //           Найдите количество элементов массива, значения которых лежат в отрезке [10,99]

// // 1. Создать массив из 123 элементов
// int[] array = new int[123];
// // 2. Заполнить его случайными числами от 0 до 1000
// FillArray(array, 0, 1000);
// // 3. Вывести массив 
// PrintArray(array);
// // 4. Найти количество элементов Массива в диапазоне от 10 до 99
// int count = CountElements(array, 10, 99);
// //Console.WriteLine($"Количество элементов в диапазоне от 10 до 99  = {count} .");

// int CountElements(int[] arr, int min, int max)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     if (arr[i] >= min && arr[i] <= max)
//         count++;
//     return count;
// }

// //метод для заполнения массива
// void FillArray(int[] arr, int minValue, int maxValue)
// {
//     Random random = new Random();
//     for (int i = 0; i < arr.Length; i++)
//         arr[i] = random.Next(minValue, maxValue + 1);
// }

// //метода вывести массив
// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         Console.WriteLine($"arr[{i}] = {arr[i]}");
// }

// Console.WriteLine($"Количество элементов в диапазоне от 10 до 99  = {count} .");



// // задача 39: Напишите программу, которая перевернет массив
// //           (последний элемент будет на первом месте, а первый - на последнем и тд).

// //СПОСОБ 1
// int[] arr = { 10, 25, 46, 76, 100, 321 };
// // создадим копию массива
// int[] tmp = ReversArray(arr);

// CopyArray(tmp, arr);

// PrintArray(arr);

// // создадим копию массива с элементами в обратном порядке
// int[] ReversArray(int[] array)
// {
//     int[] result = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//         result[array.Length - 1 - i] = array[i];
//     return result;
// }
// //  копируем исходный массив в конечный по элементам
// void CopyArray(int[] source, int[] dest)
// {
//     if (source.Length != dest.Length)
//         return;

//     for (int i = 0; i < source.Length; i++)
//         dest[i] = source[i];
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("{");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]);
//         if (i < arr.Length - 1)
//             Console.Write(", ");
//     }
//     Console.WriteLine("}");
// }

// // СПОСОБ 2 (swap-method)
// int[] arr = { 10, 25, 46, 76, 100, 321, 455 };

// ReversArrayInPlace(arr);
// PrintArray(arr);

// void ReversArrayInPlace(int[] array)
// {
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         int tmp = array[i];
//         array[i] = array[array.Length-1 -i];
//         array[array.Length-1 -i] = tmp;
//     }
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("{");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]);
//         if (i < arr.Length - 1)
//             Console.Write(", ");
//     }
//     Console.WriteLine("}");
// }

// // Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// //            может ли существовать треугольник с сторонами такой длины.
// // Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// Console.Write("Укажите длину стороны АВ: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите длину стороны BC: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите длину стороны АC: ");
// int C = Convert.ToInt32(Console.ReadLine());

// if ((A < B + C) && (B < A + C) && (C < B + A))
//     Console.WriteLine($"Треугольник со сторонами {A}, {B} и {C} существует");
// else 
//     Console.WriteLine($"Треугольника со сторонами {A}, {B} и {C} НЕ существует!");



// // Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// // решение через массивы (ввод данных в массив и переворот массива)
// //=================================================================
// int n = InputIntNamber("");
// int count = 0;

// // считаем количество элементов будущего массива (кол-во разрядов двоичного числа)
// for (int step = n; step > 0; step /= 2)
// {
//     count++;
// }

// //инициализируем новый массив с нужным количеством элементов
// int[] arr = new int[count];

// // ищем остаток от деления и помещаем в созданный массив
// for (int i = 0, step = n; step > 0; step /= 2)
// {
//     arr[i] = step % 2;
//     i++;
// }

// //выводим массив с конца
// for (int i = count - 1; i >= 0; i--)
// {
//     Console.Write(arr[i]);
// }

// Console.WriteLine();

// // проверка на введенное число
// int InputIntNamber(string numberName)
// {
//     Console.Write($"Input integer number {numberName}: ");
//     int number;

//     while (!int.TryParse(Console.ReadLine(), out number))
//     {
//         Console.WriteLine("incorrect!Input integer number :");
//     }
//     return number;
// }

// // решение через строки
// //=======================
// int number = InputIntNamber("");
// int InputIntNamber(string numberName)
// {
//     Console.Write($"Input integer number {numberName}: ");
//     int number;

//     while (!int.TryParse(Console.ReadLine(), out number))
//     {
//         Console.WriteLine("incorrect!Input integer number :");
//     }
//     return number;
// }
// string result = ""; 
// while (number > 0) 
// {
//     if (number % 2 == 0) 
//         result = "0" + result;
//     else 
//         result = "1" + result;
//     number = number/2;
// }
// Console.WriteLine($"{result}");

// // решение через рекурсию
// //=========================
// int number = InputIntNamber("");
// int InputIntNamber(string numberName)
// {
//     Console.Write($"Input integer number {numberName}: ");
//     int number;

//     while (!int.TryParse(Console.ReadLine(), out number))
//     {
//         Console.WriteLine("incorrect!Input integer number :");
//     }
//     return number;
// }


// int result(int num)
// {
//     if (num > 1)
//         result(num / 2);
//         Console.Write(num % 2);
//     return num;
// }
// result(number);
// Console.WriteLine();


// //ДВУМЕРНЫЕ МАССИВЫ
// //Задача 46: Задайте двумерный массив размером m*n, заполненный случайными целыми числами.

// const int m = 4;
// const int n = 3;

// int[,] arr = new int[m,n];

// FillArray(arr, -100,100);

// PrintArray(arr);

// //fill array with random numbers from min to max

// void FillArray(int[,] array, int min, int max)
// {
//     Random rnd= new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         array [i,j] = rnd.Next(min,max);

// }

// //print array to console

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         Console.WriteLine($"array[{i},{j}] = {array[i,j]}");
// }

// //Задача 48: Задайте и выведите на экран двумерный массив размером m*n,
// //           каждый элемент в массиве находится по формуле: A(m,n)=m+n.

// Console.WriteLine("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[m, n];
// FillArray(arr);
// PrintArray(arr);


// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = i + j;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]} ");

//         Console.WriteLine();
//     }
// }



// //Задача 49: Задайте двумерный массив размером m*n, найдите элементы у которых оба индекса четные,
// //           и замените эти элементы на их квадраты.

// Console.WriteLine("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[m, n];

// FillArray(arr, 0, 20); // заполняет массив
// PrintArray(arr);// выводит на экран
// Console.WriteLine(); // разделение массивов пустой строкой
// NewArray(arr); // изменяет элементы массива
// PrintArray(arr); // выводит измененный массив


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
//             Console.Write($"{array[i, j]} ");
//         Console.WriteLine();
//     }
// }

// // void PrintNewArray(int[,] newArray)
// // {
// //     for (int i = 0; i < newArray.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < newArray.GetLength(1); j++)
// //         {
// //             if (i % 2 == 0 & i > 0  & j % 2 == 0 & j > 0)
// //                 newArray[i, j] = newArray[i, j] * newArray[i, j];

// // Console.Write($"{newArray[i, j]} ");
// //         }
// //         Console.WriteLine();

// //     }
// // }
// void NewArray(int[,] newArray)
// {
//     for (int i = 2; i < newArray.GetLength(0); i+=2)
//         for (int j = 2; j < newArray.GetLength(1); j+=2)
//                 newArray[i, j] *=  newArray[i, j];
// }

// //Задача 51: Задайте двумерный массив размером m*n, найдите сумму элементов,
// //          находящихся на главной диагонали.

// Console.WriteLine("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[m, n];
// int sum = 0;
// FillArray(arr, 0, 20);
// PrintArray(arr);

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
//             {if (i == j)
//             sum = sum + array[i,j];
//             Console.Write($"{array[i, j]} ");
//             }
//     Console.WriteLine();
//     }
//     Console.WriteLine($"Сумма элементов по диагонали равна {sum}.");
// }

