const int maxSize = 10; 
const int minSize = 4; 

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
void PutCircle(int[,] matrix, int step)
{
    int value;
    if (step == 1)
    {
        value = 0;
    }
    else
    {
        value = matrix[step - 1, step - 2];
    }
    value++;
    /// Верхняя строка
    for (int i = (step - 1); i < (matrix.GetLength(0) - step + 1); i++)
    {
        matrix[step - 1, i] = value;
        value++;
    }
    /// Правый столбец
    for (int i = (step); i < (matrix.GetLength(1) - step + 1); i++)
    {
        matrix[i, matrix.GetLength(1) - step] = value;
        value++;
    }
    /// Нижняя строка
    for (int i = matrix.GetLength(0) - step - 1; i >= (step - 1); i--)
    {
        matrix[matrix.GetLength(0) - step, i] = value;
        value++;
    }
    /// Левый столбец
    for (int i = matrix.GetLength(1) - step - 1; i > (step - 1); i--)
    {
        matrix[i, step - 1] = value;
        value++;
    }
    return;
}
void FillSnailMatrix(int[,] matrix)
{
    int steps = (matrix.GetLength(0) / 2) + (matrix.GetLength(0) % 2);
    for (int i = 1; i <= steps; i++)
    {
        PutCircle(matrix, i);
    }
}
Console.Clear();
Console.WriteLine("==========Задача № 62==========");
Console.WriteLine("Заполните спирально квадратную матрицу от 1 до N");
Random random = new Random();
int n = random.Next(minSize, maxSize + 1);
int[,] matrix = new int[n, n];
FillSnailMatrix(matrix);
PrintMatrix(matrix);