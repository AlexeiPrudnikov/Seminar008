const int minValue = 10;
const int maxValue = 99;
void Fill3DMatrix(int[,,] matrix)
{
    Random random = new Random();
    int element = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                do
                {
                    element = random.Next(minValue, maxValue +1 );
                }
                while (!IsValidElement(matrix3D: matrix, element: element));
                matrix[i, j, k] = element;
            }
        }
    }
}
bool IsValidElement(int[,,] matrix3D, int element)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                if (matrix3D[i, j, k] == 0) return true; 
                if (matrix3D[i, j, k] == element) return false;
            }
        }
    }
    return false;
}
void Print3DMatrix (int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine($"matrix3D[{i}, {j}, {k}] = {matrix[i, j, k]}");
            }
        }
    }    
}
Console.Clear();
Console.WriteLine("==========Задача № 60==========");
Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая построчно выведет элементы и их индексы");
int[,,] matrix3D = new int[4, 4, 4];
Fill3DMatrix(matrix3D);
Print3DMatrix(matrix3D);