// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int Coordinate(string coordinateName, string pointName)
{
    Console.Write($"Введите координату {coordinateName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int v1 = (x1-x2)*(x1-x2);
int v2 = (y1-y2)*(y1-y2);
int v3 = (z1-z2)*(z1-z2);

double d = Math.Sqrt(v1 + v2 + v3);

Console.WriteLine($"Длина отрезка  {d}");