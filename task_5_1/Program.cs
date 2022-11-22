// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] NewArray(int n, int max, int min)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arrprint)
{
    Console.Write($"{arrprint[0]}");
    for (int i = 1; i < arrprint.Length; i++)
    {
        Console.Write($", {arrprint[i]}");
    }
    Console.WriteLine();
}

int EvenNumbCounter(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            res = res + 1;
        }
    }
    return res;
}

int[] arrgen = NewArray(5, 1000, 100);
PrintArray(arrgen); 
int countevennumb = EvenNumbCounter(arrgen);
Console.WriteLine($"Количество четных чисел равно -> {countevennumb}");