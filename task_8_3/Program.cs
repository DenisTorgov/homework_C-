// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] NewRandomArray(int m, int n)
{
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

void PrintArray(int[,] arr)
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

int[,] MatrixProduct(int[,] a, int[,] b)
{
    int[,] c = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < c.GetLength(0); i++)
    {
        for (int j = 0; j < c.GetLength(1); j++)
        {
            for (int m = 0; m < a.GetLength(1); m++)
            {
                c[i,j] += a[i,m] * b[m,j];   
            }
        }
    }
    return c;
}

bool ProductCheck (int[,] a, int[,] b)
{
    if (a.GetLength(1) == b.GetLength(0))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[,] amatrix = NewRandomArray(2, 3);
PrintArray(amatrix);
Console.WriteLine();
int[,] bmatrix = NewRandomArray(3, 2);
PrintArray(bmatrix);
Console.WriteLine();
if (ProductCheck(amatrix, bmatrix))
{
    PrintArray(MatrixProduct(amatrix, bmatrix));
}
else
{
    Console.WriteLine($"Матрицы несовместимы");
}