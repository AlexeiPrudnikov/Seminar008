static void FillArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 2);
        }
    }
    array[0, 0] = 1;
    array[array.GetLength(0) - 1, array.GetLength(1) - 1] = 1;
}
static void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}
static bool IsInList(Element element, List<Element> list)
{
    foreach (Element el in list)
    {
        if ((el.Row == element.Row) && (el.Column == element.Column)) return true;
    }
    return false;
}
static void GetWay(int[,] array, Element newStep, List<Element> previousSteps)
{
    Element nextStep = new Element();
    previousSteps.Add(newStep);
    int minRow = newStep.Row - 1;
    if (minRow < 0) minRow = 0;
    int maxRow = newStep.Row + 1;
    if (maxRow > (array.GetLength(0) - 1)) maxRow = array.GetLength(0) - 1;
    int minColumn = newStep.Column - 1;
    if (minColumn < 0) minColumn = 0;
    int maxColumn = newStep.Column + 1;
    if (maxColumn > (array.GetLength(1) - 1)) maxColumn = array.GetLength(1) - 1;
    for (int i = minRow; i <= maxRow; i++)
    {
        for (int j = minColumn; j <= maxColumn; j++)
        {
            if ((i == newStep.Row) && (j == newStep.Row))
            {
                continue;
            }
            else
            {
                if (array[i, j] == 1)
                {

                    nextStep.Row = i;
                    nextStep.Column = j;
                    if ((i == array.GetLength(0) - 1) && (j == array.GetLength(1) - 1))
                    {
                        previousSteps.Add(nextStep);
                        return;
                    }
                    if (!IsInList(nextStep, previousSteps))
                    {
                        GetWay(array, nextStep, previousSteps);
                    }
                }
            }
        }
    }
}
int n = 5;
int[,] array = new int[n, n];
FillArray(array);
PrintArray(array);
Element start = new Element();
start.Row = 0;
start.Column = 0;
Element finish = new Element();
finish.Row = array.GetLength(0) - 1;
finish.Column = array.GetLength(1) - 1;
List<Element> steps = new List<Element>();
GetWay(array, start, steps);
Console.Write("Маршрут");
if (!IsInList(finish, steps)) Console.Write("а НЕ");
Console.WriteLine(" существует");
struct Element
{
    public int Row { get; set; }
    public int Column { get; set; }
}