/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

bool IsPolindrom(int num)
{
    int[] digits = new int[5];
    for( int i = 0; i < digits.Length; i++){
        digits[i] = num % 10;
        num /= 10;
    }

    for (int i = 0; i < digits.Length / 2; i++){
        if (digits[i] != digits[digits.Length - i - 1]){
            return false;
        }
    }
    return true;
}

int down = 10000, up = 99999;
int num;

do
{
    Console.WriteLine("Enter a 5 digit number: ");
    num = Convert.ToInt32(Console.ReadLine());
}
while (num < down || num > up);

if (IsPolindrom(num))
{
    Console.WriteLine("YES");
}
else Console.WriteLine("NO");


