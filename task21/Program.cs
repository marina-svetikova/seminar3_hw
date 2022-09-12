// Напишите программу, которая принимает на вход координаты двух
//  точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Ведите координату точки А по оси Х");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите координату точки А по оси Y");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите координату точки A по оси Z");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите координату точки B по оси Х");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите координату точки B по оси Y");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите координату точки B по оси Z");
int zb = Convert.ToInt32(Console.ReadLine());
double res = Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2) + Math.Pow(za-zb,2));
Console.WriteLine(res);


