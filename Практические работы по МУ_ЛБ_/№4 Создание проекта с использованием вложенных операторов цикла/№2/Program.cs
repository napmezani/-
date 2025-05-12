Random random = new();

Console.WriteLine
(@$"      День
В.Т.  1    2    3    4    5    6");

int[,] table = new int[5, 6];
int count = 1;

for(int i = 0; i < 5; i++)
{
    Console.Write($"{count}     ");
    count++;

    int price = random.Next(1, 100);
    for(int j = 0; j < 6; j++)
    {
        int amount = random.Next(1, 10);
        table[i, j] = price * amount;
        Console.Write($"{table[i, j]}  ");
    }
    Console.WriteLine();
}
Console.WriteLine();

count = 1;
Console.WriteLine("Общий доход, полученный от продажи каждого вида товара");
for(int i = 0; i < table.GetLength(0); i++)
{
    int income = 0;
    for (int j = 0; j < table.GetLength(1); j++)
    {
        income += table[i, j];
    }
    Console.WriteLine($"{count} товар: {income}");
    count++;
}
Console.WriteLine();

count = 1;
Console.WriteLine("Общий доход, полученный за каждый день");
for (int i = 0; i < table.GetLength(1); i++)
{
    int income = 0;
    for (int j = 0; j < table.GetLength(0); j++)
    {
        income += table[j, i];
    }
    Console.WriteLine($"{count} день: {income}");
    count++;
}