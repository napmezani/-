Random random = new();
int[,] A = new int[8, 8];

for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        A[i, j] = random.Next(10, 90);
        Console.Write($"{A[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int firstIndex = 0;
int secondIndex = 0;
bool confirm = false;

for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        if (confirm == false)
        {
            confirm = true;
            firstIndex = i;
            secondIndex = j;
        }
        else if (A[firstIndex, secondIndex] > A[i, j])
        {
            firstIndex = i;
            secondIndex = j;
        }
    }
}
Console.WriteLine($"Минимальный индекс числа ({A[firstIndex, secondIndex]}): {firstIndex}, {secondIndex}");