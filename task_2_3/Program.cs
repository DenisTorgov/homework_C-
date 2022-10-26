// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.

// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6


int randnumb()
{
	int numb_gen = new Random().Next();
	Console.WriteLine($"Случайное сгенерированное целое число {numb_gen}");
 	return numb_gen;
}

int numb = randnumb();
if (numb > 99) 
{
	int length = 0;
	int cutnumb = numb;
	while (cutnumb > 0)
	{
		cutnumb = cutnumb / 10;
		length++;	
	}
	int result = Convert.ToInt32(Math.Floor(numb / (Math.Pow(10, (length - 3)))));
    result = result % 10;
	Console.WriteLine($"Третья цифра числа равна {result}");
}
else
{
	Console.WriteLine("Третьей цифры нет");
}



