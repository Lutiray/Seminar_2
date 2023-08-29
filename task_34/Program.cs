/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int CountOfEvenNumbers(int[] num)
{
    return num.Count(i => i % 2 == 0);
}

Random rnd = new Random();

int[] numbers = new int[rnd.Next(0, 10)];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(100, 1000);
}

foreach (int number in numbers)
{
    Console.Write($"{number} ");
}
Console.WriteLine();
Console.WriteLine(CountOfEvenNumbers(numbers));


