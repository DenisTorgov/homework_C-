// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] Prompt(string msg)
{
    double[] line = new double[2];
    Console.WriteLine(msg);
    line[0] = Convert.ToDouble(Console.ReadLine());
    line[1] = Convert.ToDouble(Console.ReadLine());
    return line;
}

double[] Coordinate (double[] l1, double[] l2)
{
    double[] dot = new double[2];
    dot[0] = (l2[0] - l1[0]) / (l1[1] - l2[1]);
    dot[1] = l1[1] * (l2[0] - l1[0]) / (l1[1] - l2[1]) + l1[0];
    return dot;
}

double[] line1 = Prompt("Ведите коэф. b1 и k1 для уравнения y = k1 * x + b1 первой линии ");
double[] line2 = Prompt("Ведите коэф. b2 и k2 для уравнения y = k2 * x + b2 второй линии ");
double[] point = Coordinate(line1, line2);
Console.WriteLine($"Координаты точки пересечения линий х={point[0]:f2}, y={point[1]:f2}");