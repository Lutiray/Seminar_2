/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermanFunction(m - 1, 1);
    }
    else return AckermanFunction(m - 1, AckermanFunction(m, n - 1)); 
}

Console.Write("Enter the number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({m}, {n}) = {AckermanFunction(m, n)}");