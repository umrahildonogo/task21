//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);


Console.WriteLine("Введите координаты первой точки");
Console.Write("X = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z = ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z = ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1, x2, y1, y2, z1, z2);

double Distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    int dis1 = x2 - x1;
    int dis2 = y2 - y1;
    int dis3 = z2 - z1;
    double distance = Math.Sqrt(dis1 * dis1 + dis2 * dis2 + dis3 * dis3);
    return distance;
}
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resultRound);