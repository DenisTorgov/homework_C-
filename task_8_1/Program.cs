// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] NewRandomArray()
{
    int m = new Random().Next(2,10);
    int n = new Random().Next(2,10);
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

void SortArrayByRows(int[,] arr)
{
    int max = 0;
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            max = arr[i,j];
            for (int m = j + 1; m < arr.GetLength(1); m++)
            {
                if (arr[i,m] > max)
                {
                    max = arr[i,m];
                    temp = arr[i,m];
                    arr[i,m] = arr[i,j];
                    arr[i,j] = temp;
                }  
            }      
        }
    }
}

int[,] a = NewRandomArray();
PrintArray(a);
SortArrayByRows(a);
Console.WriteLine();
PrintArray(a);