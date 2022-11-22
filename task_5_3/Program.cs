// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] NewArray(int n, int min, int max)
{
    double[] arr = new double[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(min, max*100) / 100.0;
    }
    return arr;
}

void PrintArray(double[] arrprint)
{
    Console.Write($"{arrprint[0]}");
    for (int i = 1; i < arrprint.Length; i++)
    {
        Console.Write($", {arrprint[i]}");
    }
    Console.WriteLine();
}

double ArrMax(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    Console.WriteLine($"Max -> {max}");
    return max;
}

double ArrMin(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine($"Min -> {min}");
    return min;
}

double[] arrgen = NewArray(5, 1, 100);
PrintArray(arrgen); 
double differencemaxmin = ArrMax(arrgen) - ArrMin(arrgen);
Console.WriteLine($"Разность между минимальным и максимальным числом массива равна -> {differencemaxmin:f2}");