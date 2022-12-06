// Задача 2: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке
// от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int s = 0;

string UserInput(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine();
}

int SmNumbersMN(int m, int n)
{
    if (n < m)
    {
        return 0;
    }
    s += m;
    SmNumbersMN(m + 1, n);
    return s;
}

int m = Convert.ToInt32(UserInput("Введите начальное число: "));
int n = Convert.ToInt32(UserInput("Введите конечное число: "));
Console.WriteLine($"Сумма элементов промежутке между {m} и {n} равна: {SmNumbersMN(m, n)}");