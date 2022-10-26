// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int promt(string msg)
{
	Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int numb = promt("Введите трехзначное целое число > ");
int numb_2nd = numb % 100;
numb_2nd = numb_2nd / 10;
Console.WriteLine($"Вторая цифрв числа = {numb_2nd}");