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
int GetIndexMinSumRow (int[,] matrix)
{
    int minIndex = 0;
    int minSumm = 0;
    int rowSumm = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        rowSumm = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSumm+= matrix[i, j];
        }
        if (i == 0)
        {
            minSumm = rowSumm;
        }
        else
        {
            if (minSumm > rowSumm)
            {
                minIndex = i;
                minSumm = rowSumm;
            }
        }
    }  
    return minIndex;

}
Console.Clear();
Console.WriteLine("==========Задача № 56==========");
Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов");
Random random = new Random();
int[,] matrix = new int[random.Next(minSize, maxSize), random.Next(minSize, maxSize)];
Console.WriteLine("Матрица:");
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Индекс строки с минимальной суммой элементов -> {GetIndexMinSumRow(matrix)}");
