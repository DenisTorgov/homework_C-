// Задача 3

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int prompt (string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int cube (int numb)
{
    return numb*numb*numb;
}

int n = prompt("Введите целое число");
for (int i = 1; i < n; i++)
{
    Console.Write($"{cube(i)}, ");
}
Console.Write($"{cube(n)}");