// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите положительное число");
int number = Convert.ToInt32 (Console.ReadLine());
int numberA = 2;

while (numberA <= number)
{
  Console.WriteLine (numberA + " ");
  numberA +=2;
}
