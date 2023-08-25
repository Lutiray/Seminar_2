/* Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


double DegreeOfNumber(int a, int b)
{
    double c;
    c = Math.Pow(a, b);
    return c;
}

Console.WriteLine("Enter the number A: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number B: ");
int degree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DegreeOfNumber(number, degree));

