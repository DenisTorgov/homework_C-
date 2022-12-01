// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

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
}

int arrnumb = Prompt("Введите количествро элементов массива -> ");
int arrmax = Prompt("Введите максимально возможный элемент массива -> ") + 1;
int arrmin = Prompt("Введите минимально возможный элемент массива -> ");
if (arrmax < arrmin)
{
    int temp = 0;
    arrmax = temp;
    arrmax = arrmin;
    arrmin = temp;
}
int[] arrgen = NewArray(arrnumb, arrmax, arrmin);
PrintArray(arrgen);