// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int NumSum(int a)
{
    int x = 0;
    while (a > 0)
    {
        x = x + a % 10;
        a = a / 10;
    }
    return x;
}

int numb = Prompt("Введите число больше 0 -> ");
int sum = NumSum(numb);
Console.WriteLine($"Сумма цифр введенного числа равна: {sum}");