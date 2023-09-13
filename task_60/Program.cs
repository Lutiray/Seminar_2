/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Random rnd = new Random();

int[,,] FillingArray(int[,,] array)
{
    int minValue = 10;
    int maxValue = 99;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int randomNumber;
                do
                {
                    randomNumber = rnd.Next(minValue, maxValue + 1);
                }
                while (!CheckRepeatIn3DArray(array, randomNumber));

                array[i, j, k] = randomNumber;
            }
        }
    }

    return array;
}

bool CheckRepeatIn3DArray(int[,,] array, int number)
{
    foreach (int element in array)
    {
        if (element == number)
        {
            return false;
        }
    }

    return true;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array = new int[2, 2, 2];

PrintArray(
    FillingArray(array)
);
