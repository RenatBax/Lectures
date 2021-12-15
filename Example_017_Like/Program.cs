// 
int[,] pic = new int[23, 25];
//int[,] pic = new int[,];
void PrintImage(int[,] image) //метод показа на экран
{
    for (int row = 0; row < image.GetLength(0); row++) 
    {
        for ( int col = 0; col < image.GetLength(1); col++)
        {
            //Console.Write($"{image[i, j]} ");
            if (image[row, col] == 0) Console.Write($"0");
            Console.Write($"+");
        }
        Console.WriteLine();

    }
}  
// void FillImage(int row, int col) // метод заполнения
// {
//     if (pic[row, col] == 0) 
//     {
//         pic[row, col] = 1;
//         FillImage(row-1, col);
//         FillImage(row, col-1);
//         FillImage(row+1, col);
//         FillImage(row, col+1);
//     }
// }  

PrintImage(pic); 
// FillImage(12, 12);
// PrintImage(pic);
