// // программа, которая выводит квадрат числа
// Console.Write("Введите число : ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.Write("Квадрат числа равен ");
// Console.WriteLine(number*number);



// //Программа, которая на вход принимает одно число N, а на выходе показывает все целые числа в промежутке от -N до N.

// Console.Write("Введите число : ");
// double num = Convert.ToDouble(Console.ReadLine());
// double num1 = num - num*2; 
// while (num >= num1)
// {
//     Console.WriteLine(num);
//     num = num - 1;
// }


// //Программа, которая на вход принимает трехзначное число и на выходе показывает последнюю цифру этого числа

// Console.Write("Введите трехзначное число : ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// int numberLast = number3%10;

// Console.Write("последняя цифра ");
// Console.WriteLine(numberLast);



// //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Введите число 1 : ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2 : ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2)
// {
//     Console.WriteLine("Первое число больше ");
// }
// else Console.WriteLine("Второе число больше ");
    


// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("Введите число 1 : ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2 : ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 3 : ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (a < b)
// {
//     max = b;
//     if (b < c)
//     {
//         max = c;
//     }
// }
// Console.Write("Максимальное число ");
// Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Введите число : ");
// int x = Convert.ToInt32(Console.ReadLine());
// int ostatok = x%2;
// if (ostatok > 0)
// {
//     Console.WriteLine("Число нечетное ");
// }
// else Console.WriteLine("Число четное ");
    


//Задача 8: Напишите программу, которая на вход принимает число N, а на выходе показывает все чётные числа от 1 до N.

// Console.Write("Введите число : ");
// int N = Convert.ToInt32(Console.ReadLine());
// int ost = N%2;
// while (N > 1)
// {
//     if (ost > 0)
//     {
//         int m = N-1;
//         Console.WriteLine(m);
//         m = m - 2;
//     }
//     else 
//         Console.WriteLine(N);
//         N = N - 2;   
// }


// Задача семинара: Для случайного числа в диапазое от 100 до 1000 убрать вторую цифру и вывести первую и третью

// int N = new Random().Next(100, 1000);
// int digit1 = N % 10;
// int digit2 = N / 100;
// int newN = digit2 * 10 + digit1;
// Console.WriteLine(N);
// Console.WriteLine(newN);

// //задача  семинара: проверить введенные числа на кратность, в противном случает вывести остаток

// Console.Write("Введите число 1: ");
// int nA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число 2: ");
// int nB = Convert.ToInt32(Console.ReadLine());

// if (nA % nB == 0)
//     Console.WriteLine("Кратно");
// else 
//     Console.WriteLine("Не кратно, остаток "+ nA%nB);



// //задача семинара:  проверить введенное число на кратность 7 и 23
// // синтаксис if
// Console.Write("Введите число : ");
// int n = Convert.ToInt32(Console.ReadLine());

// if ((n % 7 == 0) && (n % 23 == 0))
//     Console.WriteLine("Это число делится на 7 и 23 ");
// else
//     Console.WriteLine("Это число НЕ делится на 7 и 23 ");


// // Задача семинара: ввести координаты точки и определить в каком квадранте она находится
// Console.WriteLine("Введите координату X: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int q = getQuadrant(x, y);

// if (q == 0)
//     Console.WriteLine("Эта точка находится на оси");
// else
//     Console.WriteLine("Эта точка находится в квадранте № " + q);

// int getQuadrant(int x, int y) // описание Метода поиска квадранта в котором находится точка
// {
//     if (x > 0 && y > 0)
//         return 1;
//     if (x < 0 && y > 0)
//         return 2;
//     if (x < 0 && y < 0)
//         return 3;
//     if (x > 0 && y < 0)
//         return 4;
//     return 0;
// }




// //  Задача семинара: ввести число N и вывести все квадраты чисел от 0 до N
// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// getSquare(n);
// void getSquare(int n)
// {
//     while (count <= n)
//     {
//         int newn = count;
//         count = count * count;
//          Console.WriteLine(newn + " -> " + count);
//         count = newn + 1;
//     }
// }





// // Задача семинара: программа принимает на вход число N и выдает сумму чисел от 1 до N.

// int Number;

// Console.Write("Please, enter positive integer number: ");
// while (!int.TryParse(Console.ReadLine(), out Number) || Number < 0)
// {
//     Console.WriteLine("Wrong input, try again!");
//     Console.Write("Please, enter positive integer number: ");
// }

// int sum = 0;
// for (int i = 1; i <= Number; i++)
// {
//     sum += i;
// }

// Console.WriteLine("Sum of all numbers from 1 to " + Number + " equal " + sum);



// // Задача семинара: программа принимает на вход число N и выдает произведение чисел от 1 до N.

// int Number;

// Console.Write("Please, enter positive integer number: ");
// while (!int.TryParse(Console.ReadLine(), out Number) || Number < 0)
// {
//     Console.WriteLine("Wrong input, try again!");
//     Console.Write("Please, enter positive integer number: ");
// }

// int mult = 1;
// for (int i = 1; i <= Number; i++)
// {
//     mult = mult*i;
// }

// Console.WriteLine("Multiply of all numbers from 1 to " + Number + " equal " + mult);



// // Задача семинара: программа выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// int[] array = new int[8];
// Console.Write("[");
// for (int i = 0; i <= array.Length - 1; i++)
// {
//     array[i] = new Random().Next(0, 2);
//     Console.Write(array[i] + "  ");
// }
// Console.WriteLine("]");


// // та же задача, но немного другой вывод с проверкой на первый и последний элементы
// int[] array = new int[8];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 2);
//     if (i==0)
//         Console.Write("[" + array[i] + ", ");
//     else if (i==array.Length-1)
//         Console.WriteLine(array[i] + "]");
//     else 
//         Console.Write(array[i] + ", ");
// }



// // Задача семинара: программа считает сколько цифр в веденном числе (количество разрядов)

// Console.WriteLine("Введите число: ");
// int number;
// while (!int.TryParse(Console.ReadLine(), out number))
// {
//     Console.WriteLine("неправильно! Введите число: ");
// }
// int count = 0;
// int result = number;
// if (result<0)
// result = -1 * result;
// while (result>0)
// {
//     result = result/10;
//     count++;
// }
// Console.WriteLine(count);
