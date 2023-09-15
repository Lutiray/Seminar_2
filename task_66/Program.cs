/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumBetweenNumbers(int min, int max)
{
    if (min > max)
    {
        return min - max;
    }
    return min + SumBetweenNumbers(min + 1, max);
}

Console.Write("Enter a smaller number: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a biger number: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of the numbers between {min} and {max} is {SumBetweenNumbers(min, max) - 1}");