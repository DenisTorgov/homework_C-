// При помощи рекурсии вывести последовательность чисел, с заданым количеством этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int PrintNumb(int n, int j)
{
    for (int i = 0; i < j; i++)
    {
        Console.Write($"{j} ");
        n = n - 1;
        if (n == 0 ) return 1;
    }
    return PrintNumb(n, j + 1);
}

int numb = Prompt("Введите число больше 0 -> ");
PrintNumb(numb, 1);