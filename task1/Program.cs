// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("ВВедите два числа a и b ");

string A = Console.ReadLine();
string B = Console.ReadLine();

int a = Convert.ToInt32(A);
int b = Convert.ToInt32(B);

if (a > b)
{
    Console.WriteLine($"Число {a} больше чем {b} ");
}
else
{
    Console.WriteLine($"Число {b} больше чем {a} ");
}
