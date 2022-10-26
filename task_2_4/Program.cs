// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int promt(string msg)
{
	Console.WriteLine(msg);
 	return Convert.ToInt32(Console.ReadLine());
}

int numb = promt("Введите номер дня недели > ");
string[] week = {"Пон", "Вт", "Ср", "Чт", "Пят", "Суб", "Вос"};

if (numb > 7)
{
    Console.WriteLine("Дней недели только 7. Введиче число меньше 7.");
}
else
{
    Console.WriteLine($"Этому номеру соответствует {week[numb-1]}");
}