/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] FilledArray(int[,] array)
{
    int counter = 1;
    int left = 0;
    int right = array.GetLength(0) - 1;
    int up = array.GetLength(1) - 1;
    int down = 0;
    while (counter < array.Length)
    {
        //с верхнего левого угла направо
        for (int i = left; i <= right; i++)
        {
            array[down, i] = counter++;
        }
        down++;
        //с правого верхнего угла вниз
        for (int i = down; i <= up; i++)
        {
            array[i, right] = counter++;
        }
        right--;
        //с нижнего правого угла налево
        for (int i = right; i >= left; i--)
        {
            array[up, i] = counter++;
        }
        up--;
        //с нижнего левого угла наверх
        for (int i = up; i >= down; i--)
        {
            array[i, left] = counter++;
        }
        left++;
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < 10)
            Console.Write($"0{array[i, j]}\t");
            else 
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
PrintArray(FilledArray(array));