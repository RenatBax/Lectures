// Имеется одномерный массив array из n элементов, требуется
// найти элемент массива, равный find.
// Решение с помощью методов

void FillArray(int[] colection)
{
    int length = colection.Length;
    for(int i = 0; i < length; i++)
    {
        colection[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] col)
{
    int size = col.Length;
    for(int j = 0; j < size; j++)
    {
        Console.Write(col[j] +" ");
    }
}

int IndexOff(int[]colection, int find)
{
    int index = 0;
    int n = colection.Length;
    int position = -1; // если элемента не то -1 будеи интерпретиповать что искомый элемент не найден
    while(index < n)
    {
        if(colection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexOff(array, 5);
Console.WriteLine(pos);

