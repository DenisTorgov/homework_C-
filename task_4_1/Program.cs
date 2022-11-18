// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

double NumPower(int a, int n)
{
    double ans = 1;

    while (n > 0)
    {
        if (n % 2 == 0)
        {
            a = a*a;
            n = n / 2;
        }
        else
        {
            ans = ans * a;
            n = n - 1;
        } 

    }
    return ans;
}

int numb = Prompt("Введите число больше 0 -> ");
int stepen = Prompt("Введите степень больше 0 -> ");
double x = NumPower(numb, stepen);
Console.WriteLine($"Число {numb} в степени {stepen} равно: {x}");