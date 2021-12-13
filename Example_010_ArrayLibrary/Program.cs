// Методы заполнения массива и его показ на экране

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] position)
{
    int size = position.Length;
    int count = 0;
    while (count < size)
    {
        Console.Write(position[count] +" ");
        count++;
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);