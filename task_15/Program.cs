 /* Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
 и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

string itsWeekend(int num){
    
    string message;

    if (num > 7 || num < 1){
        message = "Это не день недели!";
    }
    else if (num > 5) {
        message = "Да";
    }
    else 
        message = "Нет";
    return message;    
}

Console.WriteLine("Ввведите день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(itsWeekend(num));