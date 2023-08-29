/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
 стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Random rnd = new Random();

/* int SumOfElementsInOddPosition(int[] num)
{
    return num.Where((value, index) => index % 2 != 0).Sum();
} */

int SumOfElementsInOddPosition(int[] num)
{
    int sum = 0;
    for (int i = 1; i < num.Length; i+=2)
    {
        sum += num[i];
    }

    return sum;
}

int[] numbers = new int[rnd.Next(0, 10)];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(-100, 101);
}

Console.WriteLine(SumOfElementsInOddPosition(numbers));