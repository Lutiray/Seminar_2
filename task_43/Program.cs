/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double Enter(string message)
{
    Console.WriteLine(message);
    double coefficient = Convert.ToDouble(Console.ReadLine());
    
    return coefficient;
}

double FindingCoordinateX(double k1, double b1, double k2, double b2) => 
                            Math.Round(((b2 - b1) / (k1 - k2)), 1);

double FindingCoordinateY(double x, double k1, double b1) => 
                            Math.Round((x * k1 + b1), 1);


double k1 = Enter("Enter the coeficient k1: ");
double b1 = Enter("Enter the coeficient b1: ");
double k2 = Enter("Enter the coeficient k2: ");
double b2 = Enter("Enter the coeficient b2: ");

double x = FindingCoordinateX(k1, b1, k2, b2);
double y = FindingCoordinateY(x, k1, b1);

Console.WriteLine($"({x}, {y})");
