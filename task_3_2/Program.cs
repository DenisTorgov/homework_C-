// Задача 2

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


int[] prompt(string msg)
{
    int[] dot = new int[3];
    Console.WriteLine(msg);
    for (int i = 0; i < dot.Length; i++)
    {
        dot[i] = Convert.ToInt32(Console.ReadLine());
    }

    return dot;
}

int[] dot1 = prompt("Введите координаты первой точки (X, Y, Z)");
int[] dot2 = prompt("Введите координаты второй точки (X, Y, Z)");

int x = dot1[0] - dot2[0];
int y = dot1[1] - dot2[1];
int z = dot1[2] - dot2[2];
double distance = Math.Sqrt(x*x+y*y+z*z);
Console.WriteLine($"Расстояние между точками = {distance:f2}");