// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//            Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.WriteLine("Сколько чисел будет введено: ");
int numbersCount = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[numbersCount]; 

int countPositiveNumbers = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"Введите число {i+1}: ");
    arr[i] = Convert.ToDouble(Console.ReadLine());
    if (arr[i] > 0)
    {
        countPositiveNumbers++;
    }
}

Console.WriteLine($"\nКоличество элементов больше 0: {countPositiveNumbers}");
