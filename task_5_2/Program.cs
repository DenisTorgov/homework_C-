// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] NewArray(int n, int min, int max)
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

int OddNumbSum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int[] arrgen = NewArray(5, 1, 100);
PrintArray(arrgen); 
int sumoddnumb = OddNumbSum(arrgen);
Console.WriteLine($"Сумма чисел на четных позициях равна -> {sumoddnumb}");