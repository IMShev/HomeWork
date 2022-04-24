// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
getSquare(n);
void getSquare(int n)
{
    while (count <= n)
    {
        int newn = count;
        count = count * count * count;
        Console.WriteLine(newn + " -> " + count);
        count = newn + 1;
    }
}