// Задача 4. (*) Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] arrspiral = new int[4, 4];
int rang = arrspiral.GetLength(0);

int FillSpiralArray(int[] posij, int m, int n, int direction)
{
    //if (row < m && col < m && row >= 0 && col >= 0 && arrspiral[row, col] == 0)
    //{
    //    arrspiral[row, col] = n;
    //    n++;
    //    FillSpiralArray(row, col + 1, m, n);
    //    FillSpiralArray(row + 1, col, m, n);
    //    FillSpiralArray(row, col - 1, m, n);
    //    FillSpiralArray(row - 1, col, m, n);
    //}
    int i = 0;
    do
    {
        posij = NextPosition(posij, direction);
        arrspiral[posij[0], posij[1]] = n;
        n++;
        if (n > rang * rang) return 1;
        i++;
    }
    while (i < m && posij[0] < rang && posij[1] < rang);
    m -=1;
    direction +=1;
    if (direction > 3) direction = 0;
    i = 0;
    do
    {
        posij = NextPosition(posij, direction);
        arrspiral[posij[0], posij[1]] = n;
        n++;
        if (n > rang * rang) return 1;
        i++;
    }
    while (i < m && posij[0] < rang && posij[1] < rang && n < rang * rang);
    direction +=1;
    if (direction > 3) direction = 0;
    return FillSpiralArray(posij, m, n, direction);
}

int[] NextPosition(int[] pos, int direction)
{
    int row = pos[0];
    int col = pos[1];
    if (direction == 0) col +=1;
    else if (direction == 1) row +=1;
    else if (direction == 2) col -=1;
    else if (direction == 3) row -=1;
    pos[0] = row;
    pos[1] = col;
    return pos;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] startposition = {0, -1};
int startdirect = 0;
FillSpiralArray(startposition, 4, 1, startdirect);
PrintArray(arrspiral);