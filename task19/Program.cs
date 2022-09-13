// // Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число N:");
int N = Convert.ToInt32(Console.ReadLine());
if ( 10000 < N || N < 99999)
{ 
    int digit1 = N/10000;
    int digit2 = (N/1000)%10;
    int digit3 = (N/100)%10;
    int digit4 = (N/10)%10;
    int digit5 = N%10;
    int res =digit5*10000+digit4*1000+digit3*100+digit2*10+digit1;
   if (res==N)
    {
       Console.WriteLine("Да");
    }
    else if (N!=res)
    {
       Console.WriteLine("Нет"); 
    }
}
else
{
     Console.WriteLine("Вdедено не пятизначное число"); 
}