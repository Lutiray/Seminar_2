/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Random rnd = new Random();

int Enter(string message)
{
    Console.WriteLine(message);

    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreatingArray(int lowerBound, int upperBound, int n, int m)
{
    int[,] array = new int[n, m];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(lowerBound, upperBound + 1);
        }
    }

    return array;
}

int[,] MaxSortingOfRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }

    return array;
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

int row = Enter(" Enter the number of rows: ");
int column = Enter("Enter the number of columns: ");
int[,] array = new int[row, column];
int lowerBound = Enter("Enter the lower bound of the random: ");
int upperBound = Enter("Enter the upper bound of the random: ");

array = CreatingArray(lowerBound, upperBound, row, column);
Console.WriteLine("Outgoing array: ");
PrintArray(array);

array = MaxSortingOfRows(array);
Console.WriteLine("Sorted array: ");
PrintArray(array);
