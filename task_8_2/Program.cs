// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер
// строки с наименьшей суммой элементов: 1 строка

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

int MinSumArrayRow(int[,] arr)
{
    int[] arr1D = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr1D[i] += arr[i,j];
        }        
    }
    return MinNumberArr1D(arr1D);
}

int MinNumberArr1D(int[] arr)
{
    int index = 0;
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            index = i;
        }
    }
    return index + 1;
}

int[,] a = NewRandomArray();
PrintArray(a);
int minIndex = MinSumArrayRow(a);
Console.WriteLine($"Номер строки с минимальной суммой равен {minIndex}");