//  Задача номер 26
// Напишите программу, которая принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
int ReadNumber (string messenge)
{
    Console.WriteLine(messenge);
    return Convert.ToInt32(Console.ReadLine());
}

int ProdNumbers1ToA(int a)
{
    if (a>=1)
    { 
     int sum = 1;
     for (int i = 2; i <= a; i++)
     {
        sum = sum*i;
     }
     return sum;
    }
    else 
    {
        Console.WriteLine("A должно быть не меньше 1!");
        return -1;
    }
}

int number = ReadNumber ("Ведите число 1:");
int summa = ProdNumbers1ToA (number);
Console.WriteLine($"Произведение элеметов от 1 до А = {summa}");
