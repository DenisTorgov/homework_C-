// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

string UserInput (string msg)
{
    return Console.ReadLine();
}

double[,] NewRandomMatrix (int m, int n)
{
    double[,] arr = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = new Random().Next(-10, 10) + new Random().NextDouble();
        }
    }
    return arr;
}

void PrintMatrix (double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"| {arr[i,j]:f2}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Заполнение матрицы m х n из вещественных чисел");
int m = Convert.ToInt32(UserInput("Введите количество строк в матрице"));
int n = Convert.ToInt32(UserInput("Введите количество столбцов в матрице"));
PrintMatrix(NewRandomMatrix(m, n));