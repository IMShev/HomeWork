// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
//            и находит расстояние между ними в 3D пространстве
Console.WriteLine("Введите три координаты точки А: ");
Console.Write("X =  ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y =  ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Z =  ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("  Введите три координаты точки B: ");
Console.Write("X =  ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y =  ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Z =  ");
int zb = Convert.ToInt32(Console.ReadLine());

double lenght = Math.Sqrt((xb-xa)*(xb-xa) + (yb-ya)*(yb-ya) + (zb-za)*(zb-za));

Console.WriteLine($"Длинна отрезка АВ равна {lenght:0.000} ");


