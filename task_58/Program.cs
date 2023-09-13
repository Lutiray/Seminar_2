/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение
двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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
            array[i, j] = rnd.Next(1, 6);
        }
    }

    return array;
}

int[,] ProductOfTwoArray(int[,] arrayFirst, int[,] arraySecond)
{
    int[,] result = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];

    if (arrayFirst.GetLength(1) != arraySecond.GetLength(0))
    {
        Console.WriteLine("The number of columns of the first matrix must be equal to the number of rows of the second matrix!");
    }
    else
    {
        for (int i = 0; i < arrayFirst.GetLength(0); i++)
        {
            for (int j = 0; j < arraySecond.GetLength(1); j++)
            {
                int product = 0;
                for (int k = 0; k < arrayFirst.GetLength(1); k++)
                {
                    product += (arrayFirst[i, k] * arraySecond[k, j]);
                }
                result[i, j] = product;
            }
        }
    }

    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("The number of columns of the first matrix must be equal to the number of rows of the second matrix.");
int row1 = Enter("Enter the number of rows for the first array: ");
int column1 = Enter("Enter the number of columns for the first array: ");
int row2 = Enter("Enter the number of rows for the second array: ");
int column2 = Enter("Enter the number of columns for the second array:");

int[,] arrayFirst = new int[row1, column1];
int[,] arraySecond = new int[row2, column2];
int[,] result = new int[row1, column2];

arrayFirst = FillingArray(row1, column1);
arraySecond = FillingArray(row2, column2);
result = ProductOfTwoArray(arrayFirst, arraySecond);

Console.WriteLine("First array: ");
PrintArray(arrayFirst);
Console.WriteLine("Second array: ");
PrintArray(arraySecond);
Console.WriteLine("Resulted array: ");
PrintArray(result);

