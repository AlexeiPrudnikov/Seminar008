const int minValue = -2;
const int maxValue = 2;
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

Dictionary<int, int> GetStatElements(int[,] matrix)
{
    Dictionary<int, int> elemensStat = new Dictionary<int, int>();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (elemensStat.ContainsKey(matrix[i, j]))
            {
                elemensStat[matrix[i, j]]++;
            }
            else
            {
                elemensStat.Add(matrix[i, j], 1);
            }
        }
    }
    return elemensStat;
}
void PrintDictionary (Dictionary<int, int> dictionary)
{
    foreach(var num in dictionary)
    {
        Console.WriteLine($"[{num.Key}] -> {num.Value}");
    }
}
Console.Clear();
Console.WriteLine("==========Дополнительная задача № 2==========");
Console.WriteLine("Дан двумерный массив, заполненный случайными числами от -9 до 9. Подсчитать частоту вхождения каждого числа в массив, используя словарь");
Random random = new Random();
int[,] matrix = new int[random.Next(minSize, maxSize), random.Next(minSize, maxSize)];
Console.WriteLine("Матрица:");
FillMatrix(matrix);
PrintMatrix(matrix);
Dictionary<int, int> elemensStat = GetStatElements(matrix);
PrintDictionary(elemensStat);
