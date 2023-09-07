/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Random rnd = new Random();

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

void FindingAverage(int[,] array)
{
    double average = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }

        average = Math.Round(sum / array.GetLength(0), 1);

        if (i < array.GetLength(1) - 1)
        Console.Write("{0}; ", average);
        else 
        Console.Write("{0}.", average);
    }
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


int m = rnd.Next(2, 11);
int n = rnd.Next(2, 11);
int[,] array = new int[m, n];

array = FillingArray(m, n);

PrintArray(array);
FindingAverage(array);