// Сортировка выбором от мах к мин

void CreateArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(1, 21);
        
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] +" ");
    }
}
void SelectionSort(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            maxPosition = j;
        }
        int place = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = place;
    }
}

int[] arr = new int[10];
CreateArray(arr);
PrintArray(arr);
Console.WriteLine();
SelectionSort(arr);
PrintArray(arr);
