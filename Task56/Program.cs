const int minValue = -10;
const int maxValue = 10;
const int minSize = 3;
const int maxSize = 7;
void FillMatrix(int[,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(minValue, maxValue +1 );
        }
    }
}
void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }    
}
void SortDownRow(int[,] matrix, int row)
{
    int maxIndex;
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        maxIndex = i;
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[row, j] > matrix[row, maxIndex]) maxIndex = j;
        }
        if (maxIndex != i)
        {
            temp = matrix[row, i];
            matrix[row, i] = matrix[row, maxIndex];
            matrix[row, maxIndex] = temp;
        }

    }
}
void SortDownRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        SortDownRow(matrix: matrix, row: i);
    }
}

Console.Clear();
Console.WriteLine("==========Задача № 54==========");
Console.WriteLine("Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Random random = new Random();
int[,] matrix = new int[random.Next(minSize, maxSize), random.Next(minSize, maxSize)];
Console.WriteLine("Матрица:");
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
SortDownRows(matrix);
Console.WriteLine("Матрица с отсортированными по убыванию строками:");
PrintMatrix(matrix);