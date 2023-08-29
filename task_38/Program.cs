/* Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

double[] SortMassive(double[] num)
{
    double temp = 0;
    for (int i = 0; i < num.Length - 1; i++)
    {
        for (int j = i + 1; j < num.Length; j++)
        {
            if (num[j] < num[i])
            {
                temp = num[j];
                num[j] = num[i];
                num[i] = temp;
            }
        }
    }

    return num;
}

Random rnd = new Random();

double[] numbers = new double[rnd.Next(3, 13)];
Console.WriteLine("Enter 5 numbers: ");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Math.Round(rnd.Next(0, 101) + rnd.NextDouble(), 2);
}

double min = SortMassive(numbers)[0];
double max = SortMassive(numbers)[numbers.Length - 1];

foreach (double number in numbers)
{
    Console.Write($"{number} ");
}

Console.WriteLine();
Console.WriteLine($"{max} - {min} = {max - min}");