// Алгоритм сортировка выбором
int[] arr = { 1, 4, 6, 8, 4, 9, 7, 3, 2, 1 };
void PrintArray(int[] array) //метод показа массива на экран
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array) //метод сортировки массива выбором
{
    for(int i = 0; i < array.Length - 1; i++) //исскуственно отнимаем, тк в 17 строке мы прибавляли то здесь искуственно отнимаем
    {
        int minPosition = i;// запоминаем
        for(int j = i + 1; j < array.Length; j++) // здесь ищем мах элемент, начальная позиция есть поэтому i+1
        {
           if(array[j] < array[minPosition])
           minPosition = j; //сохраням позицию текущего элементы
        }
        int temporary = array[i]; // меняем местами
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
