Random random = new();
int[,] A = new int[random.Next(1, 10), random.Next(1, 10)];

for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        A[i, j] = random.Next(-10, 10);
        Console.Write($"{A[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Сумма элементов:");

for (int i = 0; i < A.GetLength(1); i++)
{
    bool check = false;

    for (int j = 0; j < A.GetLength(0); j++)
    {
        if (A[j, i] < 0)
            check = true;
    }

    if (check)
    {
        int sum = 0;
        for (int j = 0; j < A.GetLength(0); j++)
        {
            sum += A[j, i];
        }
        Console.Write($"{sum}\t");
    }
    else
        Console.Write("\t");
}