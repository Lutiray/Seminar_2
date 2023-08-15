/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int threeDigit(int num){
    while(num > 999){
        num /= 10;
    }
    return num % 10;
}

Console.WriteLine("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99){
    Console.WriteLine(threeDigit(num));
}
else 
    Console.WriteLine("Третьей цифры нет.");


