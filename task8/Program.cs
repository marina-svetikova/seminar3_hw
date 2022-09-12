//// Задача 8 семинара №1
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int numberA = 1;
if (number > 0)
{
while (numberA <= number)
{
int ost = numberA % 2;
if (ost == 0 )
{
    Console.Write(numberA + " ");
}
numberA++;
}
}
else
{
Console.WriteLine("Введено не верное значение");
}

