/using static System.Console;
#region

using System;

int[,] matrix = new int[3, 4];
#endregion

#region Многомерные массивы 

// ТипДанных[, ... ,] ИдентификаторМассива = 
// new ТипДанных[размерность №0, размерность №1, ..., размерность №N];
WriteLine("\nint[,,] array3 = new int[2, 3, 4] : ");
int[,,] array3 = new int[2, 3, 4];
WriteLine($"Всего элементов: {array3.Length}");

for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        for (int k = 0; k < array3.GetLength(2); k++)
        {
            WriteLine($"[{i}, {j}, {k}] = {array3[i, j, k]}");
        }
    }
}

int[,,,] array4 = new int[2, 3, 4, 5];

WriteLine("\nint[,,,] array4 = new int[2, 3, 4, 5] : ");
WriteLine($"Всего элементов: {array4.Length}");


for (int i = 0; i < array4.GetLength(0); i++)
{
    for (int j = 0; j < array4.GetLength(1); j++)
    {
        for (int k = 0; k < array4.GetLength(2); k++)
        {
            for (int m = 0; m < array4.GetLength(3); m++)
            {
                WriteLine($"[{i}, {j}, {k}, {m}] = {array4[i, j, k, m]}");
            }
        }
    }
}

int[,,,,] array5 = new int[2, 3, 4, 5, 6];

WriteLine("\nint[,,,,] array5 = new int[2, 3, 4, 5, 6] : ");
WriteLine($"Всего элементов: {array5.Length}");


for (int i = 0; i < array5.GetLength(0); i++)
{
    for (int j = 0; j < array5.GetLength(1); j++)
    {
        for (int k = 0; k < array5.GetLength(2); k++)
        {
            for (int m = 0; m < array5.GetLength(3); m++)
            {
                for (int n = 0; n < array5.GetLength(4); n++)
                {
                    WriteLine($"[{i}, {j}, {k}, {m}, {n}] = {array5[i, j, k, m, n]}");
                }
            }
        }
    }
}

#endregion
