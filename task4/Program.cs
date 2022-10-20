// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число ");

string number = Console.ReadLine();

int a = Convert.ToInt32(number);
int i = 1;

Console.WriteLine($"Четные числа от 0 до {a}");
Console.Write("0");

while (i <= a)
{   
    if (i % 2 == 0)
    {
        Console.Write($", {i}");
    }
    i++;
}
