const int minValue = -9;
const int maxValue = 10;
const int minSize = 2;
const int maxSize = 10;
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
int[,] MultMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                result[i, j] += (firstMatrix[i, k] * secondMatrix [k, j]);
            }
        }
    }
    return result;
}
Console.Clear();
Console.WriteLine("==========Задача № 58==========");
Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц");
int k = new Random().Next(minSize, maxSize + 1);
int m = new Random().Next(minSize, maxSize + 1);
int n = new Random().Next(minSize, maxSize + 1);
int[,] firstMatrix = new int[k, m];
int[,] secondMatrix = new int[m, n];
FillMatrix(firstMatrix);
FillMatrix(secondMatrix);
Console.WriteLine("Первая матрица:");
PrintMatrix(firstMatrix);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintMatrix(secondMatrix);
Console.WriteLine();
Console.WriteLine("Результат умножения матриц:");
int [,] multMatrix = MultMatrix(firstMatrix, secondMatrix);
PrintMatrix(multMatrix);
Console.WriteLine();