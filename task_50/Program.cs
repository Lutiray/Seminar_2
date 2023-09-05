/*  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Random rnd = new Random();

int Enter(string message)
{
    Console.WriteLine(message);

    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillingArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 100);
        }
    }

    return array;
}

bool SeachElement(int[,] array, int m, int n)
{
    if (m - 1 < array.GetLength(1) && n - 1 < array.GetLength(0))
    {
        return true;
    }

    return false;
}

int m = rnd.Next(2, 11);
int n = rnd.Next(2, 11);
int[,] array = new int[m, n];

Console.WriteLine($"column = {m}, row = {n}");

int column = Enter("Enter the number of column: ");
int row = Enter("Enter the number of row: ");

array = FillingArray(m, n);

if (SeachElement(array, row, column))
{
    Console.WriteLine($"{array[column - 1, row - 1]}");
}
else Console.WriteLine("There is no such number in the array!");