//***************************** КОД ИЗ №7 ДЛЯ СОЗДАНИЯ МАТРИЦЫ *****************************//
Random random = new();
int[,] matr = new int[random.Next(1, 10), random.Next(1, 10)];

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = random.Next(-2, 10);
    }
}

Console.WriteLine("Исходная матрица:");
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]}\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < matr.GetLength(1); i++)
{
    int[] column = new int[matr.GetLength(0)];
    for (int j = 0; j < matr.GetLength(0); j++)
    {
        column[j] = matr[j, i];
    }

    if (i % 2 == 0)
        QuickSort(ref column, 0, column.Length - 1, descending: true);
    else
        QuickSort(ref column, 0, column.Length - 1, descending: false);

    for (int j = 0; j < matr.GetLength(0); j++)
    {
        matr[j, i] = column[j];
    }
}

Console.WriteLine();
Console.WriteLine("Отсортированная матрица:");
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]}\t");
    }
    Console.WriteLine();
}

static void QuickSort(ref int[] column, int up, int down, bool descending)
{
    if (up < down)
    {
        int pivot = Partition(ref column, up, down, descending);
        QuickSort(ref column, up, pivot - 1, descending);
        QuickSort(ref column, pivot + 1, down, descending);
    }
}

static int Partition(ref int[] column, int up, int down, bool descending)
{
    int mainNum = column[down];
    int i = up - 1;

    for (int j = up; j < down; j++)
    {
        if ((!descending && column[j] <= mainNum) || (descending && column[j] >= mainNum))
        {
            i++;
            Swap(ref column[i], ref column[j]);
        }
    }

    Swap(ref column[i + 1], ref column[down]);
    return i + 1;
}

static void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
//***************************** КОД ИЗ №7 ДЛЯ СОЗДАНИЯ МАТРИЦЫ *****************************//

Console.WriteLine("");
for (int i = 0; i < matr.GetLength(0); i++)
{
    bool check = true;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        if (matr[i, j] < 0)
            check = false;
    }

    if (check)
    {
        Console.WriteLine($"Номер строки - №{i + 1}");
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] % 2 == 0 ? "Чет\t": "Нечет\t");
        }
        break;
    }
}
