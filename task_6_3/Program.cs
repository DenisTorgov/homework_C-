// Найдите максимальное значение в матрице по каждой строке, 
// получите сумму этих максимумов. Затем найдите минимальное
//  значение по каждой колонке,получите сумму этих минимумов.
//  Затем из первой суммы (с максимумами) вычтите вторую сумму
// (с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

int[,] NewArray(int n, int m, int min, int max)
{
    int[,] arr = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
    return arr;
}

void PrintArray2D (int[,] arrprint)
{
    for (int i = 0; i < arrprint.GetLength(0); i++)
    {
        for (int j = 0; j < arrprint.GetLength(1); j++)
        {
            Console.Write($"{arrprint[i, j]} | ");
        }
    Console.WriteLine();
    }
}

int[] MaxinRows (int[,] arr)
{
    int[] maxrow = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        maxrow[i] = arr[i, 0];
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > maxrow[i])
            {
                maxrow[i] = arr[i, j];
            }
        }
    }
    return maxrow;
}

int[] MininColumns (int[,] arr)
{
    int[] mincol = new int[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        mincol[j] = arr[0, j];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            if (arr[i, j] < mincol[j])
            {
                mincol[j] = arr[i, j];
            }
        }
    }
    return mincol;
}

int SumArray (int[] arr)
{
    int sum =0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}

int[,] table = NewArray(2, 3, 0, 10);
PrintArray2D(table);
Console.WriteLine();
int a = SumArray(MaxinRows(table));
int b = SumArray(MininColumns(table));
Console.WriteLine($"Сумма максимальных чисел в строках равна {a}.");
Console.WriteLine($"Сумма минимальных чисел в столбцах равна {b}.");
Console.WriteLine($"Разность сумм равна {a - b}.");