// Задача 1 (19): Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

if (number.Length == 5)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Введенное число: {number} - палиндром.");
  }
  else Console.WriteLine($"Введенное число: {number} - НЕ палиндром.");
}
else 
Console.WriteLine($"Введеное число не соответствует условию. Введите пятизначное число.");




// Задача 2 (21): Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

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


//Задача 3 (23): Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int min = 1;

while (min <= number)

{
    int result = Cube(min);
    Console.Write(result + " ");
    min++;
}

int Cube(int number)
{
    return number * number * number;
}
