/*  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Random rnd = new Random();

int[] RandomOfNumber(int down, int up)
{
    int[] nums = new int[8];
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rnd.Next(down, up);
    }

    return nums;
}

Console.WriteLine("Enter the lower and upper bounds via Enter: ");

int lower = Convert.ToInt32(Console.ReadLine());
int upper = Convert.ToInt32(Console.ReadLine());

Console.Write($"Here is your massive of number: [");

foreach (int number in RandomOfNumber(lower, upper)) 
{
    Console.Write(" {0}", number);
} 

Console.Write("]");