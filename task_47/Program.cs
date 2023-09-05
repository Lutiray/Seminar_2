/*  Задайте двумерный массив размером m×n, заполненный случайными вещественными 
числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

int Enter(string message)
{
    Console.WriteLine(message);

    return Convert.ToInt32(Console.ReadLine());
}

double[,] FillingArray(int m, int n)
{
    Random rnd = new Random();

    double[,] array = new double[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.Next(-10, 11) + rnd.NextDouble(), 1);
        }
    }

    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}]\t");
        }
        Console.WriteLine();
    }
}

int m = Enter("Enter the number of columns: ");
int n = Enter("Enter the number of rows: ");
double[,] array = new double[m, n];
array = FillingArray(m, n);

Console.WriteLine($"m ={m}, n = {n}");
PrintArray(array);