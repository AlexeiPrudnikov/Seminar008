const int minSize = 3;
const int maxSize = 5;
void FillSnakeMatrix(int[,] matrix)
{
    int value = 1;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j % 2 == 0)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, j] = value;
                value++;
            }
        }
        else
        {
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                matrix[i, j] = value;
                value++;
            }
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
Console.WriteLine("==========Дополнительная задача № 4==========");
Console.WriteLine("Заполните двумерный массив числами от 1 до n змейкой");
Random random = new Random();
//int[,] matrix = new int[random.Next(minSize, maxSize + 1), random.Next(minSize, maxSize + 1)];
int[,] matrix = new int[random.Next(minSize, maxSize + 1), random.Next(minSize, maxSize + 1)];
FillSnakeMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
