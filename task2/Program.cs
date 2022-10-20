// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите два числа a, b и c ");

string A = Console.ReadLine();
string B = Console.ReadLine();
string C = Console.ReadLine();

int a = Convert.ToInt32(A);
int b = Convert.ToInt32(B);
int c = Convert.ToInt32(C);

if (a > b)
{
   if (a > c) 
     {
           Console.WriteLine($"Число {a} больше чем {b} и {c} ");
       }
    else
    {
         Console.WriteLine($"Число {c} больше чем {a} и {b} ");
    }
}
else 
    {
     if (b > c) 
      {
         Console.WriteLine($"Число {b} больше чем {a} и {c} ");
      }
       else
      {
           Console.WriteLine($"Число {c} больше чем {a} и {b} ");
      }
    }
