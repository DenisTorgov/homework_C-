// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все чётные натуральные числа в промежутке
// от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

string UserInput(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine();
}

void PrintEvenNumbersMN(int m, int n)
{
    if (n < m)
    {
        return;
    }
    Console.WriteLine(m);
    PrintEvenNumbersMN(m + 2, n);
}

int m = Convert.ToInt32(UserInput("Введите начальное число: "));
int n = Convert.ToInt32(UserInput("Введите конечное число: "));
if (m % 2 == 0)
{
    PrintEvenNumbersMN(m,n);
}
else
{
    m += 1;
    PrintEvenNumbersMN(m,n);
}