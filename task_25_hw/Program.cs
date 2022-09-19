// // Напишите цикл, который принимает на вход
//  два числа (A и B) и возводит число A в 
// натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите положительное число А:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число B:");
int numberB = Convert.ToInt32(Console.ReadLine());
int i = 0;

if (numberA>0|numberB>0)
{
    int sum = 1;
    while (i<numberB)
    {
     sum = sum*numberA;
     i++;
    }
    Console.WriteLine($"Результат = {sum}");
}
else
{
    Console.WriteLine("Ведено число меньше или равное 0");
}



