// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

string UserInput(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine();
}

int[,] NewRandomMatrix()
{
    int m = new Random().Next(2, 10);
    int n = new Random().Next(2, 10);
    // int[,] arr = new int[m,n];
    int[,] arr = new int[m,n];
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = new Random().Next(-99, 100);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
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

string FindElement(int[,] arr, int di, int dj)
{
    if (di > arr.GetLength(0)
        || dj > arr.GetLength(1)
        || di -1 < 0
        ||dj -1 < 0)
    {
        return $"Элемент массива на позиции {di}, {dj} не существует";
    }
    else
    {
        return $"Элемент массива на позиции {di}, {dj} соответствует {arr[di - 1, dj - 1]}";
    }
}

int[,] matrix = NewRandomMatrix();
PrintMatrix(matrix);
int posi = Convert.ToInt32(UserInput("Введите строку элемента"));
int posj = Convert.ToInt32(UserInput("Введите столбец элемента"));
Console.WriteLine($"{FindElement(matrix, posi, posj)}");
