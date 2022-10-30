// Задача 1

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Без использования строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int promt(string msg)
{
	Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

bool palindrom(int[] arrayforcheck)
{
    int n = arrayforcheck.Length;
	for (int j = 0; j < n/2; j++)
    {
        if (arrayforcheck[j] != arrayforcheck[n-j-1])
        {
            return false;
        }
    }
    return true;
}

int numb = promt("Введите пятизначное целое число > ");
int[] arrnumb ={};

	int i = 0;
    int nextnumb = 0;
	while (numb > 0)
	{
		nextnumb = numb % 10;
        Array.Resize(ref arrnumb, i+1);
        arrnumb[i] = nextnumb;
        numb = numb / 10;
		i++;	
	}
if (palindrom(arrnumb)) 
{
	Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}