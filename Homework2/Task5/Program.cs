// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//            является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
while (Number > 100000)     //ограничение по условию задачи, без него код работает с любыми числами
{
    Console.WriteLine("Введите пятизначное число: ");
     Number = Convert.ToInt32(Console.ReadLine());
}

int tempNumber = Number;
int rev = 0;

while (Number > 0)    // "Переворт" числа
{
    int digit = Number % 10;
    rev = rev * 10 + digit;
    Number = Number / 10;
}

if (tempNumber == rev)
    Console.WriteLine("Число " + tempNumber + " - Палиндром!");
else
    Console.WriteLine("Число " + tempNumber + " - Не палиндром.");




