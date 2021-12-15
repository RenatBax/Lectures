// Двумерные (многомерные) массивы
//                                 0 1 2 3 4                
// string[,] table = new string[2 ,5];
//                              0
//                              1
// table[0,0]  table[0,1] table[0,2] ... table[0,4]
// table[1,0]  table[1,1] table[1,2] ... table[1,4]
// String.Empty;

// string[,] table = new string[2, 5];
// table[1, 2] = "слово";
// //table[1, 3] = "золото"; //изучал работу
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 5; colums++)
//     {
//         //Console.WriteLine($"{table[rows, colums]}");//выводится но не видно
//         Console.WriteLine($"-{table[rows, colums]}-");//для наглядности добавили -
//         //Console.Write($"*{table[rows, colums]}*");
//     }
//     Console.WriteLine();// разрыв между строк
// }

// string[,] table = new string[2, 5];// *замена местами не помогает
// table[1, 2] = "слово";// * замена размерности не помогает
// for (int colums = 0; colums < 5; colums++) // поменял местами, работает*
// {
//     for (int rows = 0; rows < 2; rows++)
//     {
//         //Console.WriteLine($"*{table[colums, rows]}");//* при замене местами с на r пишет про переполнение
//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
//     Console.WriteLine();// разрыв между строк
// }

// int[,] matrix = new int [3,4]; // тоже самое с числами
// for (int i = 0; i < 3; i++)
// {
//     for ( int j = 0; j < 4; j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// int[,] matrix = new int [3,4]; // [3,4] - это сколько памяти нужно выделить
// for (int i = 0; i < matrix.GetLength(0); i++) //GetLength (0) - длина строк
// {
//     for ( int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Метод показа и заполнения матрицы

// int[,] matrix = new int [3,4]; // 

// void PrintArray(int[,] matr) //метод показа на экран
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) 
//     {
//         for ( int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }  
// void FillArray(int[,] matr) // метод заполнения
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) 
//     {
//         for ( int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10); //заполнение случайными от до
//         }
//         Console.WriteLine();
//     }
// }  
// PrintArray(matrix); 
// FillArray(matrix); 
// PrintArray(matrix); 

//#region Вывод на экран 4 не работает из репа Сергея

// Write("Количество строк: ");
// int row = Convert.ToInt32(ReadLine());

// Write("Количество столбцов: ");
// int col = Convert.ToInt32(ReadLine());

// Random r = new Random();

// int[,] table = new int[row, col];

// for (int i = 0; i < table.GetLength(0); i++)
// {
//    for (int j = 0; j < table.GetLength(1); j++)
//    {
//        table[i, j] = r.Next(1, 5);
//        Write($"{table[i, j]} ");
//    }
//    WriteLine();
// }

// ReadLine();
//#endregion


using static System.Console;

#region Двумерные массивы 

#region Теория

// 1 1 2 3 5 8 13 21 32 - одномерный массив
// 0 1 2 3 4 5  6  7  8
// А если нужна таблица?
// ┌───────────────┐
// │ 1   2   3   4 │  0 строка
// │ 4   5   6   7 │  1 строка
// │ 7   8   9   0 │  2 строка
// └───────────────┘
//   0   1   2   3
//     столбец
//
// ТипДанных[,] ИдентификаторМассива = new ТипДанных[КоличествоСтрок, КоличествоСтолбцов];
//                                                   размерность №0   размерность №1
#endregion

using System;

int[,] matrix = new int[3, 4];

#region Вывод на экран 1

//for (int i = 0; i < 4; i++) { Write($"{matrix[0, i]} "); }
//WriteLine();
//for (int i = 0; i < 4; i++) { Write($"{matrix[1, i]} "); }
//WriteLine();
//for (int i = 0; i < 4; i++) { Write($"{matrix[2, i]} "); }
//WriteLine();

#endregion
#region Вывод на экран 2

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        Write($"{matrix[i, j]} ");
//    }
//    WriteLine();
//}

#endregion
#region Вывод на экран 3

//WriteLine(matrix.Rank);
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Write($"{matrix[i, j]} ");
//    }
//    WriteLine();
//}

#endregion
#region Вывод на экран 4

//Write("Количество строк: ");
//int row = Convert.ToInt32(ReadLine());

//Write("Количество столбцов: ");
//int col = Convert.ToInt32(ReadLine());

//Random r = new Random();

//int[,] table = new int[row, col];

//for (int i = 0; i < table.GetLength(0); i++)
//{
//    for (int j = 0; j < table.GetLength(1); j++)
//    {
//        table[i, j] = r.Next(1, 5);
//        Write($"{table[i, j]} ");
//    }
//    WriteLine();
//}

//ReadLine();
#endregion

#endregion
