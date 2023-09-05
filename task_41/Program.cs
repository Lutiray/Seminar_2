/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */

int Enter(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

void PrintArray(int[] number)
{
    foreach (int num in number){
        Console.Write($"{num} ");
    }

    Console.WriteLine();
}

int[] FillingArray(int length)
{
    int[] number = new int[length];

    for (int i = 0; i < length; i++)
    {
        number[i] = Enter($"Enter {i + 1} number: ");
    }

    return number;
}

int PositiveNumber(int[] number)
{
    int count = 0;

    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] > 0)
        {
            count++;
        }
    }

    return count;
}


int length = Enter("Enter the number of items: ");
int[] number = new int[length];

number = FillingArray(length);
PrintArray(number);
PositiveNumber(number);

Console.WriteLine(PositiveNumber(number));
