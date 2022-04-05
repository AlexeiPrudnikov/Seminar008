const int minValue = 0;
const int maxValue = 20;
const int minSize = 3;
const int maxSize = 5;
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
void UpdateMatrixWithDiagonal(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {

        if (i == matrix.GetLength(1) - 1)
        {
            int temp = matrix[0, i];
            matrix[0, i] = matrix[i,i];
            matrix[matrix.GetLength(0) - 1, i] = temp;
        }
        else
        {
            matrix[0, i] = matrix[i,i];
            matrix[matrix.GetLength(0) - 1, i] = matrix[matrix.GetLength(0) - 1 - i, i];
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
Console.Clear();
Console.WriteLine("==========Дополнительная задача № 1==========");
Console.WriteLine("Дан двумерный массив. Заменить в нём элементы первой строки элементами главной диагонали. А элементы последней строки, элементами побочной диагонали.");
Random random = new Random();
int n = random.Next(minSize, maxSize + 1);
int[,] matrix = new int[n, n];
FillMatrix(matrix);
Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Измененная матрица:");
UpdateMatrixWithDiagonal(matrix);
PrintMatrix(matrix);