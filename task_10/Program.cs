/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Enter three - digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
    Console.WriteLine(num / 10 % 10);
else 
    Console.WriteLine("Incorrect number! Try again!");