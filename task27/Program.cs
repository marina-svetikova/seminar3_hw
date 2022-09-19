// // Напишите программу, которая принимает на вход число и выдаёт
//  сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber (string messenge)
{
    Console.WriteLine(messenge);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = ReadNumber ("Ведите положительное число:");
if (numberA>0)
{ 
    int TempNumber = numberA;
    int sum = 0; //Сумма цифр в числе
    int digit = 0;
    while(TempNumber!=0)
    {
        digit = TempNumber%10;
        TempNumber = TempNumber/10;
        sum = sum + digit;
    }
    Console.WriteLine($"Сумма цифр в числе = {sum}");
}
else
{
    Console.WriteLine("Введено число меньше или равное 0");
}

