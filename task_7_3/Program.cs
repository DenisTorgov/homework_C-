// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GenNewMatrix()
{
    int m = 3;
    int n = 4;
    int[,] arr = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

void PrintMatrix (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}\t");
        }
        Console.WriteLine();
    }
}

double[] AverageCol (int[,] arr)
{
    double[] average = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            average[j] += arr[i,j];
        }
        average[j] = average[j] * 10 / arr.GetLength(0) / 10.0;
    }
    return average;
}

void PrintAverage(double[] arr)
{
    Console.WriteLine("Среднее арифметическое столбцов:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]:f2}\t");
    }
}

int[,] matrix = GenNewMatrix();
PrintMatrix(matrix);
double[] average = AverageCol(matrix);
PrintAverage(average);