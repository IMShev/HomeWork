// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
const int x = 2;
const int y = 3;
const int z = 3;

// Условие согласованности матриц: количество столбцов А = количество строк В

int[,] arrA = new int[x, y]; 
int[,] arrB = new int[y, z];
int[,] arrC = new int[x, z];

 FillArray(arrA, 0,10);
 FillArray(arrB, 0,10);

PrintArray(arrA);
PrintArray(arrB);

MultArray(arrC, arrA, arrB);
PrintArray(arrC);


void FillArray(int[,] array, int min, int max)
{
    Random rnd= new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        array [i,j] = rnd.Next(min,max);

}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
       {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] MultArray(int[,] arrC, int[,] arrA, int[,] arrB)
{
    for (int i = 0; i < arrA.GetLength(0); i++)
        for (int j = 0; j < arrB.GetLength(1); j++)
          //for (int k = 0; k < x; k++)
            for (int n = 0; n < y; n++)
        arrC [i,j] += arrA[i,n]*arrB[n,j];

return arrC;
}