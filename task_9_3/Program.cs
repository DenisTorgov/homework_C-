// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
// m = 2, n = 3 -> A(m,n) = 9

int Akkerman (int n, int m)
{
    if (n == 0)
    {
        return m += 1;
    }
    else if (m == 0)
    {
        return Akkerman(n-1, 1);
    }
    else
    {
        return Akkerman(n - 1, Akkerman(n, m - 1));
    }
}


int n = 3;
int m = 2;

Console.WriteLine($"Значение функции Аккермана  A({n}, {m}) равно: {Akkerman(n, m)}");