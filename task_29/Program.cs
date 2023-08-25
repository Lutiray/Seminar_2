/*  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Random rnd = new Random();

int[] RandomOfNumber()
{
    int[] nums = new int[8];
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rnd.Next(0, 100);
    }

    return nums;
}

Console.Write($"Here is your massive of number: [");

foreach (int number in RandomOfNumber()) 
{
    Console.Write(" {0}", number);
} 

Console.Write("]");