// Написать программу на языке С#
// для Windows и MacOS в которую пользователь 
// вводит два целых числа?
// в которой записаны два целых? числа?
// два целых? числа генерируются случайным образом?
// и получает сумму
// АЛГОРИТМ
// Начало
// Определить numberA
// Определить numberB
// Вывод numberA + numberB
// Конец

int numberA = 3;
int numberB = 5;
Console.WriteLine(numberA + numberB);
Console.WriteLine();

int result = numberA + numberB;
Console.WriteLine(result);
Console.WriteLine();
// new Random().Next(min, max);  генератор случайных чисел
// даст случайное число от мин до мах-1 

int numberC = new Random().Next(1, 10);
Console.WriteLine(numberC);
int numberD = new Random().Next(1, 10);
Console.WriteLine(numberD);
int sum = numberD + numberC;
Console.WriteLine(sum);