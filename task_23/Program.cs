/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());
int x = 1;

while (x <= num){
    Console.WriteLine(Math.Pow(x, 3));
    x++;
}