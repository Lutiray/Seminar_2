/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

void OutputNumbers(int n)
{
    if (n > 0)
    {
        Console.Write(n + ", ");
        OutputNumbers(n - 1);
    }
}

Console.Write("Enter your number: ");

int number = Convert.ToInt32(Console.ReadLine());
OutputNumbers(number);