/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка */

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

int FindRowWithMinSum(int[,] array)
{
    int minSum = int.MaxValue;
    int minRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }

        if (sum < minSum) 
        {
            minRow = i;
            minSum = sum;
        }
    }

    return minRow;
}

void PrintArray(int[,] array)
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

int column = Enter("Enter the number of column: ");
int row = Enter("Enter the number of row: ");
int[,] array = new int[row, column];

array = FillingArray(row, column);
PrintArray(array);

Console.WriteLine($"The row with the smallest amount is {FindRowWithMinSum(array) + 1}.");