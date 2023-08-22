/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

int[] coord_1 = new int[3];
int[] coord_2 = new int[3];

Console.WriteLine("Enter the coordinets for the first point: ");
for (int i = 0; i < coord_1.Length; i++){
    coord_1[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Enter the coordinets for the second point: ");
for (int i = 0; i < coord_2.Length; i++){
    coord_2[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(coord_1[0] - coord_2[0], 2) + 
Math.Pow(coord_1[1] - coord_2[1], 2) + Math.Pow(coord_1[2] - coord_2[2], 2)), 2));

