// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double LongLineAB(int xA, int xB, int yA, int yB, int zA, int zB)
{
    double longLine = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));
    return longLine;
}

Console.Write("Input xCoord of A:  ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input yCoord of A:  ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input zCoord of A:  ");
int zCoordA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input xCoord of B:  ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input yCoord of B:  ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input zCoord of B:  ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LongLineAB(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);
Console.WriteLine($"Distanse between A({xCoordA},{yCoordA},{zCoordA}) and B({xCoordB},{yCoordB},{zCoordB}) is {dist:f2}");