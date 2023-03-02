using static Library;

Console.Clear();
Console.WriteLine("Программа высчитывает расстояние в 3D пространстве между заданными точками");

int Ax = GetNumber("Введите координаты точки A по оси x: ");
int Ay = GetNumber("Введите координаты точки A по оси y: ");
int Az = GetNumber("Введите координаты точки A по оси z: ");
int Bx = GetNumber("Введите координаты точки B по оси x: ");
int By = GetNumber("Введите координаты точки B по оси y: ");
int Bz = GetNumber("Введите координаты точки B по оси z: ");

double distance = GetDistance(Ax, Ay, Az, Bx, By, Bz);
Console.WriteLine("Расстояние между заданными точками = " + distance);