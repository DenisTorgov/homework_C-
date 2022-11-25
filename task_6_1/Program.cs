// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string Prompt(string msg)
{
    Console.Write(msg);
    string numb = Console.ReadLine();
    if (numb != " ")
    {
        return numb;
    }
    else
    {
        return "stop";
    }
}

int[] NewArray()
{
    int[] arr = {0};
    int i = 0;
    string newnumb;
    while ((newnumb = Prompt("Введите ряд чисел. Для завершения введите ПРОБЕЛ ")) != "stop")
    {
        Array.Resize(ref arr, i+1);
        arr[i] = Convert.ToInt32(newnumb);
        i++;
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

int PositiveNumb (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int[] a = NewArray();
PrintArray(a);
Console.WriteLine();
Console.WriteLine($"Количество чисел больше нуля равно {PositiveNumb(a)}");